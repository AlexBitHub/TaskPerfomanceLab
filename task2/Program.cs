using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToCircle = args[0];
            string pathToPoints = args[1];
            Position positionPoints = new Position();

            string[] circleData = File.ReadAllLines(pathToCircle);
            string[] centerXY = circleData[0].Split(' ');

            positionPoints.centerCircleXY = (Double.Parse(centerXY[0]), Double.Parse(centerXY[1]));
            positionPoints.radiusCircle = Double.Parse(circleData[1]);

            using (StreamReader fstream = new StreamReader(pathToPoints))
            {
                while (!fstream.EndOfStream)
                {
                    positionPoints.FindPosition(fstream.ReadLine());
                }
            }

        }
    }
}
