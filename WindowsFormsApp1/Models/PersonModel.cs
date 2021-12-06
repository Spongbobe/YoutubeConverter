using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class PersonModel
    {
        public string Avatar_url { get; set; }
        public string Url { get; set; }
        public string Bio { get; set; }
        public int Public_repos { get; set; }
    }
    public class Comic
    {
        public string Year { get; set; }
        public string Img { get; set; }
    }

}
