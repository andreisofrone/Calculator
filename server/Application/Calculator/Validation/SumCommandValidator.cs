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
                .NotNull()
                .GreaterThanOrEqualTo(0);

            RuleFor(cp => cp.SecondNumber)
                .NotNull()
                .GreaterThanOrEqualTo(0);
        }
    }
}
