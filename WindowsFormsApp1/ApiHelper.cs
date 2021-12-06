using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient{ get; set; }
        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            //ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue() { CharSet = "UTF-8", MediaType="",Quality=2});
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));
        }
    }
}
