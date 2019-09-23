using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiTutor.Data;
using MiTutor.Models;
using MiTutor.ViewModels.Account;

namespace MiTutor.Controllers
{
	public class AccountController : Controller
	{
		private readonly MiTutorContext _context;

		public AccountController(MiTutorContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(LoginViewModel model)
		{
			if (ModelState.IsValid)
			{
				User user = await _context
				.Users
				.FirstOrDefaultAsync(
					u => (u.Username == model.Username && u.Password == model.Password) ||
					(u.Email == model.Username && u.Password == model.Password)
				);

				if (user != null)
				{
					return RedirectToAction("Index", "Home");
				}

				ModelState.AddModelError(string.Empty, "Usuario no encontrado");

				return View(model);
			}
			return View(model);
		}

		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
		{
			if (ModelState.IsValid)
			{
				University university = await _context
					.Universities
					.SingleOrDefaultAsync(u => u.Name == registerViewModel.University);

				university.Persons = new List<Person>();

				if (university == null)
				{
					return RedirectToAction(nameof(Register));
				}

				User user = new User()
				{
					Username = registerViewModel.Username,
					Email = registerViewModel.Email,
					Password = registerViewModel.Password
				};

				Student student = new Student()
				{
					Points = 0,
				};

				Person person = new Person()
				{
					Name = registerViewModel.Name,
					LastName = registerViewModel.Lastname,
					Semester = registerViewModel.Semester
				};

				// Person - Student
				person.Student = student;
				student.Person = person;


				// Person - University
				person.University = university;
				university.Persons.Add(person);


				// Person - User
				person.User = user;
				user.Person = person;

				await _context.Persons.AddAsync(person);
				await _context.Users.AddAsync(user);
				await _context.Students.AddAsync(student);


				await _context.SaveChangesAsync();


				return RedirectToAction(nameof(Login));
			}

			return RedirectToAction(nameof(Register));
		}
	}
}