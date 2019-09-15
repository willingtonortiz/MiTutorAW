using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiTutor.Models
{
    public class Availability
    {
        [Key]
        public int AvailabilityId { get; set; }


        public List<AvailabilityDay> AvailabilityDays { get; set; }

        [ForeignKey("TutorId")]
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }
    }
}