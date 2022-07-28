using Application.Calculator.Messages.Commands;
using FluentValidation;

namespace Application.Calculator.Validation
{
    public sealed class SumCommandValidator
         : AbstractValidator<SumCommand>
    {
        public SumCommandValidator()
        {
            RuleFor(cp => cp.FirstNumber)
                .NotEmpty();

            RuleFor(cp => cp.SecondNumber)
                .NotEmpty();
        }
    }
}
