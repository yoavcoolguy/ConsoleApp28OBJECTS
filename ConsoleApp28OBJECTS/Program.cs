using ConsoleApp28OBJECTS;

namespace ConsoleApp28OBJECTS
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Point p = new Point(1, 1, "A");
    //        Point p2 = new Point(2, 2, "B");
    //        Sprite s1 = new Sprite(7, 7);
    //        //Console.WriteLine();

    //        //for (int i = 0; i < 40; i++)
    //        //{
    //        //    if (i != 20)
    //        //    {
    //        //        Console.SetCursorPosition(i, 20);
    //        //        Console.WriteLine("~");
    //        //    }
    //        //}

    //        //for (int j = 0; j < 40; j++)
    //        //{
    //        //    if (j != 20)
    //        //    {
    //        //        Console.SetCursorPosition(20, j);
    //        //        Console.WriteLine("|");
    //        //    }
    //        //}

    //        //for (int i = 0; i < 4; i++)
    //        //{
    //        //    int mikomY = p.randomY();
    //        //    int mikomX = p.randomX();
    //        //    Console.SetCursorPosition(mikomX, mikomY);
    //        //    Console.WriteLine($"R ({mikomX}, {mikomY})");
    //        //}
    //        //Console.ReadLine();


    //        //Console.WriteLine(p.Distance(p2));

    //        //Circle maagal = new Circle(69, p);
    //        s1.Draw();

    //    }

    //}
    public class Program
    {
        static int speed = 1000;
        static Sprite player = new Sprite(5, 5);
        static void Main(string[] args)
        {
            while (true)
            {
                while (!Console.KeyAvailable)
                {
                    player.Move();
                    Thread.Sleep(speed);
                }
                var key = Console.ReadKey(true).Key; //key press handling
                if (key == ConsoleKey.Escape)
                    break; //exit game
                else
                    HandleKey(key);
            }

        }
        private static void HandleKey(ConsoleKey key)
        {
            //if (key == ConsoleKey.N)
            //  GameReInit();
            //control game speed.
            if (key == ConsoleKey.Add)
                speed = speed * 8 / 10;
            else if (key == ConsoleKey.Subtract)
                speed = speed * 10 / 8;
            else
            {
                //foreach (var player in players)
                //  player.HandleKeys(key);
                player.HandleKeys(key);
            }
        }
    }

}
