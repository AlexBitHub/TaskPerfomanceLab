using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    static class Calculation
    {
        static double amountSteps = 0;
        public static void GetAmountSteps(List<int> nums)
        {
            var avgNums = Math.Round(nums.Average());
            foreach (var num in nums)
            {
                amountSteps = amountSteps + Math.Abs(avgNums - num);
            }
            Console.WriteLine(amountSteps);
        }
    }
}
