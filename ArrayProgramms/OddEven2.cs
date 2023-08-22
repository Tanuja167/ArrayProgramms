using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class OddEven2
    {
        public static void Main(string[] args)
        {
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] array3 = new int[5];
            

            for(int i=0;i<array1.Length; i++)
            {
                Console.WriteLine("Enter Number");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0;i<array1.Length;i++)
            {
                if (array1[i]%2==0)
                {
                    array2[i] = array1[i];
                    
                }
                else
                {
                    array3[i] = array1[i];
                   
                }
                
            }

            for(int i=0;i<array2.Length;i++)
            {
                if (array2[i] != 0)
                {
                    Console.WriteLine(array2[i]);
                }
            }
            Console.WriteLine(".......................................................");
            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i] != 0)
                {
                    Console.WriteLine(array3[i]);
                }
            }
        }
    }
}










