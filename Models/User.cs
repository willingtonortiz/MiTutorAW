using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiTutor.Models
{
    public class User
    {
        [Key]
        [ForeignKey("PersonId")]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        public Person Person { get; set; }
    }
}