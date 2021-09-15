using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RunApp.Models
{
    abstract public class Person
    {
        private string user;
        public string User { get { return user; } set { user = value; } }
    }
}
