using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class Two2d2
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4];
           
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    arr[row,col]=Convert.ToInt32(Console.ReadLine());
                }
                
            }
            for (int row = 0; row < arr.GetLength(0); row++)  
            {
                for (int col = 0; col < arr.GetLength(1); col++) 
                {
                    Console.Write($"arr[{row},{col}] = {arr[row, col]}  ");
                }
                Console.WriteLine("\n");
            }

        }
    }
}
