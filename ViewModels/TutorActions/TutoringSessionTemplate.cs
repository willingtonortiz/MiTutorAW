using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using MiTutor.Models;

namespace MiTutor.ViewModels.TutorActions
{
    public class TutoringSessionTemplate
    {
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public int TutorId {get; set;}
        public List<Subject> Subjects { get; set; }
        public List<Topic> Topics { get; set; }
        public int SelectedSubjectId { get; set; }
        public List<int> SelectedTopicsId {get; set;}


        public IEnumerable<SelectListItem> getSubjectsAsItems()
        {
            return new SelectList(Subjects, "SubjectId", "Name");
        }

        public IEnumerable<SelectListItem> getTopicsAsItems()
        {
            return new SelectList(Topics, "TopicId", "Name");
        }



    }


}