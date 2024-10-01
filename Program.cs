using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Webvs2;
using Webvs2.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mi API", Version = "v1" });
});
builder.Services.AddControllers();
// builder.Services.AddDbContext<AplicationDbContext>(options =>
//     options.UseNpgsql(
//         builder.Configuration.GetConnectionString("Host=localhost;Username=kevin;Password=1234;Database=mydatabase")));

builder.Services.AddDbContext<AplicationDbContext>();

builder.Services.AddScoped<IAula, AulaService>();
builder.Services.AddScoped<IAlumnoService, AlumnoService>();
builder.Services.AddScoped<ITareas, TareaService>();




var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mi API V1");
    c.RoutePrefix = string.Empty; // Esto sirve Swagger UI en la raíz
});
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapRazorPages();
app.MapControllers();

app.Run();