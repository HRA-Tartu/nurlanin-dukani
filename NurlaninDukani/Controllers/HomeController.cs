using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NurlaninDukani.Data;
using NurlaninDukani.Models;
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
            //lazy loading

            //eager loading
            var product = _context.Products
                                    .Include(c => c.ProductSizes)
                                    .ThenInclude(c => c.ProductColors)
                                    .ThenInclude(c=>c.Color)
                                        .Where(c => c.Name == "Nike Jordan")
                                            .FirstOrDefault();


            var colorName = product.ProductSizes
                                        .FirstOrDefault()
                                            .ProductColors
                                                .FirstOrDefault()
                                                    .Color
                                                        .Name;


            //var product = await _context.Products.Where(c => c.Id == 1).FirstOrDefaultAsync();


            //var productSizes = await _context
            //                            .ProductSizes
            //                                .Where(c => c.ProductId == product.Id)
            //                                    .ToListAsync();

            //List<ProductColor> colors = new List<ProductColor>();
            //foreach (var productSize in productSizes)
            //{
            //    var color = await _context.ProductColors.Where(c => c.ProductSizeId == productSize.Id).ToListAsync();
            //    colors.AddRange(color);
            //}


           // colors

            return View();
        }
    }
}
