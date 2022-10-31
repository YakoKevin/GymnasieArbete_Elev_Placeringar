using GymnasieArbetePlaceringarAPI.IServices.IElevServices;
using GymnasieArbetePlaceringarAPI.Services.ElevServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IGetElevObjectService, GetElevObjectService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader()
           .SetIsOriginAllowed(origin => true);
    //.AllowCredentials()
    //.WithMethods("GET, PATCH, DELETE, PUT, POST, OPTIONS");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
