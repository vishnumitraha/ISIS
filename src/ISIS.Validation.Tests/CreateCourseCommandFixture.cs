﻿using System;
using FluentValidation;
using NUnit.Framework;

namespace ISIS.Validation.Tests
{
    [TestFixture]
    public class CreateCourseCommandFixture : ValidationFixture<CreateCourseCommand>
    {
        protected override AbstractValidator<CreateCourseCommand> CreateValidator()
        {
            return new CreateCourseCommandValidator();
        }

        protected override CreateCourseCommand GetValidInstance()
        {
            return new CreateCourseCommand()
                       {
                           CourseId = Guid.NewGuid(),
                           Rubric = "BIOL",
                           CourseNumber = "1234",
                           Title = "Cuttin' up frogs"
                       };
        }

        [Test]
        public void CourseId_must_not_be_default_guid()
        {
            GetFailure(new CreateCourseCommand()
            {
                CourseId = default(Guid)
            }, cmd => cmd.CourseId);
        }

        
        [Test]
        public void Rubric_must_be_4_characters_long()
        {
            GetFailure(new CreateCourseCommand()
                           {
                               Rubric = "ABC"
                           }, cmd => cmd.Rubric);
        }

        [Test]
        public void Rubric_must_contain_all_letters()
        {
            GetFailure(new CreateCourseCommand()
            {
                Rubric = "ABC1"
            }, cmd => cmd.Rubric);
        }

        [Test]
        public void Rubric_must_be_all_uppercase()
        {
            GetFailure(new CreateCourseCommand()
            {
                Rubric = "ABCd"
            }, cmd => cmd.Rubric);
        }

        [Test]
        public void Course_number_must_be_4_digits_long()
        {
            GetFailure(new CreateCourseCommand()
            {
                CourseNumber = "012"
            }, cmd => cmd.CourseNumber);
        }

        [Test]
        public void Course_number_must_be_all_digits()
        {
            GetFailure(new CreateCourseCommand()
            {
                CourseNumber = "012A"
            }, cmd => cmd.CourseNumber);
        }

        [Test]
        public void Title_cant_be_null()
        {
            GetFailure(new CreateCourseCommand()
                           {
                               Title = null
                           }, cmd => cmd.Title);
        }

        [Test]
        public void Title_cant_be_empty()
        {
            GetFailure(new CreateCourseCommand()
            {
                Title = ""
            }, cmd => cmd.Title);
        }

        [Test]
        public void Title_cant_be_over_30_characters()
        {
            GetFailure(new CreateCourseCommand()
            {
                Title = "123456789012345678901234567890!"
            }, cmd => cmd.Title);
        }

    }
}
