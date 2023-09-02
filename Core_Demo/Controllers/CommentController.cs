using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Demo.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRep());

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
		public PartialViewResult PartialAddComment(Comment c)
		{

            c.CommentDate=DateTime.Parse(DateTime.Now.ToShortDateString());
            c.CommentStatus = true;
            c.BlogId = 4;
            cm.CommentAdd(c);
			return PartialView();
		}
		public PartialViewResult CommentListByBlog(int id)
        {
            var values=cm.GetList(id);
            return PartialView(values);
        }
    }
}
