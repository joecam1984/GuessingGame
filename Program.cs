namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numGen = new Random();
            string guessAgain = "y";
            int comboTracker = 0;
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
                    comboTracker++;
                    Console.WriteLine("Would you like to play again?");
                    guessAgain = Console.ReadLine().ToLower();
                }
                else if (userGuess > 10 || userGuess < 1) {
                    Console.WriteLine("Zoltarr no play with cheaters! Zoltarr numbers are between 1 and 10!");
                    comboTracker = 0;
                    guessAgain = "n";
                }
                else if (userGuess != zoltarrNumber)
                {
                    Console.WriteLine("Dat not Zoltarr number!");
                    Console.WriteLine("Zoltarr number was " + zoltarrNumber + "!");
                    comboTracker = 0;
                    Console.WriteLine("Would you like to try again?");
                    guessAgain = Console.ReadLine().ToLower();
                }
                
            }

        }
    }
}