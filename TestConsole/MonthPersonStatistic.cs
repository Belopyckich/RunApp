using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class MonthPersonStatistic : DayPersonStatistic
    {
        private int avgSteps;
        private int bestStep;
        private int worstStep;
        private int[] allSteps;

        public int AvgSteps { get { return avgSteps; } set { avgSteps = value; } }
        public int BestScore { get { return bestStep; } set { bestStep = value; } }
        public int WorstStep { get { return worstStep; } set { worstStep = value; } }
        public int[] AllSteps { get { return allSteps; } set { allSteps = value; } }


    }
}
