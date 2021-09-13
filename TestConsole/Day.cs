using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Day
    {
        public int key;
        public int rank;
        public int steps;
        public string status;

        public int Key { get { return key; } set { key = value; } }
        public int Rank { get { return rank; } set { rank = value; } }
        public int Steps { get { return steps; } set { steps = value; } }
        public string Status { get { return status; } set { status = value; } }
        public Day()
        {
            key = default(int);
            rank = default(int);
            steps = default(int);
            status = default(string);
        }
        public Day(int Key, int Rank, int Steps, string Status)
        {
            this.key = Key;
            this.rank = Rank;
            this.steps = Steps;
            this.status = Status;
        }



        public virtual string GetDayData()
        {
            return $"key: {key}, rank: {rank}, steps: {steps}, status: {status}";
        }
    }
}
