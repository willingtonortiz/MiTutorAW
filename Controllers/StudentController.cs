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
using MiTutor.Util.Sessions;
using MiTutor.ViewModels.StudentActions;

namespace MiTutor.Controllers
{
    public class StudentController : Controller
    {
        private readonly MiTutorContext _context;

        public StudentController(MiTutorContext context)
        {
            _context = context;
            SessionService.GetInstance().user =  _context.Users.FirstOrDefault( u => u.UserId == 4);
        }

        [HttpGet]
        public async Task<IActionResult> DisplayTutoringSession(int StudentId, int TutoringSessionId)
        {
            StudentId=4;
            TutoringSessionId=1;
            StudentTutoringSessionView _StudentTutoringSession = new StudentTutoringSessionView();
            _StudentTutoringSession.TutoringSession =  await _context.TutoringSessions.Include(ts => ts.Subject).Include(ts => ts.StudentTutoringSessions).FirstOrDefaultAsync(ts => ts.TutoringId == TutoringSessionId);
            _StudentTutoringSession.StudentId = StudentId;


            foreach(var i in _StudentTutoringSession.TutoringSession.StudentTutoringSessions){
                if(StudentId == i.StudentId){
                    _StudentTutoringSession.Confirmed=true;
                }   
            }
            

            return View(_StudentTutoringSession);
        }

        [HttpPost]
        public async Task<IActionResult> DisplayTutoringSession(StudentTutoringSessionView _StudentTutoringSessionView)
        {

            if (ModelState.IsValid)
            {
                TutoringSession _TutoringSession = await _context.TutoringSessions.Include(s => s.StudentTutoringSessions).FirstOrDefaultAsync(t => t.TutoringId == _StudentTutoringSessionView.TutoringSession.TutoringId);
                Student _Student = await _context.Students.Include(s => s.StudentTutoringSessions).FirstOrDefaultAsync(s => s.StudentId == _StudentTutoringSessionView.StudentId);

                StudentTutoringSession STS = new StudentTutoringSession();
                STS.Student = _Student;
                STS.TutoringSession = _TutoringSession;
            
             
                _TutoringSession.StudentTutoringSessions.Add(STS);
                _Student.StudentTutoringSessions.Add(STS);

                _context.TutoringSessions.Update(_TutoringSession);
                _context.Students.Update(_Student);
                await _context.SaveChangesAsync();
                
            }

            return RedirectToAction("Index", "Home");
        }


    }
}
