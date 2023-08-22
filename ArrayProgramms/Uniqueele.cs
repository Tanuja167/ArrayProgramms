using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    /*	7.	WAP to print all unique elements in the array..*/

    internal class Uniqueele
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 2, 3, 3, 1 };
            int count = 1;
            bool isvisited = false;

            for (int i = 0; i < arr.Length; i++)


            {
                for (int k = i - 1; k >= 0; k--)
                {
                    if (arr[k] == arr[i])
                    {
                        isvisited = true;
                        break;

                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }



                    if (count == 1)                       //if(count==1)
                    {
                        Console.WriteLine(arr[i]);
                    }

                }
            }

        }

    }
}
