using System.ComponentModel.DataAnnotations;

namespace Excercise_1.MVC.Models
{
    public class Guess
    {
        public static string RandomNumbers(int guess)
        {
            Random random = new();
            int rand = random.Next(0, 10);
            int guesses = 0;
            guess = Convert.ToInt32(guess);
            if (guess < rand)
            {
                guesses++;
                return "The guessing number " + guess + " was to small and the rand nr is " + rand + " You has guessed " + guesses + "times.";
            }
            else if (guess > rand)
            {
                guesses++;
                return "The guessing number " + guess + " was to big " + rand + " You has guessed " + guesses + "times.";
            }
            else if (guess == rand)
            {
                return guess + " Your guesses is equals " + rand + " and you have guesses " + guesses + " times";
            }
            return "Over and out";

        }
    }

}