using DependencyInjectionDemoApi.Domain.Course;
using DependencyInjectionDemoApi.Domain.Exam;
using DependencyInjectionDemoApi.Domain.User;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUser, User>();
builder.Services.AddScoped<ICourse, Course>();
builder.Services.AddScoped<IReviewable, Course>();
builder.Services.AddScoped<IExam, Exam>();

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
