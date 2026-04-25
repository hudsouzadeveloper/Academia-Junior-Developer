using ASP.NETWebApplication1.Domain.Interfaces;
using ASP.NETWebApplication1.Domain.Services;
using ASP.NETWebApplication1.DTOs;
using Microsoft.Extensions.DependencyInjection;
using System.Net.WebSockets;

var builder = WebApplication.CreateBuilder(args);

// DI
builder.Services.AddScoped<IDivisionService, DivisionService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("AllowAll");

// Configure the HTTP request pipeline.
/* if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}*/

app.MapPost("/Division", (DivisionRequestDto req, IDivisionService service) =>
{
    try
    {
        var result = service.GetHighest(req.A, req.B);

        var res = new DivisionResponseDto
        {
            A = req.A,
            B = req.B,
            ResultAOverB = result.Result1,
            ResultBOverA = result.Result2,
            Max = result.Max,
            Winner = result.Winner
        };

        return Results.Ok(res);
    }
    catch (Exception ex)
    {
        return Results.BadRequest(new ErrorResponseDto
        {
            Message = ex.Message,
            Code = "DIVISION_ERROR"
        });
    }
});

// app.UseHttpsRedirection();

// app.UseAuthorization();

// app.MapControllers();

app.Run();
