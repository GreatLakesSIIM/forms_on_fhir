using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hl7.Fhir.Rest;

namespace FormsOnFHIR {

  public interface IAdministrativeFhirResource {
    void EnterInfo();
  }

  public partial class MainMenuForm : Form {

    static FhirClient client;
    static PatientForm patientForm;

    public MainMenuForm() {
      InitializeComponent();
      client = new FhirClient("http://hackathon.siim.org/fhir/", true);
      client.OnBeforeRequest += (object sender, BeforeRequestEventArgs e) => {
        e.RawRequest.Headers.Add("apikey", Environment.GetEnvironmentVariable("SiimApiKey")); //requires environment variable to match
      };
      patientForm = new PatientForm(client);
    }

    private void PatientToolStripMenuItem_Click(object sender, EventArgs e) {
      patientForm.EnterInfo();
    }
  }
}
