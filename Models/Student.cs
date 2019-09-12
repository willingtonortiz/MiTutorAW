using System;
using System.Collections.Generic;

namespace MiTutor.Models
{
    public class Student : Person
    {
        public List<Subject> FavoriteSubjects {get; set;}
        public List<Qualification> StudentQualification {get; set;}
        public int Points { get; set; }
        public Student() : base() { }

    }
}