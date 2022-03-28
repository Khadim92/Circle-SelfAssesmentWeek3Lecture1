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
            Console.WriteLine("Radius = "+c.radius);
            Console.WriteLine("Color = " + c.color);
            circle c1 = new circle(c);
            Console.WriteLine("Radius = " + c1.radius);
            Console.WriteLine("Color = " + c1.color);
            c1.color = "Green";
            c1.radius = 50;
            Console.WriteLine("Radius = " + c1.radius);
            Console.WriteLine("Color = " + c1.color);
        }
    }
}
