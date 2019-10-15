using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

namespace FormsOnFHIR {
  public partial class PatientForm : Form, IAdministrativeFhirResource {

    IFhirClient client;

    public PatientForm(IFhirClient c) {
      InitializeComponent();
      adminGenderSelector.DataSource = Enum.GetNames(typeof(AdministrativeGender));
      client = c;
    }

    public void EnterInfo() {
      if (ShowDialog() == DialogResult.OK) {
        var patient = new Patient();
        // patient identifier
        patient.Identifier.Add(new Identifier {
          SystemElement = new FhirUri("http://hl7.org/fhir/sid/us-ssn"),
          ValueElement = new FhirString("000-12-3456")
        });
        /* TODO: work on generating id */
        // official name
        patient.Name.Add(new HumanName() {
          Given = new string[] {
            patientFirstNameEntry.Text,
            patientMiddleInitialEntry.Text
          },
          Family = patientLastNameEntry.Text,
          Use = HumanName.NameUse.Official
        });
        // gender
        patient.Gender = (AdministrativeGender)adminGenderSelector.SelectedItem;
        // DOB
        patient.BirthDate = patientDOBPicker.Value.ToShortDateString();
        patient.Deceased = new FhirBoolean(false);  // lol
        // phone number
        patient.Telecom.Add(new ContactPoint(
          ContactPoint.ContactPointSystem.Phone,
          ContactPoint.ContactPointUse.Mobile,
          patientPhoneEntry.Text));
        // create resource
        client.Create(patient);
      }
    }

    public void Search() {
      var resource = client.Get("/Patient/");
      foreach (var child in resource.Children) {
        if (child.TypeName == "EntryComponent") {
          foreach (var c in child.Children) {
            if (c.TypeName == "Patient") {

            }
          }
        }
      }
      ShowDialog();
    }

    public void Display(Patient p) {
      var name = p.Name.Where(it => it.Use == HumanName.NameUse.Official).First();
      patientFirstNameEntry.Text = name.Given.First();
      patientMiddleInitialEntry.Text = p.Name.Where(it => it.Use == HumanName.NameUse.Official).First().Given.Last();
      patientLastNameEntry.Text = name.Family;
      adminGenderSelector.SelectedItem = Enum.GetName(typeof(AdministrativeGender), p.Gender);
      patientDOBPicker.Value = p.BirthDateElement.ToDateTimeOffset().Value.DateTime;
      var deceased = p.Deceased;
      patientPhoneEntry.Text = p.Telecom.Where(it => it.Use == ContactPoint.ContactPointUse.Home).First().Value;
      //
      ShowDialog();
    }

    private void SubmitPatientInfo_Click(object sender, EventArgs e) {
      Close();
    }

  }
}
