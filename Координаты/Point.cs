using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Координаты
{
    class Point
    {
        public int x, y; 
        public Point() { x = 0; y = 0; }
        public Point(int x, int y) { this.x = x; this.y = y; }
        public override string ToString() => "x=" + x + " y=" + y;
        public double Distance() => Math.Sqrt(x * x + y * y);
        public void Move(int a, int b) 
        {
            x += a;
            y += b;
        }
        public int X
        {
            get 
            { 
                return x; 
            }
            set 
            { 
                x = value; 
            }
        }
        public int Y
        {
            get 
            { 
                return y; 
            }
            set 
            { 
                y = value; 
            }
        }
        public int Scalar
        {
            set
            {
                x = x * value;
                y = y * value;
            }
        }
    }
}
