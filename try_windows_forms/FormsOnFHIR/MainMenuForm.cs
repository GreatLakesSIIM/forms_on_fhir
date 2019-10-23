using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using RestSharp;

namespace FormsOnFHIR {

  public interface IAdministrativeFhirResource {
    void EnterInfo();
    void Search();
  }

  public partial class MainMenuForm : Form {

    static IRestClient client;
    static IFhirClient fhirClient;
    static string fhirResourceString;
    static PatientForm patientForm;
    MainMenuFormDriver driver;

    public MainMenuForm() {
      InitializeComponent();

      // initialize resource string
      fhirResourceString = "";

      // set up restful client
      client = new RestClient("http://hackathon.siim.org/fhir/");
      client.AddDefaultHeader("Content-Type", "application/fhir+json");
      client.AddDefaultHeader("apikey", Environment.GetEnvironmentVariable("SiimApiKey"));
      driver = new MainMenuFormDriver(client);

      // make form instances
      fhirClient = new FhirClient("http://hackathon.siim.org/fhir/");
      fhirClient.OnBeforeRequest += (object sender, BeforeRequestEventArgs e) => {
        e.RawRequest.Headers.Add("apikey", Environment.GetEnvironmentVariable("SiimApiKey")); //requires environment variable to match
      };
      patientForm = new PatientForm(fhirClient);
    }

    private void ChooseSyntheaGeneratedFilesBtn_Click(object sender, EventArgs e) {
      this.Enabled = false;
      var status = driver.ChooseSyntheaGeneratedDataFile();
      if (status.IsOk) {
        fhirResourceString = status.Expect();
        var parser = new FhirJsonParser();
        var bundle = parser.Parse<Bundle>(fhirResourceString);
        resourceTypeDisplayLabel.Text = bundle.Entry[0].Resource.TypeName;
        foreach (var entryComponent in bundle.Entry) {
          var resource = entryComponent.Resource;
          if (resource.ResourceType == ResourceType.Patient) {
            var p = new Patient();
            entryComponent.Resource.CopyTo(p);
            patientForm.Display(p);
          }
        }
      } else {
        var result = MessageBox.Show("Doh! Something went wrong\nWould you like to create a Patient from scratch?", "Doh!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        switch (result) {
          case DialogResult.Yes:
            patientForm.EnterInfo();
            break;
          default:
            break;
        }
      }
      this.Enabled = true;
    }

    private void CmdUploadFiles_Click(object sender, EventArgs e) {
      this.Enabled = false;
      var response = driver.UploadSyntheaGeneratedData(fhirResourceString);
      // TODO: indicate success or failure to upload
      if (response.IsSuccessful) {
        MessageBox.Show("FHIR Resource Successfully Uploaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
      } else {
        MessageBox.Show("Upload failed... :(", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      fhirResourceString = "";
      this.Enabled = true;
    }

    private void NewPatientToolStripMenuItem_Click(object sender, EventArgs e) {
      patientForm.EnterInfo();
    }

    private void SearchForPatientToolStripMenuItem_Click(object sender, EventArgs e) {
      patientForm.Search();
    }

  }
}
