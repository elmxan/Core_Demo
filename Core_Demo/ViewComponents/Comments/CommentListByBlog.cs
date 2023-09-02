using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Core_Demo.ViewComponents.Comments
{
    public class CommentListByBlog:ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentRep());
        public IViewComponentResult Invoke(int id) 
        {
            var values = cm.GetList(id);
            if (values.Count == 0)
            {
                return View(values);
            }
            else
            {
                return View(values);
            }


        } 


    }
}
