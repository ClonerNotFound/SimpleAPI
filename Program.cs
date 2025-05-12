using SimpleAPI.services;
using SimpleAPI.Services;

var builder = WebApplication.CreateBuilder(args);

CorsPolicy.ConfigureCorsPolicy(builder.Services);

builder.Services.AddHttpClient<ServerInfoService>();
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors("AllowSpecificOrigin");

app.UseAuthorization();

app.MapControllers();

app.Run();
