using DependencyInjectionDemoApi.Domain.Exam;

namespace DependencyInjectionDemoApi.Domain.Course;

public class Course : ICourse, IReviewable
{
    public IExam Exam { get; }
    
    public Course(IExam exam)
    {
        Exam = exam;
    }

    
    public string CourseName
    {
        get => "my course";
        set { }
    }

    public string? ProcessCourseName()
    {
        this.CourseName = this.CourseName.ToUpper();
        return this.CourseName.ToUpper();
    }
    

    public int LoadExamDetails()
    {
        return Exam.CalculateActivityDuration();
    }

    public int CalculateReviewCount()
    {
        return 500;
    }
}
