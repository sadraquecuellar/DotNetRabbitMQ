using Rabbit.Repositories;
using Rabbit.Services;
using Rabbit.Services.Interfaces;
using Rabbit.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IRabbitMessageService, RabbitMessageService>();
builder.Services.AddTransient<IRabbitMessageRepository, RabbitMessageRepository>();

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
