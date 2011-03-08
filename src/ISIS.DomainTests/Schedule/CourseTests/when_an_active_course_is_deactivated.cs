﻿using System.Collections.Generic;
using Ncqrs.Spec;
using NUnit.Framework;

namespace ISIS.Schedule.CourseTests
{
    [Specification]
    public class when_an_active_course_is_deactivated : 
        SimpleDomainFixture<DeactivateCourseCommand, CourseDeactivatedEvent>
    {

        protected override IEnumerable<object> GivenEvents()
        {
            yield return new CreditCourseCreatedEvent(EventSourceId, "BIOL", "1304");
        }

        protected override DeactivateCourseCommand WhenExecuting()
        {
            return new DeactivateCourseCommand() { CourseId = EventSourceId };
        }

        [Then]
        public void it_should_deactivate_the_course()
        {
            Assert.That(TheEvent.CourseId, Is.EqualTo(EventSourceId));
        }

    }
}
