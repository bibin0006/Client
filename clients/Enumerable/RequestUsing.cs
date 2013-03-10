using System;
using System.Net;
using System.IO;
using mvc4.Account;

namespace clients.Enumerable
{
    public class Request
    {
        
        public  string ipadd () {
            const string ip = "127.0.0.1";
            return ip;
        }

        public string Using(string method, string path)
        {
            string result;
            var request = (HttpWebRequest)WebRequest.Create(path);
            request.Method = method;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "Accept=text/html";
            if (method.Contains("P")) request.ContentLength = 0;
            try
            {
                var response = (HttpWebResponse)request.GetResponse();

                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }

        private static string GetRealPath(string path)
        {
            var realPath = "http://localhost:4001";
            try
            {
                realPath += new SecureEncrypt().Decrypt(path, "password");
                if (realPath.Contains("?"))
                    realPath += "&";
                else
                    realPath += "?";
                realPath += "Address=token";
            }
            catch
            {
                realPath = "";
            }

            return realPath;
        }
    }
}