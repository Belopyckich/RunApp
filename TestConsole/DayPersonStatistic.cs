using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestConsole
{
    [Serializable]
    internal class DayPersonStatistic : Person
    {
        private int steps;

        public int Steps { get { return steps; } set { steps = value; } }

        public string GetData()
        {
            return $"Rank: {Rank}, user: {User}, status: {Status}, steps: {Steps}";
        }
    }
}

