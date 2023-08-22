using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class Avg
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine(Average(a));
            int[] b = new int[3];
            Console.WriteLine(Average(b));
        }


        public static int Average(int[] a)
        {
            int sum = 0, count = 0, avg;

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"enter element at {i}");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
                count++;

            }
            Console.WriteLine("sum is: "+sum);
            avg = sum / count;
            Console.WriteLine("Average is: ");
            return avg;

        }
        public static double Average(double[] a)
        {
            int count = 0;
            double sum = 0, avg;

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"enter element at {i}");
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
                count++;
            }
            Console.WriteLine("sum is: "+sum);
            avg = sum / count;
            Console.WriteLine("avg is: "+avg);
            return avg;
        }

    }
}
