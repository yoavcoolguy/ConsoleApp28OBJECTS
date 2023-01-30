using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28OBJECTS
{
    public class Point
    {
        protected int x; protected int y; private string name; private static char currentLetter = 'A'; private double r; private Point center; private ConsoleColor color = ConsoleColor.Black;

        public Point(int xCoor, int yCoor, string name)
        {
            x = xCoor;
            y = yCoor;
            this.name = name;
        }
        public Point(int xCoor, int yCoor)
        {
            x = xCoor;
            y = yCoor;
            this.name += "" + currentLetter++;
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

        public int ravia()
        {
            if (x > 20 && y > 20)
                return 1;

            else if (x < 20 && y > 20)
                return 2;

            else if (x < 20 && y < 20)
                return 3;

            else if (x > 20 && y < 20)
                return 4;

            else return -1;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(name);
        }

        public double Distance(Point other)
        {
            return Math.Sqrt(Math.Pow(x - other.x, 2) + Math.Pow(y - other.y, 2));
        }

        public int randomX()
        {
            Random rd = new Random();
            int rand_num = rd.Next(0, 40);
            if (rand_num == 20)
            {
                while (rand_num == 20)
                {
                    rand_num = rd.Next(0, 40);
                    if (rand_num != 20)
                        break;
                }
                return rand_num;
            }
            else
                return rand_num;
        }

        public int randomY()
        {
            Random rd = new Random();
            int rand_num = rd.Next(0, 40);
            if (rand_num == 20)
            {
                while (rand_num == 20)
                {
                    rand_num = rd.Next(0, 40);
                    if (rand_num != 20)
                        break;
                }
                return rand_num;
            }
            else
                return rand_num;
        }

    }
}