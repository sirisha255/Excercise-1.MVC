using Excercise_1.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;

namespace Excercise_1.MVC.Controllers
{
    public class GuessingGame : Controller
    {
        Random randomNumber = new Random();

        [HttpGet]
        public IActionResult GuessNumber()
        {
            string? RandomNumCookie = Request.Cookies["randomNumber"];
            if (RandomNumCookie != null)
            {
                CookieOptions Option = new CookieOptions();
                Option.Expires = DateTime.Now.AddMinutes(0);
                randomNumber.Next(0, 100);
                Response.Cookies.Append("randomNumber", "", Option);
            }
            return View();

        }
        [HttpPost]

        public IActionResult GuessNumber(int guess)
        {
            string? RandomNumCookie = Request.Cookies["randomNumber"];
            int Rnd;
            if (RandomNumCookie == null)
            {
                CookieOptions Option = new CookieOptions();
                Option.Expires = DateTime.Now.AddMinutes(10);
                int num = randomNumber.Next(0, 100);
                Response.Cookies.Append("randomNumber", num.ToString(), Option);
                Rnd = num;
            }
            else
            {
                Rnd = int.Parse(RandomNumCookie);
            }

            ViewBag.Number = Models.Guess.GuessTheNumber(guess, Rnd);
            return View();

        }
    }


}




