using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core_Demo.Controllers
{
	public class LoginController : Controller
	{
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();

		}
		[HttpPost]
		[AllowAnonymous]
	
		public async Task<IActionResult> Index( Writer p)
		{
			Context c=new Context();
			var datavalue=c.Writers.FirstOrDefault(x=>x.WriterMail==p.WriterMail&&x.WriterPassword==p.WriterPassword);
			if (datavalue!=null) 
			{
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name,p.WriterMail)

				};
				var UserIdentity = new ClaimsIdentity(claims, "a");
				ClaimsPrincipal principal = new ClaimsPrincipal(UserIdentity);
				await HttpContext.SignInAsync(principal);

			return RedirectToAction("Index","Writer");
			}
			else
			{
				return View();
			}

		

		}
		//Context c = new Context();
		//var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
		//	if (datavalue!=null)
		//	{
		//		HttpContext.Session.SetString("Username", p.WriterMail);
		//		return RedirectToAction("Index","Writer");
	 //          }
		//	else
		//	{
		//		return View();
  //           }





	}
}
