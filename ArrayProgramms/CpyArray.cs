using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class CpyArray
    {
        static void Main(string[] args)
        {
            int[] arr=new int[5];
            int[] arr2=new int[arr.Length];

            Console.WriteLine("Enter array elements: ");

            for (int i=0;i<arr.Length; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0;i<arr.Length;i++) 
            {
                arr2[i] = arr[i];
            }
            foreach(int i in arr)
            {
                Console.WriteLine(arr[i]);
            }
            foreach (int i in arr2)
            {
                
                Console.WriteLine(arr2[i]);
            }
        }
    }
}
