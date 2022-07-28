using Application.Calculator.Messages.Commands;
using FluentValidation;

namespace Application.Calculator.Validation
{
    public sealed class MultiplicationCommandValidator
      : AbstractValidator<MultiplicationCommand>
    {
        public MultiplicationCommandValidator()
        {
            RuleFor(cp => cp.FirstNumber)
                .NotNull();

            RuleFor(cp => cp.SecondNumber)
                .NotNull();
        }
    }
}