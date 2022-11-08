using Microsoft.AspNetCore.Mvc;
using Excercise_1.MVC.Controllers;

namespace Excercise_1.MVC.Models
{
    public class Guess

    {
        public static string GuessTheNumber(int guess, int MyRandomNum)
        {



            if (guess > MyRandomNum)
            {
                return "Your Number " + guess + "  is too high";
            }
            else if (guess < MyRandomNum)
            {
                return "Your Number " + guess + " is too low";
            }
            else
            {
                return "You got it";
            }




        }

        public static int RandomNumber()
        {
            
            Random MyRandomNum = new Random();
            return MyRandomNum.Next(0, 100);
        }

        internal static string GuessTheNumber(int v)
        {
            throw new NotImplementedException();
        }


    }
}