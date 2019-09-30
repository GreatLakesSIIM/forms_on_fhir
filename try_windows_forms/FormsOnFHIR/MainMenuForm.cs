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
    static PatientForm patientForm;
    MainMenuFormDriver driver;

    public MainMenuForm() {
      InitializeComponent();
      client = new RestClient("http://hackathon.siim.org/fhir/");
      client.AddDefaultHeader("Content-Type", "application/fhir+json");
      client.AddDefaultHeader("apikey", "428c400d-5f92-40be-9bf5-f27cc8a3e483");
      driver = new MainMenuFormDriver(client);

      // make form instances
      fhirClient = new FhirClient("http://hackathon.siim.org/fhir/");
      fhirClient.OnBeforeRequest += (object sender, BeforeRequestEventArgs e) => {
        e.RawRequest.Headers.Add("apikey", Environment.GetEnvironmentVariable("SiimApiKey")); //requires environment variable to match
      };
      patientForm = new PatientForm(fhirClient);
    }

    private void ChooseSyntheaGeneratedFilesBtn_Click(object sender, EventArgs e) {
      using (var dialog = new OpenFileDialog() { Filter = "JSON Files (*.json)|*.json" }) {
        if (dialog.ShowDialog() == DialogResult.OK) {
          var sr = new StreamReader(dialog.FileName);
          driver.UploadSyntheaGeneratedData(sr.ReadToEnd());
        }
      }
    }

    private void NewPatientToolStripMenuItem_Click(object sender, EventArgs e) {
      patientForm.EnterInfo();
    }

    private void SearchForPatientToolStripMenuItem_Click(object sender, EventArgs e) {
      patientForm.Search();
    }

  }
}
