using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiTutor.Models
{
    public class Availability
    {
        public int AvailabilityId { get; set; }

        public List<AvailabilityDay> AvailabilityDays {get; set;}
        public Availability() { }

    }
}