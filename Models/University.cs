using System;
using System.Collections.Generic;

namespace MiTutor.Models
{
    public class University
    {
        public int UniversityId { get; set; }
        public List<Person> Persons {get; set;}
        public string Name { get; set; }
        public University() { }


    }
}