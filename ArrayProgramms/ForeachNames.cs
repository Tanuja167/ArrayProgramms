using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class ForeachNames
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }

            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }

        }

    }
}

