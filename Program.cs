using System;

 class Program
    {
    static void Main(string[] args)
    {
        IfElse();


        static void IfElse()
        {
            string a = "a";
            string b = "b";

            bool c = a != b;

            int A = 2;
            int B = 1;
            double X = 2.3;
            double Y = 2.5;

            int C = A > B ? ++A : B;
            Console.WriteLine(C);

            bool XY = (A < B) || (X > Y);

            Console.WriteLine(c);
            Console.WriteLine(XY);

            var inv = true;
            var result = !inv;
            Console.Write(result);

            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            /*if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your color is cyan!");
            }*/


            switch (color)
            {
                case "yellow":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

                case "blue":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

                default: 
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }
        }
    }
}
