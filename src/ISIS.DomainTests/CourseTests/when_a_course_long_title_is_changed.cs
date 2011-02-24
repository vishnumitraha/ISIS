﻿using System.Collections.Generic;
using NUnit.Framework;

namespace ISIS.DomainTests.CourseTests
{
    [TestFixture]
    public class when_a_course_long_title_is_changed : 
        SimpleCommandFixture<ChangeCourseLongTitleCommand, Course, CourseLongTitleChangedEvent>
    {

        private const string Rubric = "BIOL";
        private const string CourseNumber = "1301";
        private const string NewLongTitle = "My very very very very very very very very very very long introduction to biology title goes here";

        protected override IEnumerable<object> Given()
        {
            yield return new CourseCreatedEvent(EventSourceId, Rubric, CourseNumber);
        }

        protected override ChangeCourseLongTitleCommand WhenExecutingCommand()
        {
            return new ChangeCourseLongTitleCommand()
                       {
                           CourseId = EventSourceId,
                           NewLongTitle = NewLongTitle
                       };
        }

        [Test]
        public void then_it_should_create_a_new_CourseLongTitleChangedEvent()
        {
            Assert.That(TheEvent.CourseId, Is.EqualTo(EventSourceId));
            Assert.That(TheEvent.LongTitle, Is.EqualTo(NewLongTitle));
        }


    }
}
