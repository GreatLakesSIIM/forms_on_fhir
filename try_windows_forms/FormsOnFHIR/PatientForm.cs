using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsOnFHIR {
  public partial class PatientForm : Form, IAdministrativeFhirResource {
    public PatientForm() {
      InitializeComponent();
    }

    private void PatientForm_Load(object sender, EventArgs e) {
      // TODO: clear entry fields
    }

    public void EnterInfo() {
      if (ShowDialog() == DialogResult.OK) {

      }
    }

    private void SubmitPatientInfo_Click(object sender, EventArgs e) {
      Close();
    }

  }
}
