using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestConsole
{
    [Serializable]
    internal class MonthPersonStatistic : Person
    {
        private int avgSteps;
        private int maxStep;
        private int minStep;
        public List<Day> dayInfo;

        public int AvgSteps { get { return avgSteps; } set { avgSteps = value; } }
        public int MaxStep { get { return maxStep; } set { maxStep = value; } }
        public int MinStep { get { return minStep; } set { minStep = value; } }
        public List<Day> DayInfo { get { return dayInfo; } set { dayInfo = value; } }
        public MonthPersonStatistic()
        {
            DayInfo = new List<Day>();
            avgSteps = default(int);
            maxStep = default(int);
            minStep = default(int);
        }
        public MonthPersonStatistic(string name) : this()
        {
            User = name;
        }
        public virtual string GetData()
        {
            return $"user: {User}, avgSteps: {avgSteps}, maxStep: {maxStep}, minStep: {minStep}";
        }




    }
}

