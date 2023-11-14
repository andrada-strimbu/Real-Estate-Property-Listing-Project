using Infrastructure;
using MediatR;
using Real_estate.Application;
using Real_estate.Application.Features.Properties.Commands.CreateProperty;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddInfrastrutureToDI(builder.Configuration);
builder.Services.AddApplicationServices();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(typeof(Program).Assembly);
builder.Services.AddTransient<IRequestHandler<CreatePropertyCommand, CreatePropertyCommandResponse>, CreatePropertyCommandHandler>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();