using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WAD_Assignment.Models;
using WAD_Assignment1.Models;

namespace WAD_Assignment1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(String SearchString)

        {

            if (!string.IsNullOrEmpty(SearchString))

            {


                var Recipes = from m in _context.Recipes

                            where m.Title.Contains(SearchString)

                            select m;

                

                List<Recipe> model = Recipes.ToList();

                ViewData["SearchString"] = SearchString;

                return View(model);

            }
            else
            {
                return View();
            }



        }

        public IActionResult AllRecipes()
        {

            List<Recipe> model = _context.Recipes.ToList();
            return View(model);
        }

        public IActionResult ShoppingList()
        {
            return View();
        }

        public IActionResult RecipeDetails(int id)
        {
            Recipe model = _context.Recipes.Find(id);

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
