using Excercise_1.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;

namespace Excercise_1.MVC.Controllers
{
    public class GuessingGame : Controller
    {
        [HttpPost]
        public IActionResult GuessNumber(int guess)
        {
            if (!(string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd"))))
            {
                int storedRnd = (int)HttpContext.Session.GetInt32("intRnd");
                string response = Guess.GuessTheNumber(Convert.ToInt32(guess),storedRnd);

                ViewBag.Number = response;

            }
            else
            {
                ViewBag.Number = "Enter a number between 1 and 100 and Submit";
            }
            return View();
        }



        [HttpGet]
        public IActionResult GuessNumber()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd")))
            {
                int getRnd = Guess.RandomNumber();
                HttpContext.Session.SetInt32("intRnd", getRnd);
                ViewBag.Rnd = getRnd;
            }
            else
            {
                ViewBag.Rnd = HttpContext.Session.GetInt32("intRnd");
            }
            return View();
        }



        [HttpGet]
        public IActionResult Reset()
        {
            int getRnd = Guess.RandomNumber();
            HttpContext.Session.SetInt32("intRnd", getRnd);
            ViewBag.Rnd = getRnd;
            return RedirectToAction(nameof(GuessNumber));
        }
    }



}


