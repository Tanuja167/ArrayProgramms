using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class ArrayObj
    {
        static void Main(string[] args)
        {
            Object[] arrObj = new Object[3];
            arrObj[0] = 12;
            arrObj[1] = "Tanuja";
            

        }
    }
    public class EMP
    {
        int id;
        string name;
        public EMP(int id, string name)
        {
            this.id = id;
            this. name = name;
        }
        public void print()
        {
            Console.WriteLine(id+ " "+name);
        }

    }
}
