using Application.Calculator.Messages.Commands;

namespace Application.Calculator.Handlers
{
    public class MultiplicationCommandHandler
        : ICommandHandler<MultiplicationCommand, double>
    {
        public Task<double> Handle(MultiplicationCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(request.FirstNumber * request.SecondNumber);
        }
    }
}
