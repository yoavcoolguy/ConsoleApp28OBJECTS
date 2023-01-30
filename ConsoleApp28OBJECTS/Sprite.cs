using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28OBJECTS
{
   
    public class Sprite: Point
    {
        private int dx = 0; private int dy = 0;
        public Sprite(int x, int y): base(x, y)
        {

        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("bruh");
        }

        internal void HandleKeys(ConsoleKey key)
        {
            if (key == ConsoleKey.RightArrow)
                dx++;
            else if (key == ConsoleKey.LeftArrow)
                dy--;
            else if (key == ConsoleKey.DownArrow)
                dy++;
            else if (key == ConsoleKey.UpArrow)
                dy--;
        }

        internal void Move()
        {
            Erase();
            x += dx;
            y += dy;
            Draw();
        }
        public void Erase()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Draw();
            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}
