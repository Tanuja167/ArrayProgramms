using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    public class _1standlastSum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sum = 0;
            int cnt = 0;

            while(num!=0)
            {
                int rem = num % 10;
                cnt++;
                num = num / 10;
                
            }

            while(temp!=0)
            {
                int rem1=temp % 10;
                for(int i=0;i<=cnt; i++)
                {
                    if(i==0 || i==cnt)
                    {
                        sum = sum + rem1;

                    }
                }
                temp= temp % 10;
            }
            Console.WriteLine(sum);
        }
    }
}
