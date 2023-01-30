using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28OBJECTS
{
   
    internal class Sprite: Point
    {
        public Sprite(int x, int y): base(x, y)
        {
        }
        private override void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("x");
            int nigga;
        }
    }
}
