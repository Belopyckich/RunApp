using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RunApp.Models
{
    public class DayPersonStatistic : Person, ICloneable
    {
        private int rank;
        private string status;
        private int steps;
        [JsonIgnore]
        private int day;

        public int Rank { get { return rank; } set { rank = value; } }
        public string Status { get { return status; } set { status = value; } }
        public int Steps { get { return steps; } set { steps = value; } }
        public int Day { get { return day; } set { day = value; } }

        public virtual object Clone()
        {
            return new DayPersonStatistic
            {
                Rank = this.Rank,
                User = this.User,
                Status = this.Status,
                Steps = this.Steps,
                Day = this.Day
            };
        }

        public virtual string GetData()
        {
            return $"Rank: {Rank}, user: {User}, status: {Status}, steps: {Steps}, day: {Day}";
        }
    }
}
