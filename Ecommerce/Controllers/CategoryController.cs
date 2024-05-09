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

        public IActionResult Edit(int? Id)
        {
            if(Id == null && Id == 0)
            {
                return NotFound();
            }

            var category = _db.Categories.FirstOrDefault(c => c.Id == Id);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(category);
                _db.SaveChanges();
                return RedirectToAction("Index", "Category");
            }

            return View();
        }

        public IActionResult Delete(int? Id)
        {
            if (Id == null && Id == 0)
            {
                return NotFound();
            }

            var category = _db.Categories.FirstOrDefault(c => c.Id == Id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? Id)
        {

            
                var category = _db.Categories.Find(Id);
                if (category == null)
                {
                    return NotFound();
                }
              

            
            _db.Categories.Remove(category);
            _db.SaveChanges();
            return RedirectToAction("Index", "Category");

        }



    }
}
