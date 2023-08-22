using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class TostriProduct
    {
        static void Main(string[] args)
        {
            Product p = new Product(01, "Tanu", 100);
            Console.WriteLine(p.ToString());
        }
    }
    public class Product
    {
        int id;
        string name;
        int price;

        public Product(int id, string name, int price)
        {
            this.id = id;   
            this.name = name;
            this.price = price;
        }
        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Price: {price}";
        }
    }

}
