using Application.Common;
//using FluentValidation.AspNetCore;
using Infrastructure;
using MediatR;
using Todo.Middlewares;
using Todo.Pipeline;

var builder = WebApplication.CreateBuilder(args);
var assemblies = new[] { typeof(IApplication).Assembly };


builder.Services.AddMediatR(assemblies);
builder.Services.AddFluentValidation(assemblies);
builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

//builder.Services.AddControllers().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<AnotherValidationClass>());

builder.Services.AddMvc();
builder.Services.AddAutoMapper(typeof(IInfrastructure).Assembly);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AnyPolicy", policy =>
      policy
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApiDemo v1");
        c.RoutePrefix = "swagger";
    });
}

//app.UseMiddleware<GeneralExceptionHandlerMiddleware>();
app.UseMiddleware<FluentValidationExceptionHandlerMiddleware>();

app.UseCors("AnyPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
