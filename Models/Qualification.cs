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


        public int AdresserId { get; set; }

        [ForeignKey("AdresserId")]
        public Person Adresser { get; set; }


        public int AdresseeId { get; set; }

        [ForeignKey("AdresseeId")]
        public Person Adressee { get; set; }


       
        public int TutoringSessionId { get; set; }

        [ForeignKey("TutoringSessionId")]
        public TutoringSession TutoringSession { get; set; }
    }
}