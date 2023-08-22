using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    public class Book
    {
        public int Id { set; get; }
        public string Name { set; get; }
    }
    public class BOOkList
    {
        public static void Main(string[] args)
        {
            Book[] book = new Book[2];

            book[0] = new Book { Id = 101, Name = "ABCD" };
            book[1] = new Book { Id = 102, Name = "WXYZ" };
            
            foreach (Book b in book)
            {
                Console.WriteLine($"ID: {b.Id}, Name: {b.Name}");
            }
        }
    }
   
}
