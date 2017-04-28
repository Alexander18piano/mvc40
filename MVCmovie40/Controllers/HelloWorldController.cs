using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCmovie40.Controllers
{
    public class HelloWorldController : Controller
    {   //
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome (string name, int numtimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["numtimes"] = numtimes;

            return View();
        }
             
             }
}
