using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MiTutor.Models

{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Semester { get; set; }


        [ForeignKey("UniversityId")]
        public int UniversityId { get; set; }
        public University University { get; set; }

        public Student Student { get; set; }

        public Tutor Tutor { get; set; }

        public User User { get; set; }

        public List<Qualification> Qualifications { get; set; }
    }
}