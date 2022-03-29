namespace DependencyInjectionDemoApi.Domain.Course;

public interface ICourse
{
    public string CourseName {get; set;}

    public string? ProcessCourseName();

    public int LoadExamDetails();
}
