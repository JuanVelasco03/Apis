using Microsoft.EntityFrameworkCore;
using soulmedical.Models.bd;
using soulmedical.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();

builder.Services.AddCors(options => 
{
    var frontendURL = configuration.GetValue<string>("frontend_url");

    options.AddDefaultPolicy(builder => 
    {
        builder.WithOrigins(frontendURL).AllowAnyMethod().AllowAnyHeader();
    });
});
// builder.Services.AddDbContext<SoulMedicalContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("cadenasql")));
builder.Services.AddSqlServer<SoulMedicalContext>(builder.Configuration.GetConnectionString("conexionbd"));


builder.Services.AddControllers().AddJsonOptions(opt => 
{
    opt.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
});

// builder.Services.AddScoped<ITrabajadorService, TrabajadorService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
