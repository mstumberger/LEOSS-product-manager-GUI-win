using System;
using System.IO;
using System.Net;
using System.Text;

namespace ListProducts
{
    public enum MethodType {
        GET,
        POST,
        PUT,
        DELETE
    }
    class RESTClient {
        public string Url { get; set; }
        public MethodType Method { get; set; }
        public string Payload { get; set; }

        public RESTClient(string url, MethodType requestType) {
            this.Url = url;
            this.Method = requestType;
        }

        public RESTClient(string url, MethodType requestType, string payload) {
            Console.WriteLine(url);
            this.Url = url;
            this.Method = requestType;
            this.Payload = payload;
        }

        public string MakeRequest() {

            string StrResponseValue = string.Empty;
            HttpWebRequest Request = (HttpWebRequest) WebRequest.Create(Url);
            Stream DataStream;
            WebResponse Response = null;
            Request.Method = Method.ToString();

            try {
                if (Method == MethodType.POST || Method == MethodType.PUT) {
                    byte[] byteArray = Encoding.UTF8.GetBytes(Payload);
                    string ContentType = "application/json";
                    Request.ContentType = ContentType;
                    Request.MediaType = ContentType;
                    Request.Accept = ContentType;
                    Request.ContentLength = byteArray.Length;
                    DataStream = Request.GetRequestStream();
                    DataStream.Write(byteArray, 0, byteArray.Length);
                    DataStream.Close();
                }
            } catch (Exception ex) {
                StrResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"]}";
            }

            try {
                Response = Request.GetResponse();
                //Console.WriteLine(((HttpWebResponse)Response).StatusDescription);
                DataStream = Response.GetResponseStream();
                StreamReader reader = new StreamReader(DataStream);
                StrResponseValue = reader.ReadToEnd();
                //Console.WriteLine(StrResponseValue);
                reader.Close();
                DataStream.Close();
                Response.Close();
            }
            catch (Exception ex) {
                StrResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"]}";
            }
            finally { if (Response != null) { ((IDisposable)Response).Dispose(); } }

            return StrResponseValue;
        }
    }
}
