using DecisionsFramework.Design.Flow;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Taggun.verbose;

namespace Taggun
{

    [AutoRegisterMethodsOnClass(true, "Integration", "Taggun", RegisterForAgents = true)]
    public class Taggun
    {
        
        public String taggunApiUrlAvailable()
        {
            return "https://api.taggun.io/api/receipt/v1/simple/file and https://api.taggun.io/api/receipt/v1/verbose/file ";
        }

        public string  RunService(string FileName, string APIKey,string TaggunApiUrl)
        {
            var fileName =FileName;
            var taggunApiKey = APIKey;
            var taggunApiUrl = TaggunApiUrl;

            byte[] fileData = System.IO.File.ReadAllBytes(fileName);

            var timeStart = DateTime.Now;

            using (var httpClient = new HttpClient { Timeout = new TimeSpan(0, 0, 0, 60, 0) })
            {
                HttpResponseMessage response = null;

                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("apikey", taggunApiKey);

                var parentContent = new MultipartFormDataContent("----WebKitFormBoundaryfzdR3Imh7urK8qw");

                var documentContent = new ByteArrayContent(fileData);
                documentContent.Headers.Remove("Content-Type");
                documentContent.Headers.Remove("Content-Disposition");
                documentContent.Headers.TryAddWithoutValidation("Content-Type", "image/jpeg");
                documentContent.Headers.TryAddWithoutValidation("Content-Disposition",
                string.Format(@"form-data; name=""file""; filename=""{0}""", "testfilename.jpg"));
                parentContent.Add(documentContent);

                var refreshContent = new StringContent("false");
                refreshContent.Headers.Remove("Content-Type");
                refreshContent.Headers.Remove("Content-Disposition");
                refreshContent.Headers.TryAddWithoutValidation("Content-Disposition", @"form-data; name=""refresh""");
                parentContent.Add(refreshContent);

                response = httpClient.PostAsync(taggunApiUrl, parentContent).Result;
                response.EnsureSuccessStatusCode();
                var result = response.Content.ReadAsStringAsync().Result;
                
                return result;
//Console.WriteLine(JObject.Parse(result).ToString());
                    
              
            }
        }

        public ReceiptSimpleRootObject ConvertToSimpleJson(string JsonAsString)
        {
            return JsonConvert.DeserializeObject<ReceiptSimpleRootObject>(JsonAsString);
        }

        public ReceiptVerboseRootObject ConvertToVerboseJson(string JsonAsString)
        {
            return JsonConvert.DeserializeObject<ReceiptVerboseRootObject>(JsonAsString);
        }
    }
}
