using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager( new EfCategoryRep());
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
