using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    /*12.	WAP to reverse the array itself, don’t print array in reverse – I want current array reverse. Means e.g. 
     * arr[] = [3, 90, 45, 29, 37, 78] so your same array must be [78, 37, 29, 45, 90, 3] without using temporary array.*/
    internal class reverse_array
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];  //{2,43,12,134,78}
            int[] b=new int[a.Length];
            for(int i=0; i<a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i=a.Length-1; i>=0; i--)
            {
                b[i] = a[i];
                Console.WriteLine(b[i]);
            }
            
        }
    }
    
}
