﻿// <auto-generated />
using System;
using MiTutor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MiTutor.Migrations
{
    [DbContext(typeof(MiTutorContext))]
    [Migration("20190912220900_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MiTutor.Models.Availability", b =>
                {
                    b.Property<int>("AvailabilityId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("AvailabilityId");

                    b.ToTable("Availability");
                });

            modelBuilder.Entity("MiTutor.Models.AvailabilityDay", b =>
                {
                    b.Property<int>("AvailabilityDayId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AvailabilityId");

                    b.Property<string>("Day");

                    b.Property<DateTime>("EndTime");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("AvailabilityDayId");

                    b.HasIndex("AvailabilityId");

                    b.ToTable("AvailabilityDay");
                });

            modelBuilder.Entity("MiTutor.Models.Person", b =>
                {
                    b.Property<int>("PersonId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.Property<int>("Semester");

                    b.Property<int?>("UniversityId");

                    b.HasKey("PersonId");

                    b.HasIndex("UniversityId");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("MiTutor.Models.Qualification", b =>
                {
                    b.Property<int>("QualificationId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AdresseePersonId");

                    b.Property<int?>("AdresserPersonId");

                    b.Property<string>("Comment");

                    b.Property<int>("Rate");

                    b.Property<int?>("StudentPersonId");

                    b.Property<int?>("TutorPersonId");

                    b.Property<int?>("TutoringSessionTutoringId");

                    b.HasKey("QualificationId");

                    b.HasIndex("AdresseePersonId");

                    b.HasIndex("AdresserPersonId");

                    b.HasIndex("StudentPersonId");

                    b.HasIndex("TutorPersonId");

                    b.HasIndex("TutoringSessionTutoringId");

                    b.ToTable("Qualification");
                });

            modelBuilder.Entity("MiTutor.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("StudentPersonId");

                    b.Property<int?>("TutorPersonId");

                    b.HasKey("SubjectId");

                    b.HasIndex("StudentPersonId");

                    b.HasIndex("TutorPersonId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("MiTutor.Models.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("SubjectId");

                    b.Property<int?>("TutoringId");

                    b.HasKey("TopicId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TutoringId");

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("MiTutor.Models.Tutoring", b =>
                {
                    b.Property<int>("TutoringId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Capacity");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Place");

                    b.Property<int?>("SubjectId");

                    b.HasKey("TutoringId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Tutoring");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Tutoring");
                });

            modelBuilder.Entity("MiTutor.Models.University", b =>
                {
                    b.Property<int>("UniversityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("UniversityId");

                    b.ToTable("University");
                });

            modelBuilder.Entity("MiTutor.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MiTutor.Models.Student", b =>
                {
                    b.HasBaseType("MiTutor.Models.Person");

                    b.Property<int>("Points");

                    b.Property<int?>("TutoringSessionTutoringId");

                    b.HasIndex("TutoringSessionTutoringId");

                    b.ToTable("Student");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("MiTutor.Models.Tutor", b =>
                {
                    b.HasBaseType("MiTutor.Models.Person");

                    b.Property<int?>("AvailabilityId");

                    b.Property<string>("Description");

                    b.Property<int>("Points")
                        .HasColumnName("Tutor_Points");

                    b.HasIndex("AvailabilityId");

                    b.ToTable("Tutor");

                    b.HasDiscriminator().HasValue("Tutor");
                });

            modelBuilder.Entity("MiTutor.Models.TutoringOffer", b =>
                {
                    b.HasBaseType("MiTutor.Models.Tutoring");

                    b.Property<string>("Description");

                    b.Property<int?>("TutorPersonId");

                    b.HasIndex("TutorPersonId");

                    b.ToTable("TutoringOffer");

                    b.HasDiscriminator().HasValue("TutoringOffer");
                });

            modelBuilder.Entity("MiTutor.Models.TutoringSession", b =>
                {
                    b.HasBaseType("MiTutor.Models.Tutoring");

                    b.Property<int?>("TutorPersonId")
                        .HasColumnName("TutoringSession_TutorPersonId");

                    b.Property<int?>("TutoringOfferTutoringId");

                    b.HasIndex("TutorPersonId");

                    b.HasIndex("TutoringOfferTutoringId");

                    b.ToTable("TutoringSession");

                    b.HasDiscriminator().HasValue("TutoringSession");
                });

            modelBuilder.Entity("MiTutor.Models.AvailabilityDay", b =>
                {
                    b.HasOne("MiTutor.Models.Availability")
                        .WithMany("AvailabilityDays")
                        .HasForeignKey("AvailabilityId");
                });

            modelBuilder.Entity("MiTutor.Models.Person", b =>
                {
                    b.HasOne("MiTutor.Models.User", "User")
                        .WithOne("Person")
                        .HasForeignKey("MiTutor.Models.Person", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MiTutor.Models.University", "University")
                        .WithMany("Persons")
                        .HasForeignKey("UniversityId");
                });

            modelBuilder.Entity("MiTutor.Models.Qualification", b =>
                {
                    b.HasOne("MiTutor.Models.Person", "Adressee")
                        .WithMany()
                        .HasForeignKey("AdresseePersonId");

                    b.HasOne("MiTutor.Models.Person", "Adresser")
                        .WithMany()
                        .HasForeignKey("AdresserPersonId");

                    b.HasOne("MiTutor.Models.Student")
                        .WithMany("StudentQualification")
                        .HasForeignKey("StudentPersonId");

                    b.HasOne("MiTutor.Models.Tutor")
                        .WithMany("TutorQualification")
                        .HasForeignKey("TutorPersonId");

                    b.HasOne("MiTutor.Models.TutoringSession")
                        .WithMany("Qualifications")
                        .HasForeignKey("TutoringSessionTutoringId");
                });

            modelBuilder.Entity("MiTutor.Models.Subject", b =>
                {
                    b.HasOne("MiTutor.Models.Student")
                        .WithMany("FavoriteSubjects")
                        .HasForeignKey("StudentPersonId");

                    b.HasOne("MiTutor.Models.Tutor")
                        .WithMany("Subjects")
                        .HasForeignKey("TutorPersonId");
                });

            modelBuilder.Entity("MiTutor.Models.Topic", b =>
                {
                    b.HasOne("MiTutor.Models.Subject")
                        .WithMany("Topics")
                        .HasForeignKey("SubjectId");

                    b.HasOne("MiTutor.Models.Tutoring")
                        .WithMany("Topics")
                        .HasForeignKey("TutoringId");
                });

            modelBuilder.Entity("MiTutor.Models.Tutoring", b =>
                {
                    b.HasOne("MiTutor.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("MiTutor.Models.Student", b =>
                {
                    b.HasOne("MiTutor.Models.TutoringSession")
                        .WithMany("Students")
                        .HasForeignKey("TutoringSessionTutoringId");
                });

            modelBuilder.Entity("MiTutor.Models.Tutor", b =>
                {
                    b.HasOne("MiTutor.Models.Availability", "Availability")
                        .WithMany()
                        .HasForeignKey("AvailabilityId");
                });

            modelBuilder.Entity("MiTutor.Models.TutoringOffer", b =>
                {
                    b.HasOne("MiTutor.Models.Tutor")
                        .WithMany("TutoringOffers")
                        .HasForeignKey("TutorPersonId");
                });

            modelBuilder.Entity("MiTutor.Models.TutoringSession", b =>
                {
                    b.HasOne("MiTutor.Models.Tutor")
                        .WithMany("TutoringSessions")
                        .HasForeignKey("TutorPersonId");

                    b.HasOne("MiTutor.Models.TutoringOffer")
                        .WithMany("TutoringSessions")
                        .HasForeignKey("TutoringOfferTutoringId");
                });
#pragma warning restore 612, 618
        }
    }
}