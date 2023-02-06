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
        static int speed = 1000;
        static Sprite player = new Sprite(5, 5, ConsoleKey.RightArrow,
          ConsoleKey.LeftArrow, ConsoleKey.UpArrow, ConsoleKey.DownArrow);
        static Sprite player2 = new Sprite(9, 9, ConsoleKey.D,
          ConsoleKey.A, ConsoleKey.W, ConsoleKey.S);
        private ConsoleKey rightArrow;
        private ConsoleKey leftArrow;
        private ConsoleKey upArrow;
        private ConsoleKey downArrow;
        private object consoleke;

        public Sprite(int x, int y): base(x, y)
        {

        }

        public Sprite(int x, int y, ConsoleKey rightArrow, ConsoleKey leftArrow, ConsoleKey upArrow, ConsoleKey downArrow) : this(x, y)
        {
            this.rightArrow = rightArrow;
            this.leftArrow = leftArrow;
            this.upArrow = upArrow;
            this.downArrow = downArrow;
        }
        public Sprite(int x, int y) : base(x, y)
        {// כמו הבנאי של המחלקה האם
         // השרשור :base(x,y)
         // שולח את הפרמטרים שהתקבלו לבנאי של המחלקה האם
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
