﻿using System.Collections.Generic;
using NUnit.Framework;

namespace ISIS.DomainTests.CourseTests
{
    [TestFixture]
    public class when_a_CIP_is_assigned : 
        SimpleCommandFixture<AssignCIPCommand, Course, CourseCIPAssignedEvent>
    {

        private const string CIP = "123456";


        protected override IEnumerable<object> Given()
        {
            yield return new CourseCreatedEvent()
                             {
                                 Rubric = "BIOL",
                                 Number = "2302",
                                 Title = "Anatomy & Physiology II"
                             };
        }

        protected override AssignCIPCommand WhenExecutingCommand()
        {
            return new AssignCIPCommand()
                       {
                           CourseId = EventSourceId,
                           CIP = CIP
                       };
        }

        [Test]
        public void then_it_should_create_a_new_CourseCIPAssignedEvent()
        {
            Assert.That(TheEvent.CIP, Is.EqualTo(CIP));
        }


    }
}
