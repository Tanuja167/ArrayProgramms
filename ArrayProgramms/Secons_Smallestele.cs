using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    /* 8.	WAP to find the second smallest element in an array.*/

    internal class Secons_Smallestele
    {
        static void Main(string[] args)
        {
            
            int[] a = new int[5];

            for(int i=0;i<a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = a[0];
            int snd_smallest = a[0];


            for (int i=1;i<a.Length;i++)
            {
                if (a[i]<min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine(min);

            for(int i=0; i<a.Length;i++)
            {
                if (a[i]<snd_smallest && a[i]>min)
                {
                    snd_smallest = a[i];
                }
            }
            Console.WriteLine("second smallest ele: "+snd_smallest);
        }
    }
}
