using System;
using System.Collections.Generic;
using System.Linq;
using RunApp.Models;
using System.IO;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Threading;

namespace RunApp.ViewModels
{
    [Serializable]
    internal class MainWindowViewModel : ViewModel
    {
        public ObservableCollection<MonthPersonStatistic> Users { get;}

        private MonthPersonStatistic selelectedGroup;
        public MonthPersonStatistic SelectedGroup { get => selelectedGroup; set => Set(ref selelectedGroup, value); }
        public MainWindowViewModel()
        {
            #region Беру данные из json файлов
            List<MonthPersonStatistic> data = new List<MonthPersonStatistic>();
            string[] files = Directory.GetFiles(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\Data\data")));
            List<DayPersonStatistic> jsonData = new List<DayPersonStatistic>();
            for (int i = 0; i < files.Length; i++)
            {
                var DayPersonStatistics = JsonConvert.DeserializeObject<List<DayPersonStatistic>>(File.ReadAllText(files[i]));
                foreach (DayPersonStatistic person in DayPersonStatistics)
                {
                    person.Day = i + 1;
                }
                jsonData.AddRange(DayPersonStatistics);
            }
            var enumerableData = jsonData.GroupBy(g => g.User).Select(i => new MonthPersonStatistic { User = i.Key });
            Users = new ObservableCollection<MonthPersonStatistic>();
            int counter = 0;
            foreach (var item in enumerableData)
            {
                Users.Add(new MonthPersonStatistic(item.User));
                counter++;
            }
            for (int j = 0; j < Users.Count(); j++)
            {
                for (int i = 0; i < jsonData.Count(); i++)
                {
                    if (Users[j].User == jsonData[i].User)
                    {
                        Users[j].DayInfo.Add(new Day(jsonData[i].Day, jsonData[i].Rank, jsonData[i].Steps, jsonData[i].Status));
                    }
                }
                Users[j].AvgSteps = (int)Math.Round((Users[j].DayInfo.Average(p => p.steps)));
                Users[j].MaxStep = Users[j].DayInfo.Max(p => p.steps);
                Users[j].MinStep = Users[j].DayInfo.Min(p => p.steps);
            }
            #endregion
        }

    }
}
