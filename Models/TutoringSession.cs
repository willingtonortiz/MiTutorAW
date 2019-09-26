using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MiTutor.Models
{
	public class TutoringSession : TutoringOffer
	{
		public List<Qualification> Qualifications { get; set; }
		public List<StudentTutoringSession> StudentTutoringSessions { get; set; }
		public List<TopicTutoringSession> TopicTutoringSessions { get; set; }

		public override string ToString()
		{
			return $"TutorignSession {{ Id: {TutoringId}, Place: {Place}, Date: {Date}, Capacity: {Capacity}, Description: {Description} }}";
		}
	}
}