using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiTutor.Data;
using MiTutor.Models;
using MiTutor.ViewModels.StudentActions;

namespace MiTutor.Controllers
{
    public class StudentController : Controller
    {
        private readonly MiTutorContext _context;

        public StudentController(MiTutorContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> DisplayTutoringOffer(int StudentId, int TutoringSessionId)
        {
            StudentTutoringSessionView _StudentTutoringSession = new StudentTutoringSessionView();
            _StudentTutoringSession.TutoringSession = await _context.TutoringSessions.FirstOrDefaultAsync(t => t.TutoringId == TutoringSessionId);
            _StudentTutoringSession.StudentId = StudentId;
            return View(_StudentTutoringSession);
        }

        [HttpPost]
        public async Task<IActionResult> DisplayTutoringOffer(StudentTutoringSessionView _StudentTutoringSessionView)
        {

            if (ModelState.IsValid)
            {
                TutoringSession _TutoringSession = await _context.TutoringSessions.FirstOrDefaultAsync(t => t.TutoringId == _StudentTutoringSessionView.TutoringSession.TutoringId);
                Student _Student = await _context.Students.FirstOrDefaultAsync(s => s.StudentId == _StudentTutoringSessionView.StudentId);

                StudentTutoringSession STS = new StudentTutoringSession();
                STS.Student = await _context.Students.FirstOrDefaultAsync(s => s.StudentId == _StudentTutoringSessionView.StudentId);
                STS.TutoringSession = _TutoringSession;
                STS.Student = _Student;

                _TutoringSession.StudentTutoringSessions = new List<StudentTutoringSession>();
                _TutoringSession.StudentTutoringSessions.Add(STS);

                _Student.StudentTutoringSessions = new List<StudentTutoringSession>();
                _Student.StudentTutoringSessions.Add(STS);

                _context.TutoringSessions.Update(_TutoringSession);
                _context.Students.Update(_Student);
                await _context.SaveChangesAsync();
                
            }

            return RedirectToAction("Index", "Home");
        }


    }
}
