﻿using Application.Calculator.Messages.Commands;
using FluentValidation;

namespace Application.Calculator.Validation
{
    public sealed class SubtractionCommandValidator
      : AbstractValidator<SubtractionCommand>
    {
        public SubtractionCommandValidator()
        {
            RuleFor(cp => cp.FirstNumber)
                .NotEmpty();

            RuleFor(cp => cp.SecondNumber)
                .NotEmpty();
        }
    }
}