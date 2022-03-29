namespace DependencyInjectionDemoApi.Domain.Exam;

public interface IActivity
{
    public int ExamDuration {get;}
    public int CalculateActivityDuration();
}