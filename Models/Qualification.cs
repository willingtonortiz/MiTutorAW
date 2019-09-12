using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiTutor.Models
{
    public class Qualification
    {
        public int QualificationId { get; set; }
        public Person Adresser {get; set;}
        public Person Adressee {get; set;}
        public int Rate {get; set;}
        public string Comment {get; set;}

        public Qualification() {}

    }
}