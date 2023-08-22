using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class Asending
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 10, 1, 20, 70, 23 };
            int temp = 0;
           // Array.Sort(arr);

            for(int i=0;i<arr.Length;i++)
            {
               for(int j=i+1;j<arr.Length;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                  
            }
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }



        }
    }
}
