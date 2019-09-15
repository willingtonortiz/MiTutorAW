using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiTutor.Models
{
    public class TutoringOffer
    {
        [Key]
        public int TutoringId { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }


        public Subject Subject { get; set; }
        public List<Topic> Topics { get; set; }
        public string Description { get; set; }


       
        public int TutorId { get; set; }

        [ForeignKey("TutorId")]
        public Tutor Tutor { get; set; }
    }
}