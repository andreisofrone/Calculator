using Application.Todos.Messages.Commands;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[EnableCors("AnyPolicy")]
[Route("api/calculator")]
public class CalculatorControllers : ControllerBase
{
    private readonly IMediator _mediator;

    public CalculatorControllers(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Route("sum")]
    public async Task<IActionResult> Sum([FromRoute] SumCommand command)
    {
        await _mediator.Send(command);

        return Ok(command);
    }
}