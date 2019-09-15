using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiTutor.Models
{
    public class Qualification
    {
        [Key]
        public int QualificationId { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }


        public RollType AdresserRole { get; set; }
        [ForeignKey("AdresserId")]
        public int AdresserId { get; set; }
        public Person Adresser { get; set; }


        [ForeignKey("AdresseeId")]
        public int AdresseeId { get; set; }
        public Person Adressee { get; set; }


        [ForeignKey("TutoringSession")]
        public int TutoringSessionId { get; set; }
        public TutoringSession TutoringSession { get; set; }
    }
}