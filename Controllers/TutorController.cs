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
using MiTutor.ViewModels.TutorActions;
using MiTutor.Util;

namespace MiTutor.Controllers
{
    public class TutorController : Controller
    {
        private readonly MiTutorContext _context;


        private ConsolePrinter ga;
        public TutorController(MiTutorContext context)
        {
            _context = context;
            
        }


        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> PublishTutoringSession(int TutorId)
        {

            var _TutoringSessionTemplate = new TutoringSessionTemplate();
            _TutoringSessionTemplate.Subjects = await _context.Subjects.ToListAsync();
            _TutoringSessionTemplate.Topics = new List<Topic>();
            _TutoringSessionTemplate.Topics = await _context.Topics.ToListAsync();  

            
            return View(_TutoringSessionTemplate);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PublishTutoringSession(TutoringSessionTemplate tutoringSession)
        {
            if (ModelState.IsValid)
            {
                TutoringSession _TutoringSession = new TutoringSession();
                Tutor _Tutor = await _context.Tutors.FirstOrDefaultAsync(t => t.TutorId == 4);
                _TutoringSession.Capacity = tutoringSession.Capacity;
                _TutoringSession.Date = tutoringSession.Date;
                _TutoringSession.Description = tutoringSession.Description;
                _TutoringSession.Place = tutoringSession.Place;
                _TutoringSession.Tutor = _Tutor;
                _TutoringSession.Subject = await _context.Subjects.FirstOrDefaultAsync(s => s.SubjectId == tutoringSession.SelectedSubjectId);

                _TutoringSession.TopicTutoringSessions = new List<TopicTutoringSession>();
                TopicTutoringSession _TopicTutoringSession;

                ga =  new ConsolePrinter();

                ga.AddLine(tutoringSession.SelectedTopicsId.Count);
                ga.PrintMessage();


                for (int i = 0; i < tutoringSession.SelectedTopicsId.Count; ++i)
                {
                    _TopicTutoringSession = new TopicTutoringSession();
                    _TopicTutoringSession.Topic = _context.Topics.
                        FirstOrDefault(to => to.TopicId == tutoringSession.SelectedTopicsId.ElementAt(i));
                    _TopicTutoringSession.TutoringSession = _TutoringSession;

                    _TutoringSession.TopicTutoringSessions.Add(_TopicTutoringSession);

                    _TopicTutoringSession.Topic.TopicTutoringSessions = new List<TopicTutoringSession>();
                    _TopicTutoringSession.Topic.TopicTutoringSessions.Add(_TopicTutoringSession);
                    _context.Topics.Update(_TopicTutoringSession.Topic);
                }
                _context.TutoringSessions.Add(_TutoringSession);

                _Tutor.TutoringSessions = new List<TutoringSession>();
                _Tutor.TutoringSessions.Add(_TutoringSession);
                _context.Tutors.Update(_TutoringSession.Tutor);
               
                await _context.SaveChangesAsync();
               return RedirectToAction("Home", "Home");
                
            }
            return RedirectToAction("Index", "Home");
        }

        public async Task<JsonResult> GetTopics(int SubjectId)
        {
            List<Topic> topicsList = new List<Topic>();
            topicsList = await _context.Topics.Where(t => t.Subject.SubjectId == SubjectId).ToListAsync();
            return Json(new SelectList(topicsList, "TopicId", "Name"));
        }
    }
}
