using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class Practise
    {
        static void Main(string[] args)
        {
            /*int[] arr = new int[5];

            Console.WriteLine("Enter array ele: ");


            for (int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = arr[0];

            for (int i=0;i<arr.Length;i++)
            {
                if (arr[i]<min)
                {
                    min = arr[i];
                    
                }
               
            }
            Console.WriteLine($"Minimum element in array: { min}");*/
            /*Console.WriteLine("Enter Array ele: ");
            int[] arr = new int[5];

            for(int i=0;i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Maximum Elements : {max}");*/

            /*int[,] arr = new int[3,4];
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for (int j = 0; j < arr.GetLength(1);j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(  );
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}] = {arr[i,j]}");
                }
                Console.Write("\n");
            }
            Console.ReadLine();*/

            string[] arr = new string[5];
            Console.WriteLine("ENter array names");
            for (int i=0; i<arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
