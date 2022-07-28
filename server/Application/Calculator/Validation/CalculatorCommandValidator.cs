using Application.Calculator.Messages.Commands;
using FluentValidation;

namespace Application.Calculator.Validation
{
    public sealed class CalculatorCommandValidator
         : AbstractValidator<CalculatorCommand>
    {
        public CalculatorCommandValidator()
        {
            RuleFor(cp => cp.FirstNumber)
                .NotEmpty();

            RuleFor(cp => cp.SecondNumber)
                .NotEmpty();
        }
    }
}
