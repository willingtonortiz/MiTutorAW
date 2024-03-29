using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiTutor.Models
{
    public class Topic
    {
        [Key]
        public int TopicId { get; set; }
        public string Name { get; set; }
    
        public int SubjectId { get; set; }

        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
        public List<TopicTutoringOffer> TopicTutoringOffers {get; set;}
        public List<TopicTutoringSession> TopicTutoringSessions { get; set; }
    }
}