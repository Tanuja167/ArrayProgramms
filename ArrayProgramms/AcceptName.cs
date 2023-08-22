using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    /*WAP to accept 5 names using 1D array and display using for loop*/
    internal class AcceptName
    {
        static void Main(string[] args)
        {
            string[] s = new string[5];
            Console.WriteLine("enter names:");

            for (int i=0;i<s.Length; i++)
            {
                s[i] = Console.ReadLine();
            }
            for(int i=0;i<s.Length ; i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.WriteLine("\n");
        }

    }
}
