using System;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int randomNumber = random.Next(1, 100);

            Console.WriteLine("Let's play a game?");
            Console.WriteLine("The game is \"Guess A Number\"");
            Console.WriteLine("It is easy, I have a number, You try to guess it?");
            Console.WriteLine("Let's play?");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Guess a number (1-100): ");

                int n = int.Parse(Console.ReadLine());
                string message = "";

                if (n == randomNumber)
                    break;

                if (((randomNumber - n) <=5) && ((randomNumber - n) > 0))
                    message = "Low";

                if (((randomNumber - n) > 5))
                    message = "Too Low";

                if (((randomNumber - n) >= -5) && ((randomNumber - n) < 0))
                    message = "High";

                if (((randomNumber - n) < -5))
                    message = "Too HIgh";

                Console.WriteLine($"{message}");
            }

            Console.WriteLine("You guessed it!");
        }
    }
}
