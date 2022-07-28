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
                .NotNull();

            RuleFor(cp => cp.SecondNumber)
                .NotNull();
        }
    }
}
