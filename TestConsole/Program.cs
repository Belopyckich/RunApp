using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\data")));
            int days = files.Length;
            List<Person> monthdata = new List<Person>();
            for (int i = 0; i < files.Length; i++)
            {
                var persons = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(files[i]));
                monthdata.AddRange(persons);
            }
            foreach (Person day in monthdata)
            {
                Console.WriteLine(day.GetData());
            }
            for(int i = 0; i < monthdata.Count; i++)
            {
                if()
            }
            Console.ReadKey();

        }
    }
}
