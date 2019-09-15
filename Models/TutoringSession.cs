using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MiTutor.Models
{
    public class TutoringSession : TutoringOffer
    {
        // [Key]
        // public int TutoringSessionId { get; set; }
        public List<Student> Students { get; set; }
        public List<Qualification> Qualifications { get; set; }
    }
}