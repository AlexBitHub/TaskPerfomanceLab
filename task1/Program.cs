using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            int m = int.Parse(args[1]);
            CircularArray circArr = new CircularArray(n);
            circArr.FindPath(m);
        }
    }
}
