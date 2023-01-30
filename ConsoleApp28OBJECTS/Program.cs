namespace ConsoleApp28OBJECTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1, 1, "A");
            Point p2 = new Point(2, 2, "B");
            Console.WriteLine();

            for (int i = 0; i < 40; i++)
            {
                if (i != 20)
                {
                    Console.SetCursorPosition(i, 20);
                    Console.WriteLine("~");
                }
            }

            for (int j = 0; j < 40; j++)
            {
                if (j != 20)
                {
                    Console.SetCursorPosition(20, j);
                    Console.WriteLine("|");
                }
            }

            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(p.randomX(), p.randomY());
                int mikomY = p.randomY();
                int mikomX = p.randomX();
                Console.WriteLine($"R ({mikomX}, {mikomY})");
            }
            Console.ReadLine();


            Console.WriteLine(p.Distance(p2));

            Circle maagal = new Circle(69,p);

        }
    }
}