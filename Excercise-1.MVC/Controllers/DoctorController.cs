using Microsoft.AspNetCore.Mvc;

namespace Excercise_1.MVC.Controllers
{
    public class DoctorController : Controller
    {
        [HttpPost]
        public IActionResult FeverCheck(double temp) // overload 
        {
            if (temp != 0)
            {

                ViewBag.Msg = Models.Doctor.TestForFever(temp);
                return View();
            }
            else
            {
                ViewBag.Msg = "Pls enter your temperature and then hit Submit";
                return View();
            }
        }
        [HttpGet]
        public IActionResult FeverCheck()// overload
        {
            return View();
        }


    }
}