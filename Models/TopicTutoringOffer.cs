using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MiTutor.Models
{
    public class TopicTutoringOffer
    {
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public int TutoringOfferId { get; set; }
        public TutoringOffer TutoringOffer {get; set; }

    }
}