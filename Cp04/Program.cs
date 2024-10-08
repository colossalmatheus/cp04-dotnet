using Microsoft.OpenApi.Models;
 
var builder = WebApplication.CreateBuilder(args);
 
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 
builder.Services.AddHttpClient();
 
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Consumindo API de Câmbio",
        Version = "v1",
        Description = "Este projeto, consumindo uma API permite consultar a taxa de câmbio.",
    });
 
});
 
builder.Services.AddSwaggerGen(c =>
{
    c.EnableAnnotations();
});
 
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