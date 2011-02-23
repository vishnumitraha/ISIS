﻿using System;
using FluentValidation;

namespace ISIS.Validation
{
    /// <summary>
    /// Validation rules for AssignCIPCommand
    /// </summary>
    public class ChangeCourseTitleCommandValidator : AbstractValidator<ChangeCourseTitleCommand>
    {
        public ChangeCourseTitleCommandValidator()
        {
            RuleFor(cmd => cmd.CourseId)
                .NotEqual(default(Guid))
                .WithMessage("You must specify a course");

            RuleFor(cmd => cmd.NewTitle)
                .NotEmpty()
                .WithMessage("Title is required");

        }
    }
}
