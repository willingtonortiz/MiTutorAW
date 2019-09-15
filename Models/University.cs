using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MiTutor.Models
{
    public class University
    {
        [Key]
        public int UniversityId { get; set; }

        public string Name { get; set; }


        public List<Person> Persons { get; set; }
    }
}