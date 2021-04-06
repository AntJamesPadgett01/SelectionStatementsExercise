using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 13;
            Console.WriteLine("Guess the favorite number. Hint below 20");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favoriteNumber)
            {
                Console.WriteLine("Too LOW!!!");
            }
            else if (userGuess > favoriteNumber)
            {
                Console.WriteLine("Too HIGH!!");
            }
            else if (userGuess == favoriteNumber)
            {
                Console.WriteLine("You were correct, Great JOB!!!!");
            }
            else
                Console.WriteLine("Nevermind");
        }
    }
}
