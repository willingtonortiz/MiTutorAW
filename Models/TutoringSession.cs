using System;
using System.Collections.Generic;

namespace MiTutor.Models
{
    public class TutoringSession: Tutoring 
    {
        public List<Student> Students {get; set;}
        public List<Qualification> Qualifications {get; set; }
        public TutoringSession() : base() { }

    }
}