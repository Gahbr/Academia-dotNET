using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ProjetoMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome (int numTimes = 10)
        {
            ViewData["Message"] = "Oi pesssoal" ;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
