using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace accountsReceivableRESTClient.Helpers
{
    public class JsonHelper
    {
        public static string JsonSerializer<T>(T t)
        {
            try
            {
                String jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(t);
                return jsonString;
            }
            catch
            {
                return string.Empty;
            }
        }
        public static T JsonDeserialize<T>(string jsonString)
        {
            try
            {
                var value = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonString);
                return value;
            }
            catch
            {
                return default(T);
            }
        }

        public enum HTTPMethod { POST, GET };

        public static T ExecuteREST<T>(String jsonURI, T t, List<Model.NameValue> webRequestHeaders, System.Net.Http.HttpMethod method)
        {
            string jsonPayLoad = "";
            T value = default(T);
            if (t != null)
            {
                jsonPayLoad = JsonSerializer(t);
            }
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(jsonURI);
            request.Method = method.Method;
            request.ContentType = "application/json";
            request.ContentLength = jsonPayLoad.Length;

            if (webRequestHeaders != null)
            {
                foreach (Model.NameValue item in webRequestHeaders)
                {
                    request.Headers.Add(item.Name, item.Value);
                }
            }

            if(request.ContentLength > 0)
            {
                using (Stream webStream = request.GetRequestStream())
                using (StreamWriter requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
                {
                    requestWriter.Write(jsonPayLoad);
                }

            }

            String jsonContent = "";
            try
            {
                WebResponse webResponse = request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            jsonContent = responseReader.ReadToEnd();
                            value = JsonDeserialize<T>(jsonContent);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Deserialization Error: " + jsonContent);
            }
            return value;

        }
    }
}
