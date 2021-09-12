using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    abstract class Person
    {
        private int rank;
        private string user;
        private string status;

        public int Rank { get { return rank; } set { rank = value; } }
        public string User { get { return user; } set { user = value; } }
        public string Status { get { return status; } set { status = value; } }
    }
}
