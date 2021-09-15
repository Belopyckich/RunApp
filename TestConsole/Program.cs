using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\data")));
            int days = files.Length;
            List<DayPersonStatistic> jsonData = new List<DayPersonStatistic>();
            for (int i = 0; i < files.Length; i++)
            {
                var DayPersonStatistics = JsonConvert.DeserializeObject<List<DayPersonStatistic>>(File.ReadAllText(files[i]));
                foreach(DayPersonStatistic person in DayPersonStatistics)
                {
                    person.Day = i + 1;
                }
                jsonData.AddRange(DayPersonStatistics);
            }
            var enumerableData = jsonData.GroupBy(g => g.User).Select(i => new MonthPersonStatistic{ User = i.Key });
            List<MonthPersonStatistic> finalData = new List<MonthPersonStatistic>();
            int counter = 0;
            foreach(var item in enumerableData)
            {
                finalData.Add(new MonthPersonStatistic(item.User));
                counter++;
            }

            for (int j = 0; j < finalData.Count(); j++)
            {
                for (int i = 0; i < jsonData.Count(); i++)
                {
                    if (finalData[j].User == jsonData[i].User)
                    {
                        finalData[j].DayInfo.Add(new Day(jsonData[i].Day, jsonData[i].Rank, jsonData[i].Steps, jsonData[i].Status));
                    }
                }
                finalData[j].AvgSteps = (int)(Math.Round(finalData[j].DayInfo.Average(p => p.steps)));
                finalData[j].MaxStep = finalData[j].DayInfo.Max(p => p.steps);
                finalData[j].MinStep = finalData[j].DayInfo.Min(p => p.steps);
            }

            foreach (var person in finalData)
            {
                if(person.User == "Тринуликов Сергей")
                {
                    Console.WriteLine(person.GetData());
                    for (int i = 0; i < person.DayInfo.Count(); i++)
                    {
                        Console.WriteLine(person.DayInfo[i].GetDayData());
                    }
                }
            }
        }
    }
}
