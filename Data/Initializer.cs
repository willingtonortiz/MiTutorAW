
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MiTutor.Models;
using MiTutor.Util;

namespace MiTutor.Data
{

	public static class DbInitializer
	{
		private static ConsolePrinter printer { get; set; }


		public static void GenerateData(MiTutorContext context)
		{
			context.Database.EnsureCreated();
			LoadUniversities(context);
			LoadCourses(context);
			LoadStudents(context);
			LoadTutors(context);
			LoadTutorsSubjects(context);
		}


		private static void LoadUniversities(MiTutorContext context)
		{
			context.Universities.Add(new University() { Name = "Universidad Peruana de Ciencias Aplicadas" });

			context.SaveChanges();
		}


		private static void LoadCourses(MiTutorContext context)
		{

			// Curso de calculo
			Subject subject1 = new Subject() { Name = "Calculo 2" };
			context.Subjects.Add(subject1);
			context.Topics.Add(new Topic() { Name = "Limites", Subject = subject1 });
			context.Topics.Add(new Topic() { Name = "Derivadas", Subject = subject1 });
			context.Topics.Add(new Topic() { Name = "Integrales", Subject = subject1 });

			// Curso de programacion
			Subject subject2 = new Subject() { Name = "Programacion I" };
			context.Subjects.Add(subject2);
			context.Topics.Add(new Topic() { Name = "Arreglos", Subject = subject2 });
			context.Topics.Add(new Topic() { Name = "Estructuras", Subject = subject2 });
			context.Topics.Add(new Topic() { Name = "Matrices", Subject = subject2 });

			// Curso de lenguaje
			Subject subject3 = new Subject() { Name = "Fisica I" };
			context.Subjects.Add(subject3);
			context.Topics.Add(new Topic() { Name = "MRU", Subject = subject3 });
			context.Topics.Add(new Topic() { Name = "MRUV", Subject = subject3 });
			context.Topics.Add(new Topic() { Name = "Movimiento parabolico", Subject = subject3 });

			context.SaveChanges();
		}
		
		
		private static void GenerateCourses(MiTutorContext context, int subjectNumber, int topicNumber)
		{
			int maxId = 0;

			List<Subject> subjects = context
				.Subjects
				.ToList();

			foreach (var item in subjects)
			{
				maxId = Math.Max(maxId, item.SubjectId);
			}

			for (int i = 0; i < subjectNumber; i++)
			{
				maxId++;
				Subject newSubject = new Subject() { Name = $"Subject_{maxId}" };
				context.Subjects.Add(newSubject);

				for (int j = 0; j < topicNumber; j++)
				{
					Topic newTopic = new Topic() { Subject = newSubject, Name = $"Topic_{maxId}_{j + 1}" };
					context.Topics.Add(newTopic);
				}
			}

			context.SaveChanges();
		}


		private static void LoadTutors(MiTutorContext context)
		{
			University university = context
				.Universities
				.FirstOrDefault();

			Person person1 = new Person() { Name = "tutor_1", University = university };
			Student student1 = new Student() { Person = person1, Points = 0 };
			Tutor tutor1 = new Tutor() { Person = person1, Points = 0 };
			context.Persons.Add(person1);
			context.Students.Add(student1);
			context.Tutors.Add(tutor1);

			Person person2 = new Person() { Name = "tutor_2", University = university };
			Student student2 = new Student() { Person = person2, Points = 0 };
			Tutor tutor2 = new Tutor() { Person = person2, Points = 0 };
			context.Persons.Add(person2);
			context.Students.Add(student2);
			context.Tutors.Add(tutor2);

			Person person3 = new Person() { Name = "tutor_3", University = university };
			Student student3 = new Student() { Person = person3, Points = 0 };
			Tutor tutor3 = new Tutor() { Person = person3, Points = 0 };
			context.Persons.Add(person3);
			context.Students.Add(student3);
			context.Tutors.Add(tutor3);

			context.SaveChanges();
		}

		
		private static void GenerateTutors(MiTutorContext context, int tutorsNumber)
		{
			for (int i = 0; i < tutorsNumber; i++)
			{
				Person person = new Person() { Name = $"tutor_{i + 1}" };
				Student student = new Student() { Person = person, Points = 0 };
				Tutor tutor = new Tutor() { Person = person, Points = 0 };

				context.Persons.Add(person);
				context.Students.Add(student);
				context.Tutors.Add(tutor);
			}

			context.SaveChanges();
		}


