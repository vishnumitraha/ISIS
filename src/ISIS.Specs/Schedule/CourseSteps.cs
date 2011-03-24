﻿using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ISIS.Schedule
{
    [Binding]
    public class CourseSteps 
    {

        [Given(@"I have created an (.*) course ([A-Z]{4}) (\d{1}[1-9]\d{2}) (.*)")]
        [Given(@"I have created a (.*) course ([A-Z]{4}) (\d{1}[1-9]\d{2}) (.*)")]
        public void GivenIHaveCreatedACreditCourse(
            string courseTypeString,
            string rubric,
            string number,
            string title)
        {
            DomainHelper.GivenEvent(new CreditCourseCreatedEvent(
                                        DomainHelper.GetEventSourceId(),
                                        rubric,
                                        number));
            DomainHelper.GivenEvent(new CourseTitleChangedEvent(
                                        DomainHelper.GetEventSourceId(),
                                        title));
            DomainHelper.GivenEvent(new CourseLongTitleChangedEvent(
                                        DomainHelper.GetEventSourceId(),
                                        title));
            var courseTypes = CourseTypeSteps.ParseCourseTypes(courseTypeString);
            foreach (var courseType in courseTypes)
                DomainHelper.GivenEvent(new CourseTypeAddedToCourseEvent(
                                            DomainHelper.GetEventSourceId(),
                                            courseType,
                                            courseTypes));
        }

        [Given(@"I have created a (.*) course ([A-Z]{4}) (\d{1}0\d{2}) (.*)")]
        public void GivenIHaveCreatedContinuingEducationCourse(
            string creditTypeString,
            string rubric,
            string number,
            string title)
        {
            var creditType = CourseCreditTypeSteps.ParseCreditType(creditTypeString);

            DomainHelper.GivenEvent(new ContinuingEducationCourseCreatedEvent(
                                        DomainHelper.GetEventSourceId(),
                                        rubric,
                                        number));
            DomainHelper.GivenEvent(new CourseTitleChangedEvent(
                                        DomainHelper.GetEventSourceId(),
                                        title));
            DomainHelper.GivenEvent(new CourseLongTitleChangedEvent(
                                        DomainHelper.GetEventSourceId(),
                                        title));
            DomainHelper.GivenEvent(new CourseCreditTypeChangedEvent(
                                        DomainHelper.GetEventSourceId(),
                                        creditType));
            var courseType = CourseTypes.CE;
            switch (creditType)
            {
                case CreditTypes.ContractTrainingFunded:
                case CreditTypes.GrantFunded:
                case CreditTypes.WorkforceFunded:
                    courseType = CourseTypes.CWECM;
                    break;
            }
            DomainHelper.GivenEvent(new CourseTypeAddedToCourseEvent(
                                        DomainHelper.GetEventSourceId(),
                                        courseType,
                                        new[] {courseType}));
        }
        
        [When(@"I create an (.*) course ([A-Z]{4}) (\d{1}[1-9]\d{2}) (.*)")]
        [When(@"I create a (.*) course ([A-Z]{4}) (\d{1}[1-9]\d{2}) (.*)")]
        public void WhenICreateACreditCourse(
            string courseTypeString,
            string rubric,
            string number,
            string title)
        {
            var courseTypes = CourseTypeSteps.ParseCourseTypes(courseTypeString);
            var cmd = new CreateCreditCourseCommand()
                          {
                              CourseId = DomainHelper.GetEventSourceId(),
                              Rubric = rubric,
                              CourseNumber = number,
                              Title = title,
                              Types = courseTypes
                          };
            DomainHelper.WhenExecuting(cmd);
        }

        [When(@"I create a course ([A-Z]{4}) (\d{4}) (.*) without a course type")]
        public void WhenICreateACourseWithoutACourseType(
            string rubric,
            string number,
            string title)
        {
            var cmd = new CreateCreditCourseCommand()
                          {
                              CourseId = Guid.NewGuid(),
                              Rubric = rubric,
                              CourseNumber = number,
                              Title = title,
                              Types = new CourseTypes[0]
                          };
            DomainHelper.WhenExecuting(cmd);
        }

        [When(@"I create a (.*) course ([A-Z]{4}) (\d{1}0\d{2}) (.*)")]
        public void WhenICreateAContinuingEducationCourse(
            string creditTypeString,
            string rubric,
            string number,
            string title)
        {
            var creditType = CourseCreditTypeSteps.ParseCreditType(creditTypeString);
            var cmd = new CreateContinuingEducationCourseCommand()
                          {
                              CourseId = DomainHelper.GetEventSourceId(),
                              Rubric = rubric,
                              CourseNumber = number,
                              Title = title,
                              Type = creditType
                          };
            DomainHelper.WhenExecuting(cmd);
        }


        [Then(@"the credit course is created")]
        public void ThenTheCreditCourseShouldBeCreated()
        {
            var cmd = DomainHelper.GetCommand();
            var e = DomainHelper.GetEvent<CreditCourseCreatedEvent>();
            Assert.That(e.CourseId, Is.EqualTo(cmd.CourseId));
        }

        [Then(@"the CE course is created")]
        public void ThenTheCECourseShouldBeCreated()
        {
            var cmd = DomainHelper.GetCommand();
            var e = DomainHelper.GetEvent<ContinuingEducationCourseCreatedEvent>();
            Assert.That(e.CourseId, Is.EqualTo(cmd.CourseId));
        }

        [Then(@"the course rubric is (.*)")]
        public void ThenTheCourseRubricShouldBe(string rubric)
        {
            var e = (dynamic) DomainHelper.GetEvent<CreditCourseCreatedEvent>()
                        ?? DomainHelper.GetEvent<ContinuingEducationCourseCreatedEvent>();
            Assert.That(e.Rubric, Is.EqualTo(rubric));
        }

        [Then(@"the course number is (.*)")]
        public void ThenTheCourseNumberShouldBe(string number)
        {
            var e = (dynamic)DomainHelper.GetEvent<CreditCourseCreatedEvent>()
                        ?? DomainHelper.GetEvent<ContinuingEducationCourseCreatedEvent>();
            Assert.That(e.Number, Is.EqualTo(number));
        }

        [Then(@"the course is active")]
        public void ThenTheCourseShouldBeActive()
        {
            var e = DomainHelper.GetEvent<CourseActivatedEvent>();
            Assert.That(e, Is.Not.Null);
        }





    }
}
