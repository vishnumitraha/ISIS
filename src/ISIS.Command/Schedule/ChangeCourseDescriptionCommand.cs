﻿using System;
using System.ComponentModel.DataAnnotations;
using Ncqrs.Commanding;

namespace ISIS.Schedule
{
    public class ChangeCourseDescriptionCommand : CommandBase
    {

        public Guid CourseId { get;  set; }

        [Display(Name = "New Description")]
        public string NewDescription { get;  set; }
    }
}