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
    }
}