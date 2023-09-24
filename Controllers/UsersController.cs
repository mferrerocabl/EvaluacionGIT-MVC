using Microsoft.AspNetCore.Mvc;
using GIT_MVC.Models;

namespace GIT_MVC.Controllers
{
	[Route("users")]
	public class UsersController : Controller
	{
		[Route ("obtener-todos")]
		public IActionResult GetList()
		{
			var user = new UserModel
			{
				Name = "Mateo",
				LastName = "Ferrero"
			};

			return View("Index", user);
		}
	}
}
