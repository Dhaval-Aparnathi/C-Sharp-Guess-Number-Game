using System;

namespace Guess_The_Random_Number
{
    class Program
    {
        static void Main()
        {
            Game_Class obj = new Game_Class();
            int n;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----> NUMBER GUESSING GAME (1 - 100) <----");
            play:
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nGuess the Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            obj.SetUserInput(n);
            if (obj.IsRightGuess() == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n----> You Won <----\n");
                obj.GetCounter();
            }
            else
            {
                goto play;
            }
            Console.ReadKey();
        }
    }    
}