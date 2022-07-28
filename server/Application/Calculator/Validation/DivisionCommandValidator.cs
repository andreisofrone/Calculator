using Application.Calculator.Messages.Commands;
using FluentValidation;

namespace Application.Calculator.Validation
{
    public sealed class DivisionCommandValidator
       : AbstractValidator<DivisionCommand>
    {
        public DivisionCommandValidator()
        {
            RuleFor(cp => cp.FirstNumber)
                .NotNull();

            RuleFor(cp => cp.SecondNumber)
                .NotNull();
        }
    }
}
