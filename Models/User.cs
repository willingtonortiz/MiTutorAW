using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiTutor.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Person Person { get; set; }

        public User() { }
    }
}