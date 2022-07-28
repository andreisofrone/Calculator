using Application.Calculator.Messages.Commands;

namespace Application.Calculator.Handlers
{
    public class SumCommandHandler
        : ICommandHandler<SumCommand, double>
    {
        public Task<double> Handle(SumCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(request.FirstNumber + request.SecondNumber);
        }
    }
}
