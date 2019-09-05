﻿using System;
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
      client = c;
    }

    private void PatientForm_Load(object sender, EventArgs e) {
      adminGenderSelector.DataSource = Enum.GetNames(typeof(AdministrativeGender));
      // TODO: clear entry fields
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

    private void SubmitPatientInfo_Click(object sender, EventArgs e) {
      Close();
    }

  }
}
