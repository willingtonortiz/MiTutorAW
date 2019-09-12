using MiTutor.Models;
using Microsoft.EntityFrameworkCore;

namespace MiTutor.Data
{
    public class MiTutorContext : DbContext
    {
        
        public DbSet<Tutor> Tutors { get; set; }
       
        public MiTutorContext(DbContextOptions<MiTutorContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Availability>().ToTable("Availability");
            modelBuilder.Entity<AvailabilityDay>().ToTable("AvailabilityDay");
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Qualification>().ToTable("Qualification");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Subject>().ToTable("Subject");
            modelBuilder.Entity<Topic>().ToTable("Topic");
            modelBuilder.Entity<Tutor>().ToTable("Tutor");
            modelBuilder.Entity<Tutoring>().ToTable("Tutoring");
            modelBuilder.Entity<TutoringOffer>().ToTable("TutoringOffer");
            modelBuilder.Entity<TutoringSession>().ToTable("TutoringSession");
            modelBuilder.Entity<University>().ToTable("University");
            modelBuilder.Entity<User>().ToTable("User");
        }



    }

}