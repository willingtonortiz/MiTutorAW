using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiTutor.Controllers
{
	public class AccountController : Controller
	{
		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}


        [HttpGet]
		public IActionResult Register()
		{
			return View();
		}
	}
}