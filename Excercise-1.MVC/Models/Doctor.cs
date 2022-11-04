using Microsoft.AspNetCore.Mvc;

namespace Excercise_1.MVC.Models
{
    public class Doctor 
    {
        public static string TestForFever(double temperature)
        {
            return (temperature > 37) ? "Doctor says you have fever...Take more liquids" : "Doctor says you don't have any fever..";
        }
    }
}
