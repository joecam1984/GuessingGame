namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numGen = new Random();
            string guessAgain = "y";
            int userAttempts = 0;
            string userAgain;
            int zoltarrNumber;

            Console.WriteLine("Welcome to Zoltarr! Zoltarr thinking of a number between 1 and 10. See if you can guess the number Zoltarr thinking of!");

            while (guessAgain == "y")
            {
                zoltarrNumber = numGen.Next(1, 11);
                Console.WriteLine("Enter your guess.");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == zoltarrNumber)
                {
                    Console.WriteLine("You got Zoltarr number!");
                    userAttempts = 0;
                    Console.WriteLine("Would you like to play again?");
                    guessAgain = Console.ReadLine().ToLower();
                }
                else if (userGuess > 10 || userGuess < 1) {
                    Console.WriteLine("Zoltarr no play with cheaters! Zoltarr numbers are between 1 and 10!");
                    guessAgain = "n";
                }
                else if (userGuess != zoltarrNumber && userAttempts < 3)
                {
                    Console.WriteLine("Dat not Zoltarr number!");
                   // if (userAttempts < 3) { }
                    Console.WriteLine("Zoltarr number was " + zoltarrNumber + "!");
                    userAttempts++;
                    Console.WriteLine("Would you like to try again?");
                    guessAgain = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine($"You used all your attempts. Zoltarr number was {zoltarrNumber}. Would you like to start again?");
                    userAttempts = 0;
                    guessAgain = Console.ReadLine().ToLower();
                }
            }
        }
    }
}