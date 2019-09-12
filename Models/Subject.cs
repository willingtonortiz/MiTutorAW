using System;
using System.Collections.Generic;

namespace MiTutor.Models
{
    public class Subject 
    {
        public int SubjectId { get; set; }
        public string Name {get; set;}
        public List<Topic> Topics {get; set;}
        public Subject() : base() { }

    }
}