using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class TwoD
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3,4]
            {
                {10, 20, 30,40},
                {50,60,70, 80},
                {90, 100, 200, 300}
            };
            for(int row=0; row<arr.GetLength(0);row++)
            {
                for(int col=0; col < arr.GetLength(1);col++)
                {
                    Console.WriteLine($"arr[{ row},{col}] = {arr[row, col]}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
