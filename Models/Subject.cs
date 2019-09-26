using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MiTutor.Models
{
	public class Subject
	{
		[Key]
		public int SubjectId { get; set; }
		public string Name { get; set; }


		public List<Topic> Topics { get; set; }
		public List<StudentSubject> StudentSubjects { get; set; }
		public List<TutorSubject> TutorSubjects { get; set; }


		public override string ToString()
		{
			return $"Subject {{ Subject: {SubjectId}, Name: {Name} }}";
		}
	}
}