using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class Foreach
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] =Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in arr) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
