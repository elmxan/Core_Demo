using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.ViewComponents.Category
{
	public class CategoryList:ViewComponent
	{
		CategoryManager cm = new CategoryManager(new EfCategoryRep());
		public IViewComponentResult Invoke()
		{
			var values = cm.GetList();
			return View(values);	
		}
	}
}
