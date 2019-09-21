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

		public int TutorId { get; set; }

		[ForeignKey("TutorId")]
		public Tutor Tutor { get; set; }

		public List<AvailabilityDay> AvailabilityDays { get; set; }
	}
}