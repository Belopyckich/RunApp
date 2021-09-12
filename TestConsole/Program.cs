using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\data")));
            int days = files.Length;
            List<DayPersonStatistic> data = new List<DayPersonStatistic>();
            for (int i = 0; i < files.Length; i++)
            {
                var DayPersonStatistics = JsonConvert.DeserializeObject<List<DayPersonStatistic>>(File.ReadAllText(files[i]));
                data.AddRange(DayPersonStatistics);
            }
            var sortedData = data.OrderBy(u => u.Rank);
            foreach (DayPersonStatistic day in sortedData)
            {
                Console.WriteLine(day.GetData());
            }

            Console.ReadKey();

        }
    }
}
