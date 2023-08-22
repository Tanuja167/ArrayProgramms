using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class Enum
    {
        static void Main(string[] args)
        {
            Sample1 s = new Sample1(11, "XYZ", 1200,Categories.HomeNeeds);
            Console.WriteLine(s);
        }
        public enum Categories
        {
            Clothes,
            Furniture,
            HomeNeeds
        }



        public class Sample1
        {
            int id;
            string name;
            double sal;
            Categories category;

            public Sample1(int id, string name, double sal, Categories category)
            {
                this.id = id;
                this.name = name;
                this.sal = sal;
                this.category = category;
            }
            public override string ToString()
            {
                return $"{id}, {name}, {sal}, {category}";
            }

        }
    }

}