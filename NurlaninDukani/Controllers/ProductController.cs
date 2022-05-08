using Microsoft.AspNetCore.Mvc;

namespace NurlaninDukani.Controllers
{
    public class ProductController : Controller
    {
        /// <summary>
        /// Məhsulların siyahısı
        /// </summary>
        /// <returns></returns>
        public IActionResult List()
        {
            return View();
        }

        /// <summary>
        /// Məhsul barədə detallı məlumat
        /// </summary>
        /// <returns></returns>
        public IActionResult Detail()
        {
            return View();
        }
    }
}
