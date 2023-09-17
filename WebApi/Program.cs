using Infrastructure.Data;
using Infrastructure.Servises;
using Infrastructure.Servises.Courses;
using Infrastructure.Servises.Posts;
using Infrastructure.Servises.Students;
using Infrastructure.Servises.Teachers;
using Microsoft.EntityFrameworkCore;
using Servises.Teachers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var con = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DataContext>(c=>c.UseNpgsql(con));

builder.Services.AddScoped<IStudentServise,StudentServise >();
builder.Services.AddScoped<ITeacherServise, TeacherServise>();
builder.Services.AddScoped<ICourseServise, CourseServise>();
builder.Services.AddScoped<IPostServise,PostServise>();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
