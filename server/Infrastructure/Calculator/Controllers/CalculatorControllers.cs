using Application.Calculator.Messages.Commands;
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
    public async Task<IActionResult> Sum([FromBody] SumCommand command)
             => Ok(await _mediator.Send(command));

    [HttpPost]
    [Route("divide")]
    public async Task<IActionResult> Sum([FromBody] DivisionCommand command)
         => Ok(await _mediator.Send(command));

    [HttpPost]
    [Route("multiply")]
    public async Task<IActionResult> Sum([FromBody] MultiplicationCommand command)
         => Ok(await _mediator.Send(command));

    [HttpPost]
    [Route("subtract")]
    public async Task<IActionResult> Sum([FromBody] SubtractionCommand command)
         => Ok(await _mediator.Send(command));

}