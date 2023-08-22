using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    /*13.	Write a  program to test the equality of two arrays. Means e.g arr1[] = [12, 22, 32, 42, 52, 62] and 
     * arr2[] = [52, 22, 62, 12, 42, 22] Here both arrays are equal.*/
    internal class Equality13
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 12, 22, 32, 42, 52, 62 };
            int[] arr2 = new int[] { 52, 22, 62, 12, 42, 22 };
            bool flag = false;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1.Length == arr2.Length)
                    {
                        flag = true;
                    }
                }
            }
                if(flag == true)
                {
                    Console.WriteLine("Here both arrays are equal");
                }
            else
            {
                Console.WriteLine("not equal:");
            }
            
        }
    }
}
