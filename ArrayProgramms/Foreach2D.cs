using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class Foreach2D
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4]
            {
                {1,2,3,4},
                {5,6,7,8},
                {9,0,1,2 }
            };
            foreach(int i in arr) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
