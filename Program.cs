namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numGen = new Random();
            string guessAgain = "y";
            int userAttempts = 1;
            string userAgain;
            int zoltarrNumber = 0;
            bool gameStart = true;

            Console.WriteLine("Welcome to Zoltarr! Zoltarr thinking of a number between 1 and 10. See if you can guess the number Zoltarr thinking of!");

            while (guessAgain == "y")
            {
                if (gameStart)
                {
                    zoltarrNumber = numGen.Next(1, 11);
                    gameStart = false;

                }
                Console.WriteLine("Enter your guess.");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == zoltarrNumber)
                {
                    Console.WriteLine("You got Zoltarr number!");
                    userAttempts = 1;
                    Console.WriteLine("Would you like to play again? y or n");
                    guessAgain = Console.ReadLine().ToLower();
                    gameStart = true;
                }
                else if (userGuess > 10 || userGuess < 1)
                {
                    Console.WriteLine("Zoltarr no play with cheaters! Zoltarr numbers are between 1 and 10!");
                    guessAgain = "n";
                }
                else if (userGuess != zoltarrNumber && userAttempts < 3)
                {
                    Console.WriteLine("Dat not Zoltarr number!");

                    Console.WriteLine(zoltarrNumber);
                    userAttempts++;
                }
                else
                {
                    Console.WriteLine($"You used all your attempts. Zoltarr number was {zoltarrNumber}. Would you like to start again? y or n");
                    userAttempts = 1;
                    guessAgain = Console.ReadLine().ToLower();
                    gameStart = true;
                }
            }
        }
    }
}