using System;
using System.Collections.Generic;

namespace MiTutor.Models
{
    public class TutoringOffer: Tutoring 
    {
        public List<TutoringSession> TutoringSessions { get; set; }
        public string Description {get; set;}
        public TutoringOffer() : base() { }

    }
}