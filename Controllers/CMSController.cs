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
    }
}
