using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Processor
{
    public static class ProfileProcessor
    {
        public static async Task<Models.PersonModel> GetGitHubProfile(string name)
        {
            string url = $"https://api.github.com/users/Mengkheang0";

            //string url = $"https://xkcd.com/1/info.0.json";
            //call up
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<Models.PersonModel>();
                    return result as Models.PersonModel;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }

    }
}
