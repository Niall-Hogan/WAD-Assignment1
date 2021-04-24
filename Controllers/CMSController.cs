using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WAD_Assignment.Models;
using WAD_Assignment1.Models;

namespace WAD_Assignment1.Controllers
{
    public class CMSController : Controller
    {

        private readonly ILogger<CMSController> _logger;
        private readonly ApplicationDbContext _context;

        public CMSController(ILogger<CMSController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        public IActionResult Index()
        {

            List<Recipe> model = _context.Recipes.ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddRecipe()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRecipe(RecipeForm model)
        {
            int recID = _context.Recipes.ToList().Count() + 1;

            Recipe newRecipe = new Recipe
            {
                RecipeID = recID,
                Title = model.Title,
                Image = model.Image,
                PublishDate = DateTime.Now,
                CookingTime = model.CookingTime,
                Step1 = model.Step1,
                Step2 = model.Step2,
                Step3 = model.Step3,
                Step4 = model.Step4,
                Ingredient1 = model.Ingredient1,
                Ingredient2 = model.Ingredient2,
                Ingredient3 = model.Ingredient3,
                Ingredient4 = model.Ingredient4,
                Ingredient5 = model.Ingredient5,
                Ingredient6 = model.Ingredient6,
                Ingredient7 = model.Ingredient7,

            };
            _context.Add(newRecipe);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
          
        }
    }
}
