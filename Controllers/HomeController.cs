using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiTutor.Data;
using MiTutor.Models;
using MiTutor.Util;
using MiTutor.ViewModels.Home;

namespace MiTutor.Controllers
{
	public class HomeController : Controller
	{
		private readonly MiTutorContext _context;

		public HomeController(MiTutorContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IActionResult Index()
		{
			ViewData["IsSearching"] = false;

			HomeIndexViewModel model = new HomeIndexViewModel();



			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Search(HomeIndexViewModel model)
		{
			if (ModelState.IsValid)
			{
				ViewData["IsSearching"] = true;
				string search = model.Text;

				model.Tutorings = await _context
					.TutoringSessions
					.Where(ts => ts.Subject.Name == search)
					.Include(ts => ts.Tutor)
						.ThenInclude(tutor => tutor.Person)
					.Include(ts => ts.Subject)
					.ToListAsync();

				if (model.Tutorings.Count == 0)
				{
					ModelState.AddModelError(string.Empty, "No se encontraron tutorías");
				}

				return View("Index", model);
			}
			return View("Index", new HomeIndexViewModel());
		}


		public IActionResult TutoriaDetail()
		{

			return View();
		}


		public IActionResult Suscripcion()
		{
			return View();
		}
	}
}
