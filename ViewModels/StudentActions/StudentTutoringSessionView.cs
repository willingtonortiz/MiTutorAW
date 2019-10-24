using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using MiTutor.Models;

namespace MiTutor.ViewModels.StudentActions
{
    public class StudentTutoringSessionView
    {
        public TutoringSession TutoringSession {get; set;}
        public int StudentId {get; set;}
        public bool Confirmed {get; set;}

    }
}