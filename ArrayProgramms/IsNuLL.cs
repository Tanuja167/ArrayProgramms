using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class IsNuLL
    {
        static void Main(string[] args)
        {
            string str = " ";

            Console.WriteLine("IsNullOrEmpty: ");
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("String is empty:");
            }
            else
            {
                Console.WriteLine("Hello");
            }
        }
    }
}
