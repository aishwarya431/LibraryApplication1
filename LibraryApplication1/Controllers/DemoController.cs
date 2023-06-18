using LibraryApplication1.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApplication1.Controllers
{
    public class DemoController : Controller
    {
        private readonly DatabaseContext _context;
        public DemoController(DatabaseContext conext) { 
                _context=conext;
        }

        public IActionResult Index()
        {
            List<SubCategory> subcategorylist = new List<SubCategory>();

            // Get data from database
            subcategorylist = (from subcategory in _context.SubCategories
                               select subcategory).ToList();

            subcategorylist.Insert(0, new SubCategory { SubCategoryId = 0, SubCategoryName = "select" });

            ViewBag.ListofSubCategory = subcategorylist;
            return View();
        }
    }
}
