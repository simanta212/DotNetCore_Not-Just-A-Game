global using NotJustAGame.Models;
using Serilog;
using Serilog.Events;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvc();
builder.Host.UseSerilog();
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

Log.Logger = new LoggerConfiguration()
.MinimumLevel.Debug()
.WriteTo.Console()
.WriteTo.File(path: "d:\\.Net Projects\\.Net Core Api\\NotJustAGame\\Logs\\log-.txt",
        outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
        rollingInterval: RollingInterval.Day,
                    restrictedToMinimumLevel: LogEventLevel.Information)
.CreateLogger();
try
{
    Log.Information("Application Is Starting");
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application Failed to start");
}
finally
{
    Log.CloseAndFlush();
}

