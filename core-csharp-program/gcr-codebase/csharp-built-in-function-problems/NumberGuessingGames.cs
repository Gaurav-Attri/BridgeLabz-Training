using System;

class NumberGuessingGame{
    static void Main(string[] args){
        Console.WriteLine("\n========== Number Guessing Game ==========\n");
        Console.WriteLine("Think of a number between 1 and 100.");
        Console.WriteLine("I will try to guess it.");
        Console.WriteLine("Enter:");
        Console.WriteLine("H - if my guess is too high");
        Console.WriteLine("L - if my guess is too low");
        Console.WriteLine("C - if my guess is correct\n");

        int lowerBound = 1;
        int upperBound = 100;
        bool isGuessed = false;

        while (!isGuessed)
        {
            int guess = GenerateGuess(lowerBound, upperBound);
            Console.WriteLine("\nMy guess is: " + guess);

            char feedback = GetUserFeedback();

            if (feedback == 'C')
            {
                Console.WriteLine("\nYay! I guessed your number correctly!");
                isGuessed = true;
            }
            else if (feedback == 'H')
            {
                upperBound = guess - 1;
            }
            else if (feedback == 'L')
            {
                lowerBound = guess + 1;
            }
        }
    }

    // Method to generate a random guess between given limits
    static int GenerateGuess(int low, int high){
        Random rand = new Random();
        return rand.Next(low, high + 1);
    }

    // Method to get user feedback
    static char GetUserFeedback(){
        Console.Write("Enter your feedback (H / L / C): ");
        char feedback = char.ToUpper(Console.ReadLine()[0]);
        return feedback;
    }
}

