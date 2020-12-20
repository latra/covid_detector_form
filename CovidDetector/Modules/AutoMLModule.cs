using CovidDetector.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace CovidDetector.Modules
{
    public class AutoMLModule
    {
        public AutoMLModule()
        {
            this.autoMLAPI = new API();
        }

        public API autoMLAPI { get; set; }
        public class API
        {
            public ResponseModel getPredict(PatientDAO patient)
            {
                string resonse = POSTRequest(JsonSerializer.Serialize(patient));
                JObject json = JObject.Parse(resonse);
                ResponseModel response = new ResponseModel();
                foreach (var element in json["payload"] )
                {
                    var info = element["tables"];
                    var score = float.Parse(info["score"].ToString());
                    var value = info["value"].ToString();
                    if (value == "1")
                    {
                        response.prob_A = score;
                    } else if (value == "2")
                        response.prob_B = score;
                    else if (value == "3")
                        response.prob_C = score;
                }
                return response;
            }
            private string POSTRequest(string postData)
            {
                string url = "https://eu-automl.googleapis.com/v1beta1/projects/jofre-ext/locations/eu/models/TBL7988937138211127296:predict";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add("Authorization", "Bearer");
                request.ContentType = "application/json; charset=utf-8";
                request.Method = "POST";
                var data = Encoding.ASCII.GetBytes(postData);

                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                Console.WriteLine(responseString);
                return responseString;
            }
        }
    }
}
