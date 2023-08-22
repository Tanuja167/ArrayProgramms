using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class ListEmployee
    {
        public class Employee
        {
            public int id { set; get; }
            public string name { set; get; }
            public int salary { set; get; }
        }
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[3];


               emp[0] = new Employee { id = 1, name = "ABC", salary = 2000 };
               emp[1] = new Employee { id = 2, name = "XYZ", salary = 4000 };
               emp[2] = new Employee { id = 3, name = "DEF", salary = 6000 };

            
            foreach(Employee e in emp)
            {
                Console.WriteLine($"ID: {e.id}, Name: {e.name}, Salary: {e.salary}");
            }

        }
    }
   
}
