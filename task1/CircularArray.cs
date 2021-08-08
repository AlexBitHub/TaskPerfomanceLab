using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class CircularArray
    {
        private int _sizeArray;
        public CircularArray(int sizeArray)
        {
            _sizeArray = sizeArray;
        }

        public void FindPath(int lengthPath)
        {
            int firstNumber = 1;
            do
            {
                Console.Write(firstNumber);
                firstNumber = firstNumber + (lengthPath - 1);
                while (firstNumber > _sizeArray)  // в случае, если размер массива много меньше длины обхода
                    firstNumber = firstNumber - _sizeArray;
            } while (firstNumber != 1);
            Console.WriteLine();
        }
    }
}
