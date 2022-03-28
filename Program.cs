using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = 2;
            circle c = new circle("Blue",2);
            Console.WriteLine(c.radius);
            Console.WriteLine(c.color);
            circle c1 = new circle(c);
            c1.color = "Green";
            Console.WriteLine(c1.radius);
            Console.WriteLine(c1.color);
        }
    }
}
