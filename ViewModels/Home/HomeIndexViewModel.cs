using MiTutor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiTutor.ViewModels.Home
{
    public class HomeIndexViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string Text { get; set; }

        public List<TutoringSession> Tutorings { get; set; }
        public List<Tutor> Tutors { get; set; }

        public HomeIndexViewModel()
        {
            Tutorings = new List<TutoringSession>();
            Tutors = new List<Tutor>();
        }
    }
}
