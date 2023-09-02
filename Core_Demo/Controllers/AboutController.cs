using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
	public class AboutController : Controller
	{ AboutManager abm = new AboutManager(new EfAboutRep());
		public IActionResult Index()
		{
			var values = abm.Getlist();
			return View(values);
		}
		public PartialViewResult SocialMediaAbout()
		{


			return PartialView();
		}
	}
}
