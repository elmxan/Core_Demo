using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.ViewComponents.Blog
{
	public class WriterLastBlog:ViewComponent
	{
		BlogManager bm = new BlogManager(new EfBlogRep());
		public IViewComponentResult Invoke()
		{

			var values = bm.GetBlogByWriter(1);
			return View(values);

		}
	}
}
