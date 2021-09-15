using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunApp.Models
{
    class MonthPersonStatistic : Person
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

        public MonthPersonStatistic(string Name, int AvgSteps, int MaxStep, int MinStep)
        {
            User = Name;
            avgSteps = AvgSteps;
            maxStep = MaxStep;
            minStep = MinStep;

        }
        public MonthPersonStatistic(string name) : this()
        {
            User = name;
        }
        public override string ToString()
        {
            return $"user: {User}, avgSteps: {avgSteps}, maxStep: {maxStep}, minStep: {minStep}";
        }
    }
}
