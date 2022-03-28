using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class circle
    {
        public circle()
        {
            radius = 1.0f;
            color="red";
        }
        public circle(int r)
        {
            radius = r;
        }
        public circle(string c, int r)
        {
            color = c;
            radius = r;
        }
        public circle(circle c)
        {
            color = c.color;
            radius = c.radius;
        }
        public float radius;
        public string color;
    }
}
