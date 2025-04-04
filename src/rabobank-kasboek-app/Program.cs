var currentDirectory = Environment.CurrentDirectory;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseAuthorization();
app.MapControllers();

app.Run();
