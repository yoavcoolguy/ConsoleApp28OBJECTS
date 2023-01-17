using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28OBJECTS
{
    public class point
    {
        private int x; private int y; private string name;
        public point(int xCoor, int yCoor, string nammme)
        {
            x = xCoor;
            y = yCoor;
            name = nammme;
        }
        public int Getx() // getter
        {
            return x;
        }

        public int Gety()
        {
            return y;
        }
        public string GetName()
        {
            return name;
        }
        public void SetX(int value)
        {
            if (x <= 100)
            {
                x = value;
            }
        }

        public override string ToString()
        {
            return $"{name}({x},{y})";
        }

        public int Nigga()
        {
         if (x > 0 && y > 0)
                return 1;

            else if (x < 0 && y > 0)
                return 2;

            else if(x < 0 && y < 0)
                return 3;

            else if (x > 0 && y < 0)
                return 4;

            else return -1;
        }
    }
}