﻿using Application.Calculator.Messages.Commands;
using FluentValidation;

namespace Application.Calculator.Validation
{
    public sealed class MultiplicationCommandValidator
      : AbstractValidator<MultiplicationCommand>
    {
        public MultiplicationCommandValidator()
        {
            RuleFor(cp => cp.FirstNumber)
                .NotEmpty();

            RuleFor(cp => cp.SecondNumber)
                .NotEmpty();
        }
    }
}