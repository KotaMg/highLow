using System;

// Name: McGregor, Dakota
// Date: 04/17/2021

// picks a random number based on the number the user enters and gives hints (Higher or lower) as the user attempts to guess the number that was randomly generated.

namespace Game
{
    public class HighLow
    {

        public HighLow()
        {
            UI.Theme();
            Play();
        }

        private static void Play()
        {

            UI.Header(" High/Low!");
            Console.WriteLine("\r\n Welcome,\r\nThe game is simple, you pick a number and a random number between between 1 and your number will be created.\r\n");
            Console.WriteLine("You will then be tasked with guessing the number that was generated and will recieve hints (higher/lower) based on your guess!\r\n\r\n");
            UI.Separator();
            Console.WriteLine("\r\n Press RETURN when ready to play.");
            Console.ReadLine();
            Console.Clear();
            Random random = new Random();

            int num, difficulty = 0, points = 100;
            bool keepGoing = true;

            while (keepGoing)
            {
                UI.Header("Welcome to High / Low");

                difficulty = Validation.Interger("\r\nPlease enter a number to start: ");

                if (difficulty > 1)
                {
                    keepGoing = false;
                }
            }
            num = random.Next(1, difficulty);
            UserGuess(num, points);
        }

        public static void UserGuess(int i, int points)
        {
            int guess, tries = 1, num = i;
            bool keepGoing = true;

            while (keepGoing)
            {

                guess = Validation.Interger($"\r\n Guess [{tries}]. Please enter a number: ");

                if (guess > num)
                {
                    Console.WriteLine("\r\nLower\r\n");
                    tries++;
                    points--;
                }
                else if (guess < num)
                {
                    Console.WriteLine("\r\nHigher\r\n");
                    tries++;
                    points--;
                }
                else
                {
                    Console.WriteLine("\r\n! Correct !\r\n");
                    tries++;
                    points--;
                    keepGoing = false;
                }
            }

            Console.Clear();
            UI.Header(" Winner!");
            Console.WriteLine($"\r\n Congratulations! It only took {tries -1} tries to find the number!\r\nScore: {points}");
        }
    }
}