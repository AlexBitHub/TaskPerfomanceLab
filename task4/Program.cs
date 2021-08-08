using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = args[0];
            List<int> nums = new List<int>();
            using (StreamReader sread = new StreamReader(path))
            {
                while (!sread.EndOfStream)
                {
                    int num = int.Parse(sread.ReadLine());
                    nums.Add(num);
                }
            }
            Calculation.GetAmountSteps(nums);
        }
    }
}
