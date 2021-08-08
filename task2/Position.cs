using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Position
    {
        public (double, double) centerCircleXY;
        public double radiusCircle;

        public void FindPosition(string pointXY)
        {
            string[] stringXY = pointXY.Split(' ');
            double xPoint = double.Parse(stringXY[0]);
            double yPoint = double.Parse(stringXY[1]);

            double distanceBtwPoints = Math.Sqrt(Math.Pow((centerCircleXY.Item1 - xPoint), 2) + Math.Pow((centerCircleXY.Item2 - yPoint), 2));
            if (distanceBtwPoints == radiusCircle)
                Console.WriteLine(0);
            else if (distanceBtwPoints < radiusCircle)
                Console.WriteLine(1);
            else
                Console.WriteLine(2);
        }
    }
}
