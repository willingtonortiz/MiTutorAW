using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiTutor.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string Name {get; set;}
        public Topic() { }

    }
}