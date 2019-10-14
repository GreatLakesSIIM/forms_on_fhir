using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOnFHIR {
  public class MainMenuFormDriver {

    IRestClient client;

    public MainMenuFormDriver(IRestClient c) {
      client = c;
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
