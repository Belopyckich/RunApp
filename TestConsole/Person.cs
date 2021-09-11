using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestConsole
{
    [Serializable]
    class Person
    {
        private int rank;
        private string user;
        private string status;
        private int steps;

        public int Rank { get { return rank; } set { rank = value; } }
        public string User { get { return user; } set { user = value; } }
        public string Status { get { return status; } set { status = value; } }
        public int Steps { get { return steps; } set { steps = value; } }

        public string GetData()
        {
            return $"Rank: {rank}, user: {user}, status: {status}, steps: {steps}";
        }
    }
}

