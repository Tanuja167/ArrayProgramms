using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    internal class Struct
    {
        static void Main(string[] args)
        {
            Screen s=new Screen(10, 20);
            s.print();
        }
    }
    public struct Screen
    {
        private int x, y;

        public Screen(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void print()
        {
            Console.WriteLine(x+" "+y);
        }
        
    }
}
