using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MiTutor.Models
{
    public class TutoringSession : TutoringOffer
    {
        // [Key]
        // public int TutoringSessionId { get; set; }
        public List<Qualification> Qualifications { get; set; }
        public List<StudentTutoringSession> StudentTutoringSessions { get; set; }
        public List<TopicTutoringSession> TopicTutoringSessions { get; set; }
    
    }
}