using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NurlaninDukani.Data;
using NurlaninDukani.Models;
using NurlaninDukani.Models.View_Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NurlaninDukani.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Ana səhifənin view-su üçün nəzərdə tutulmuş action. Viewmodel məntiqi
        /// ilə səhifədə olan dinamik informasiyalar gələcəkdir.
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
           
            HomeVm vm = new HomeVm();
            vm.productCategories = _context.ProductCategories.ToList();
            return View(vm);
        }
    }
}
