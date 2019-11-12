using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hl7.Fhir.Model;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Specification;

namespace FormsOnFHIR {
  public partial class OrganizationForm : UserControl, IAdministrativeFhirResource {
    public OrganizationForm() {
      InitializeComponent();
      var types = new[] { "" };

      orgTypeSelector.DataSource = types;
    }

    public void EnterInfo() {
      throw new NotImplementedException();
    }

    public void Search() {
      throw new NotImplementedException();
    }
  }
}
