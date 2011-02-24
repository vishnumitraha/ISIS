﻿using System;

namespace ISIS
{
    public class CourseLongTitleChangedEvent 
    {

        public CourseLongTitleChangedEvent(Guid courseId, string longTitle)
        {
            CourseId = courseId;
            LongTitle = longTitle;
        }

        public Guid CourseId { get; private set; }
        public string LongTitle { get; private set; }
    }
}