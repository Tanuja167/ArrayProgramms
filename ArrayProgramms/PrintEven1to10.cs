using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class PrintEven1to10
    {
        static void Main(string[] args)
        {
            int[] num= new int[10];
            for(int i=0;i<num.Length; i++)
            {
                Console.WriteLine($"Enter value at {i}");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i< num.Length;i++)
            {
                if (num[i]%2==0)
                {
                    Console.WriteLine(num[i]);
                }
            }
        }
    }
}
