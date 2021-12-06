using System;
using System.Timers;
using System.Threading.Tasks;
using System.Net.Http;

namespace random_api
{
    class Program
    {

        static void Main(string[] args)
        {
            string fileOutput = @"D:\index.html";

            CreateFile(fileOutput, GetScript().Result);

        }
        public static async Task<string> GetScript()
        {
            using(var Client = new HttpClient())
            {
                var endPoint = new Uri("https://thatcopy.pw/catapi/");
                Client.DefaultRequestHeaders.Accept.Clear();
                var result = Client.GetAsync(endPoint).Result.Content.ReadAsStringAsync().Result;

                return result;
            }

        }
     
        public static void CreateFile(string file,string content)
        {
            System.IO.File.WriteAllText(file,content);
            System.Diagnostics.Process.Start(@"cmd.exe", @"/c" + file);

        }

    }
}
