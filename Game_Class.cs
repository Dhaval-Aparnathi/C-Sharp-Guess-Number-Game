namespace Guess_The_Random_Number
{
    internal class Game_Class
    {
        private int UserInput;
        private int CompInput;
        private int Counter = 0;
        public Game_Class() 
        {
            Random random = new Random();
            CompInput = random.Next(1, 100);
        }
        public void SetUserInput(int UserInput)
        {
            this.UserInput = UserInput;
        }
        public int IsRightGuess()
        {
            if (CompInput > UserInput)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                SetCounter();
                Console.WriteLine("\nWrong Guess !!! Hint => Random Number is Greater...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n_____________________________________________________________________\n");
                return 1;
            }
            else if (CompInput < UserInput)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                SetCounter();
                Console.WriteLine("\nWrong Guess !!! Hint => Random Number is Smaller...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n_____________________________________________________________________\n");
                return 2;
            }
            else
            {
                SetCounter();
                return 3;
            }
        }
        public void SetCounter()
        {
            Counter++;
        }
        public void GetCounter()
        {
            Console.WriteLine("The number of Guesses => " + Counter);
        }
    }
}