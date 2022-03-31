namespace DependencyInjectionDemoApi.Domain.Exam
{

    public interface IExam : IActivity
    {
        public string ExamName { get; set; }

    }
}