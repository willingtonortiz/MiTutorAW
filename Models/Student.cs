using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiTutor.Models
{
    public class Student
    {
        [Key]
        [ForeignKey("Person")]
        public int StudentId { get; set; }
        public int Points { get; set; }
        public Person Person { get; set; }
        public List<StudentSubject> StudentSubjects { get; set; }
        public List<StudentTutoringSession> StudentTutoringSessions { get; set; }


    }
}