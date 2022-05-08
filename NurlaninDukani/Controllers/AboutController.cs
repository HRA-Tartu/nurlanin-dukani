using Microsoft.AspNetCore.Mvc;

namespace NurlaninDukani.Controllers
{
    public class AboutController : Controller
    {
        /// <summary>
        /// Haqqımızda səhifəsinin index-i
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
