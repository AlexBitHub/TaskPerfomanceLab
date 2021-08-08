using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace task3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string pathTests = args[0];
            string pathValues = args[1];
            
            Values dataValues; Tests dataTests;

            using (FileStream valStream = new FileStream(pathValues, FileMode.Open))
            using (FileStream testStream = new FileStream(pathTests, FileMode.Open))
            {
                dataValues = await JsonSerializer.DeserializeAsync<Values>(valStream);
                dataTests = await JsonSerializer.DeserializeAsync<Tests>(testStream);
            }

            FindTheSameId(dataTests.tests, dataValues.values);

            using (FileStream fsReport = new FileStream("report.json", FileMode.OpenOrCreate))
            {
                var options = new JsonSerializerOptions() { IgnoreNullValues = true, WriteIndented = true };
                await JsonSerializer.SerializeAsync<Tests>(fsReport, dataTests, options);
            }
        }

        public static void FindTheSameId(List<Test> tests, List<Value> values)
        {
            foreach (var test in tests)
            {
                test.value = values.Where(v => v.id == test.id).Select(v => v.value).FirstOrDefault();
                if (test.values != null)
                    FindTheSameId(test.values, values);
            }
        }
    }
}
