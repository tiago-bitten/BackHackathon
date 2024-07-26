using BackHackathon.Api.Filters;
using BackHackathon.Application.Commands.EfetuarLoginSandbox;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblies([
        typeof(EfetuarLoginSandboxCommand).Assembly
    ]);
});

builder.Services.AddControllers(cfg =>
{
    cfg.Filters.Add<ApiBaseResponseFilter>();
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();