		private static void LoadTutoringSessions(MiTutorContext context)
		{
			Subject subject1 = context.Subjects.FirstOrDefault(s => s.Name == "Calculo 2");
			Subject subject2 = context.Subjects.FirstOrDefault(s => s.Name == "Programacion I");
			Subject subject3 = context.Subjects.FirstOrDefault(s => s.Name == "Fisica I");

			Tutor tutor1 = context.Tutors.FirstOrDefault(t => t.Person.Name == "tutor_1");

			TutoringSession tutoringSession1 = new TutoringSession() { Capacity = 3, Date = DateTime.Now, Description = "Description_1", Place = "Place_1", Tutor = tutor1, Subject = subject1 };
			TutoringSession tutoringSession2 = new TutoringSession() { Capacity = 4, Date = DateTime.Now, Description = "Description_2", Place = "Place_2", Tutor = tutor1, Subject = subject2 };
			TutoringSession tutoringSession3 = new TutoringSession() { Capacity = 5, Date = DateTime.Now, Description = "Description_3", Place = "Place_3", Tutor = tutor1, Subject = subject3 };

			context.TutoringSessions.Add(tutoringSession1);
			context.TutoringSessions.Add(tutoringSession2);
			context.TutoringSessions.Add(tutoringSession3);

			context.SaveChanges();
		}


		private static void LoadTutorsSubjects(MiTutorContext context)
		{
			Tutor tutor1 = context.Tutors.FirstOrDefault(t => t.Person.Name == "tutor_1");
			Tutor tutor2 = context.Tutors.FirstOrDefault(t => t.Person.Name == "tutor_2");
			Tutor tutor3 = context.Tutors.FirstOrDefault(t => t.Person.Name == "tutor_3");

			Subject subject1 = context.Subjects.FirstOrDefault(s => s.Name == "Calculo 2");
			Subject subject2 = context.Subjects.FirstOrDefault(s => s.Name == "Programacion I");
			Subject subject3 = context.Subjects.FirstOrDefault(s => s.Name == "Fisica I");

			tutor1.TutorSubjects.Add(new TutorSubject() { Subject = subject1, Tutor = tutor1 });
			tutor1.TutorSubjects.Add(new TutorSubject() { Subject = subject2, Tutor = tutor1 });
			tutor1.TutorSubjects.Add(new TutorSubject() { Subject = subject3, Tutor = tutor1 });


			tutor2.TutorSubjects.Add(new TutorSubject() { Subject = subject1, Tutor = tutor2 });
			tutor2.TutorSubjects.Add(new TutorSubject() { Subject = subject2, Tutor = tutor2 });


			tutor3.TutorSubjects.Add(new TutorSubject() { Subject = subject1, Tutor = tutor3 });
			tutor3.TutorSubjects.Add(new TutorSubject() { Subject = subject2, Tutor = tutor3 });
			tutor3.TutorSubjects.Add(new TutorSubject() { Subject = subject3, Tutor = tutor3 });

			context.SaveChanges();
		}


		private static void LoadStudents(MiTutorContext context)
		{
			University university = context
				.Universities
				.FirstOrDefault();

			Person person1 = new Person() { Name = "student_1", University = university };
			Student student1 = new Student() { Person = person1, Points = 0 };
			context.Persons.Add(person1);
			context.Students.Add(student1);

			Person person2 = new Person() { Name = "student_2", University = university };
			Student student2 = new Student() { Person = person2, Points = 0 };
			context.Persons.Add(person2);
			context.Students.Add(student2);

			Person person3 = new Person() { Name = "student_3", University = university };
			Student student3 = new Student() { Person = person3, Points = 0 };
			context.Persons.Add(person3);
			context.Students.Add(student3);

			context.SaveChanges();
		}

		
		private static void GenerateStudents(MiTutorContext context, int studentsNumber)
		{
			for (int i = 0; i < studentsNumber; i++)
			{
				Person person = new Person() { Name = $"student_{i + 1}" };
				Student student = new Student() { Person = person, Points = 0 };

				context.Persons.Add(person);
				context.Students.Add(student);
			}

			context.SaveChanges();
		}

	}
}