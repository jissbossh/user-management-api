var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

// 1. Uso del Middleware personalizado de Logging
app.UseMiddleware<UserManagementAPI.Middleware.RequestLoggingMiddleware>();

app.UseAuthorization();
app.MapControllers();

app.Run();