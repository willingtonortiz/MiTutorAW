using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiTutor.Models
{
    public class Tutor
    {
        [Key]
        [ForeignKey("Person")]
        public int TutorId { get; set; }
        public int Points { get; set; }
        public string Description { get; set; }


        public List<TutoringSession> TutoringSessions { get; set; }

        public List<TutoringOffer> TutoringOffers { get; set; }

        public List<TutorSubject> TutorSubjects { get; set; }

        public Availability Availability { get; set; }

        public Person Person { get; set; }
    }
}