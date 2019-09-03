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

  public interface IAdministrativeFhirResource {
    void EnterInfo();
  }

  public partial class MainMenuForm : Form {

    static PatientForm patientForm;

    public MainMenuForm() {
      InitializeComponent();
      patientForm = new PatientForm();
    }

    private void PatientToolStripMenuItem_Click(object sender, EventArgs e) {
      patientForm.EnterInfo();
    }
  }
}
