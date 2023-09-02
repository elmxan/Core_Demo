using Core_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Core_Demo.ViewComponents
{
	public class CommentList:ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			var commentValues = new List<UserComment> 
			{ 
				new UserComment
				{
					Id=1,
					Username="Elmkhan"
				},
				new UserComment
				{
					Id=2,
					Username="Rafiz"
				},
				new UserComment
				{
					Id=3,
					Username="Essen"
				}

			};

			return View(commentValues);	
		}
	}
}
