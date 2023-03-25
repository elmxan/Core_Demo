using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
    public class CategoryController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
