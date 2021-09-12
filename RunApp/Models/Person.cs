using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RunApp.Models
{
    class Person
    {
        private int rank;
        private string user;
        private string status;
        private int steps;

        public int Rank { get; set; }
        public string User { get; set; }
        public string Status { get; set; }
        public string Steps { get; set; }

        static void GetData(string path)
        {
            var persons = JsonConvert.DeserializeObject<List<Person>>(path);
            foreach (var item in persons)
            {
                
            }
        }
    }
}
