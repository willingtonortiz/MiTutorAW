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
using MiTutor.Util.Sessions;
using MiTutor.ViewModels.Home;

namespace MiTutor.Controllers
{
	public class HomeController : Controller
	{
		private readonly MiTutorContext _context;
		// private SessionService sessionService;

		public HomeController(MiTutorContext context)
		{
			_context = context;
			// sessionService = SessionService.GetInstance();
		}

		public IActionResult Home()
		{
			
			return View();
		}

		[HttpGet]
		public IActionResult Index()
		{
			ViewData["IsSearching"] = false;

			return View(new HomeIndexViewModel());
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


				model.Tutors = await _context.Tutors
					.Include(t => t.Person)
					.Where(t => t.TutorSubjects.Any(ts => ts.Subject.Name == search))
					.ToListAsync();


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

		public IActionResult Profile()
		{
			return View();
		}

		public IActionResult Nuevatutoria(){
			return View();
		}
		
		public IActionResult Landing(){
			return View();
		}
	}
}
