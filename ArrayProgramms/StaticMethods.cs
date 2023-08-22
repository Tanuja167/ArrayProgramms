﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    /* 2.	Write two methods that return the average of an array with following headers.
             i.	public static int average(int[] array)
             ii.	public static double average(double[] array).
            iii.	Write main and invoke the 2 methods.*/

    internal class StaticMethods
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[2];
            Console.WriteLine("Enter elements");
            Console.WriteLine(method.average(arr1));
            Console.WriteLine(" ");
            Console.WriteLine("Enter elements: ");
            double[] arr2 = new double[2];
            Console.WriteLine(method.average(arr2));
        }
    }
    public class method
    {
        
        public static int average(int[] array)
        {
            int sum = 0, cnt = 0, avg = 0;
            for (int i=0; i<array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<array.Length; i++)
            {
              sum = sum + array[i];
                cnt++;
            }
            avg = sum/cnt;
            return avg;
        }
        public static double average(double[] array)
        {
            double sum = 0, cnt = 0, avg = 0;
            for(int i=0;i<=array.Length-1;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length-1; i++)
            {
                sum = sum + array[i];
                cnt++;
            }
            avg = sum/cnt;
            return avg;

        }

    }

}
