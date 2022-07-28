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
                .NotEmpty();

            RuleFor(cp => cp.SecondNumber)
                .NotEmpty();
        }
    }
}
