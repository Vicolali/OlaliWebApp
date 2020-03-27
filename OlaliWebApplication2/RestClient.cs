using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace OlaliWebApplication2
{

    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE

    }

    public class RestClient
    {
        public string endpoint{get; set;}
        public httpVerb httpMethod { get; set; }

        public RestClient()
        {
            endpoint = string.Empty;
            httpMethod = httpVerb.GET;
        }

        public string makeRequest()
        {
            string myResponseString = string.Empty;

            //HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("http://www.contoso.com/"); // cast using WebRequest oblect
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(endpoint);
            myRequest.Method = httpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)myRequest.GetResponse())
            {
                // if http error occurs
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("ow... darn! " + response.StatusCode.ToString());
                }

                // if all is well, process http.
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            myResponseString = reader.ReadToEnd();
                        }
                    }
                }
            }

            return myResponseString;
        }
    }
}