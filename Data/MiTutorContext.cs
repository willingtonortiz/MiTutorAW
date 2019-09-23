using MiTutor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MiTutor.Data
{
	public class MiTutorContext : DbContext
	{
		public DbSet<Availability> Availabilities { get; set; }
		public DbSet<AvailabilityDay> AvailabilityDays { get; set; }
		public DbSet<Person> Persons { get; set; }
		public DbSet<Qualification> Qualifications { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<Subject> Subjects { get; set; }
		public DbSet<Topic> Topics { get; set; }
		public DbSet<Tutor> Tutors { get; set; }
		public DbSet<TutoringOffer> TutoringOffers { get; set; }
		public DbSet<TutoringSession> TutoringSessions { get; set; }
		public DbSet<University> Universities { get; set; }
		public DbSet<User> Users { get; set; }

		public MiTutorContext(DbContextOptions<MiTutorContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			//Qualification-Person relationship
			modelBuilder.Entity<Qualification>()
					.HasOne(q => q.Adresser)
					.WithMany(a => a.QualificationsReceived).OnDelete(DeleteBehavior.SetNull)
					.HasForeignKey(q => q.AdresserId).IsRequired();

			modelBuilder.Entity<Qualification>()
				   .HasOne(q => q.Adressee)
				  .WithMany(a => a.QualificationsGiven).OnDelete(DeleteBehavior.SetNull)
				  .HasForeignKey(q => q.AdresseeId).IsRequired();



			//Many to many relationshp	
			modelBuilder.Entity<StudentSubject>().HasKey(ss => new { ss.StudentId, ss.SubjectId });

			modelBuilder.Entity<StudentSubject>()
			.HasOne<Student>(ss => ss.Student)
			.WithMany(s => s.StudentSubjects)
			.HasForeignKey(ss => ss.StudentId);

			modelBuilder.Entity<StudentSubject>()
			.HasOne<Subject>(ss => ss.Subject)
			.WithMany(sub => sub.StudentSubjects)
			.HasForeignKey(ss => ss.SubjectId);



			modelBuilder.Entity<TutorSubject>().HasKey(ts => new { ts.TutorId, ts.SubjectId });

			modelBuilder.Entity<TutorSubject>()
			.HasOne<Tutor>(ts => ts.Tutor)
			.WithMany(t => t.TutorSubjects)
			.HasForeignKey(ts => ts.TutorId);

			modelBuilder.Entity<TutorSubject>()
			.HasOne<Subject>(ts => ts.Subject)
			.WithMany(t => t.TutorSubjects)
			.HasForeignKey(ts => ts.SubjectId);



			modelBuilder.Entity<StudentTutoringSession>().HasKey(sts => new { sts.StudentId, sts.TutoringSessionId });

			modelBuilder.Entity<StudentTutoringSession>()
			.HasOne<Student>(sts => sts.Student)
			.WithMany(s => s.StudentTutoringSessions)
			.HasForeignKey(sts => sts.StudentId);

			modelBuilder.Entity<StudentTutoringSession>()
			.HasOne<TutoringSession>(sts => sts.TutoringSession)
			.WithMany(ts => ts.StudentTutoringSessions)
			.HasForeignKey(sts => sts.TutoringSessionId);



			modelBuilder.Entity<TopicTutoringOffer>().HasKey(tto => new { tto.TopicId, tto.TutoringOfferId });

			modelBuilder.Entity<TopicTutoringOffer>()
			.HasOne<Topic>(tto => tto.Topic)
			.WithMany(t => t.TopicTutoringOffers)
			.HasForeignKey(tto => tto.TopicId);

			modelBuilder.Entity<TopicTutoringOffer>()
			.HasOne<TutoringOffer>(tto => tto.TutoringOffer)
			.WithMany(t => t.TopicTutoringOffers)
			.HasForeignKey(tto => tto.TutoringOfferId);



			modelBuilder.Entity<TopicTutoringSession>().HasKey(tts => new { tts.TopicId, tts.TutoringSessionId });

			modelBuilder.Entity<TopicTutoringSession>()
			.HasOne<Topic>(tts => tts.Topic)
			.WithMany(t => t.TopicTutoringSessions)
			.HasForeignKey(tts => tts.TopicId);

			modelBuilder.Entity<TopicTutoringSession>()
			.HasOne<TutoringSession>(tts => tts.TutoringSession)
			.WithMany(t => t.TopicTutoringSessions)
			.HasForeignKey(tts => tts.TutoringSessionId);




			modelBuilder.Entity<Subject>().ToTable("Subject");
			modelBuilder.Entity<Topic>().ToTable("Topic");
			modelBuilder.Entity<Availability>().ToTable("Availability");
			modelBuilder.Entity<AvailabilityDay>().ToTable("AvailabilityDay");
			modelBuilder.Entity<Person>().ToTable("Person");
			modelBuilder.Entity<Qualification>().ToTable("Qualification");
			modelBuilder.Entity<Tutor>().ToTable("Tutor");
			modelBuilder.Entity<Student>().ToTable("Student");
			modelBuilder.Entity<TutoringOffer>().ToTable("TutoringOffer");
			modelBuilder.Entity<TutoringSession>().ToTable("TutoringSession");
			modelBuilder.Entity<University>().ToTable("University");
			modelBuilder.Entity<User>().ToTable("User");
		}
	}


}