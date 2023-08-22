using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class Minimum_Maximum
    {
       
        static void Main(string[] args)
        {
            int[] Arr = new int[5];
            int max=Arr[0];
           

            for(int i=0; i<Arr.Length; i++)
            {
                Console.WriteLine("enter elements");
                Arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            /*for(int i=0;i<Arr.Length; i++)
            {
                if(Arr[i] > max)
                {
                    max= Arr[i];
                }
            }
            Console.WriteLine($"Max element in array: {max}");*/
           
            int min = Arr[0];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] < min)
                {
                    min = Arr[i];
                }
            }
            Console.WriteLine($"Min element in arr: {min}");


        }
    }
}
