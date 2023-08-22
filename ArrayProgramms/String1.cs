using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class String1
    {
        static void Main(string[] args)
        {
            string msg = "Hello All";
            string str = " Good Morning ";

            Console.WriteLine(msg);
            Console.WriteLine(str);
            Console.WriteLine(msg.GetHashCode());

            string str1 = string.Concat(msg, str);
            Console.WriteLine("String after Concatination: "+str1);

            string str2 = (str1.TrimStart());
            Console.WriteLine("After Trim Operation: "+str2);

            string str3 = str2.ToUpper();
            Console.WriteLine("after toupper: "+str3);

            string str4 = str3.ToLower();
            Console.WriteLine("After tolower: "+str4);

            
            Console.WriteLine("Index Of o :"+str4.IndexOf('o'));

            Console.WriteLine("Last Occurance a: "+str4.LastIndexOf('o'));

            Console.WriteLine("Length of string 1: "+str.Length);

            string[] arr = str3.Split(' ');
            Console.WriteLine("After split : "+arr[2]);
        }
    }
}
