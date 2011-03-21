﻿using System;
using System.Collections.Generic;
using System.Linq;
using Ncqrs.Spec;
using NUnit.Framework;

namespace ISIS.Schedule.CourseTests
{
    [Specification]
    public class when_a_course_is_created : 
        DomainFixture<CreateCreditCourseCommand>
    {

        private Guid CourseId = Guid.NewGuid();
        private const string Rubric = "BIOL";
        private const string CourseNumber = "1301";
        private const string Title = "Introductory Biology";


        protected override IEnumerable<object> GivenEvents()
        {
            return new object[0];
        }

        protected override CreateCreditCourseCommand WhenExecuting()
        {
            return new CreateCreditCourseCommand()
                       {
                           CourseId = CourseId,
                           Rubric = Rubric,
                           CourseNumber = CourseNumber,
                           Title = Title,
                           Types = new[] {CourseTypes.ACAD, CourseTypes.NF}
                       };
        }

        [Then]
        public void it_should_not_throw()
        {
            Assert.That(CaughtException, Is.Null);
        }


        [Then]
        public void it_should_do_no_more()
        {
            Assert.That(PublishedEvents.Count(), Is.EqualTo(6));
        }

        [Then]
        public void then_it_should_create_a_new_CourseCreatedEvent()
        {
            var TheEvent = PublishedEvents.Select(pe => pe.Payload)
                .OfType<CreditCourseCreatedEvent>().Single();
            Assert.That(TheEvent.CourseId, Is.EqualTo(CourseId));
            Assert.That(TheEvent.Rubric, Is.EqualTo(Rubric));
            Assert.That(TheEvent.Number, Is.EqualTo(CourseNumber));
        }

        [Then]
        public void then_it_should_create_a_new_CourseTitleChangedEvent()
        {
            var TheEvent = PublishedEvents.Select(pe => pe.Payload)
                .OfType<CourseTitleChangedEvent>().Single();
            Assert.That(TheEvent.CourseId, Is.Not.EqualTo(default(Guid)));
            Assert.That(TheEvent.Title, Is.EqualTo(Title));
        }

        [Then]
        public void then_it_should_create_a_new_CourseLongTitleChangedEvent()
        {
            var TheEvent = PublishedEvents.Select(pe => pe.Payload)
                .OfType<CourseLongTitleChangedEvent>().Single();
            Assert.That(TheEvent.CourseId, Is.Not.EqualTo(default(Guid)));
            Assert.That(TheEvent.LongTitle, Is.EqualTo(Title));
        }

        [Then]
        public void then_it_should_create_a_new_CourseActivatedEvent()
        {
            var TheEvent = PublishedEvents.Select(pe => pe.Payload)
                .OfType<CourseActivatedEvent>().Single();
            Assert.That(TheEvent.CourseId, Is.Not.EqualTo(default(Guid)));
        }

        [Then]
        public void then_it_should_create_CourseTypeAddedEvents()
        {
            var events = PublishedEvents.Select(pe => pe.Payload)
                .OfType<CourseTypeAddedToCourseEvent>();
            var courseTypes = events.Select(e => e.TypeAdded);
            Assert.That(events.Count(), Is.EqualTo(2));
            Assert.That(courseTypes, Contains.Item(CourseTypes.ACAD));
            Assert.That(courseTypes, Contains.Item(CourseTypes.NF));
        }

        [Then]
        public void then_the_last_CourseTypeAddedEvent_should_contain_all_course_types()
        {
            var lastEvent = PublishedEvents.Select(pe => pe.Payload)
                .OfType<CourseTypeAddedToCourseEvent>()
                .Last();
            Assert.That(lastEvent.CurrentTypes.Count(), Is.EqualTo(2));
            Assert.That(lastEvent.CurrentTypes, Contains.Item(CourseTypes.ACAD));
            Assert.That(lastEvent.CurrentTypes, Contains.Item(CourseTypes.NF));
        }

    }
}