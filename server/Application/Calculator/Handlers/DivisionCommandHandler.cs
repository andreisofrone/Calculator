using Application.Todos.Messages.Commands;

namespace Application.Calculator.Handlers
{
    public class DivisionCommandHandler
        : ICommandHandler<DivisionCommand, double>
    {
        public Task<double> Handle(DivisionCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(request.FirstNumber / request.SecondNumber);
        }
    }
}
