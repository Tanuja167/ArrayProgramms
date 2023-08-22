using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class ProductList
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
        }
        static void Main(string[] args)
        {
            Product[] list = new Product[2];
            
                list[0] = new Product { Id = 01, Name = "Tanuja", Price = 100 };
                list[1] = new Product { Id = 02, Name = "Alisha", Price = 200 };
            
            foreach (Product p in list)
            {
                Console.WriteLine(p.Id+" " +p.Name+" " +p.Price);
            }

        }
    }
    
}
