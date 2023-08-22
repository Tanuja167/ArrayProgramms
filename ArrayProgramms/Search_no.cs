using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class Search_no
    {
        /*WAP to search for a given number in an array and accordingly print the index if exists*/
        static void Main(string[] args)
        {
            int[] a = new int[5];
           
                                
            for (int i=0; i<a.Length; i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("enter number to search");
            int num = Convert.ToInt32(Console.ReadLine());
            
            for (int i=0; i<a.Length;i++)
            {
                if (num == a[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
           
        }
    }
}
