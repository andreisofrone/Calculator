using Application.Todos.Messages.Commands;

namespace Application.Calculator.Handlers
{
    public class SubtractionCommandHandler
        : ICommandHandler<SubtractionCommand, double>
    {
        public Task<double> Handle(SubtractionCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(request.FirstNumber - request.SecondNumber);
        }
    }
}
