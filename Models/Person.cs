using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace MiTutor.Models

{
    public class Person
    { 
        [ForeignKey("User")]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Semester { get; set; }
        public University University { get; set; }    
        public User User { get; set; }
        public Person() { }

    }
}