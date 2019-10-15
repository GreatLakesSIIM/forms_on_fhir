using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using ResultDotNet;
using static ResultDotNet.Result;

namespace FormsOnFHIR {
  public class MainMenuFormDriver {

    IRestClient client;

    public MainMenuFormDriver(IRestClient c) {
      client = c;
    }

    public Result<string, string> ChooseSyntheaGeneratedDataFile() {
      using (var dialog = new OpenFileDialog() { Filter = "JSON Files (*.json)|*.json" }) {
        if (dialog.ShowDialog() == DialogResult.OK) {
          var sr = new StreamReader(dialog.FileName);
          return Ok<string, string>(sr.ReadToEnd());
        } else {
          return Error<string, string>("");
        }
      }
    }

    public IRestResponse UploadSyntheaGeneratedData(string raw) {
      var request = new RestRequest(Method.POST);
      request.RequestFormat = DataFormat.Json;
      request.AddJsonBody(raw);
      var response = client.Execute(request);
      return response;
    }

  }
}
