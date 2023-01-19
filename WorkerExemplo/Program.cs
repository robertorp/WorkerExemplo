using WorkerExemplo;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureServices((hostContext, services) => services.AddHostedService<Worker>());
// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();




// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
