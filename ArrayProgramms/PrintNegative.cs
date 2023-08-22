using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class PrintNegative
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] arr = new int[10];
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine($"Enter values at {i}");
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]<0)
                {
                    count++;
                   
                    Console.WriteLine(arr[i]);
                    
                }
            }
            Console.WriteLine("Total negative elements: "+count);

        }
    }
}
