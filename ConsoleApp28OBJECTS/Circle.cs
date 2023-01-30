using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28OBJECTS
{
    internal class Circle
    {
        private double r;
        private Point center;
        public Circle(double radius, Point centeroo)
        {
            r = radius;
            center = centeroo;
        }
        public bool IsInside(Point p)
        {
            if (p.Distance(center) < r)
            {
                return true;
            }
            else
                return false;
        }
        public bool IsOutside(Point p)
        {
            if (p.Distance(center) > r)
            {
                return true;
            }
            else
                return false;
        }
        public bool IsOn(Point p)
        {
            if (p.Distance(center) == r)
            {
                return true;
            }
            else
                return false;
        }
        public double KetaMerkazim(Circle other)
        {
            return center.Distance(other.center);
        }
        public bool IsIntersecting(Circle other)
        {
            if (center.Distance(other.center) <= r + other.r)
            {
                return true;
            }
            return false;
        }
    }

}