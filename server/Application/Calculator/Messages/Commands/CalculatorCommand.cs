namespace Application.Calculator.Messages.Commands
{
    public class CalculatorCommand
            : ICommand<double>
    {
        public double FirstNumber { get; set; }

        public double SecondNumber { get; set; }
    }
}
