using System.ComponentModel.DataAnnotations;

namespace Excercise_1.MVC.Models
{
    public class Guess
    {
        public static string RandomNumbers(int guess)
        {

           return (guess == 5) ? "your guess is correct" : " your guess is wrong...try again";
           

        }
    }

}