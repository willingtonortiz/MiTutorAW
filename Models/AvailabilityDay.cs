using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiTutor.Models
{
    public class AvailabilityDay
    {
        public int AvailabilityDayId { get; set; }
        public string Day { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        
        public int AvailabilityId { get; set; }

        [ForeignKey("AvailabilityId")]
        public Availability Availability { get; set; }
    }
}