using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiTutor.Models
{
    public class Tutor: Person
    {
        public int Points { get; set; }
        public string Description {get; set;}
        public Availability Availability {get; set;}
        public List<Subject> TutorSubjects {get; set;}
        public List<TutoringOffer> TutoringOffers {get; set;}
        public List<TutoringSession> TutoringSessions {get; set;}
        public List<Qualification> TutorQualification {get; set;}

        public Tutor() : base() { }

    }
}