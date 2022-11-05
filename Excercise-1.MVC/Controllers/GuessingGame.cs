using Excercise_1.MVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace Excercise_1.MVC.Controllers
{
    public class GuessingGame : Controller
    {
        [HttpPost]
        public IActionResult GuessNumber(int guess)
        {
            if (guess != 0)
            {
                ViewBag.Number = Models.Guess.RandomNumbers(guess);
                return View();
            }
            else
            {
                ViewBag.Number = "Please enter a number";
                return View();
            }
        }
        [HttpGet]
        public IActionResult GuessNumber()
        {
            return View();
        }
    }
}


