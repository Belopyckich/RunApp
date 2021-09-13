using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    abstract public class Person
    {
        private string user;
        public string User { get { return user; } set { user = value; } }
    }
}
