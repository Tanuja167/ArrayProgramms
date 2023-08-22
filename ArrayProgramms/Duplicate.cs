using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class Duplicate
    {
        /*6.	WAP to find and count total number of duplicate elements in an array.*/
        static void Main(string[] args)
        {

            int[] arr = new int[] { 3,1,3,3,1};
            int count = 1;
            bool isvisited = false;

            for (int i=0;i<arr.Length; i++)
               
           
            {
                for(int k = i-1; k>=0;k--)
                {
                    if (arr[k] == arr[i])
                    {
                        isvisited = true;
                        break;
                        
                    }
                }
                if(isvisited == false)
                {
                    for(int j=i+1;j<arr.Length;j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                   


                    if (count>1)                       //if(count==1)
                    {
                        Console.WriteLine(count+" times "+arr[i]);
                    }
                    
                }
            }
            
        }
    }
}
