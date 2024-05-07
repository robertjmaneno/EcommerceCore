using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ecommerce.Controllers
{
    public class CategoryController(ApplicationDbContext db) : Controller
    {
        private readonly ApplicationDbContext _db = db;

        public IActionResult Index()
        {    List<Category> ObjectCategoriesList = _db.Categories.ToList();
            return View(ObjectCategoriesList);
        }

        public IActionResult Create() { 
            return View();
        }


        [HttpPost]
        public IActionResult Create(Category category) 
        {  
            if(ModelState.IsValid) {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index", "Category");
            }
           
            return View();
        }
    }
}
