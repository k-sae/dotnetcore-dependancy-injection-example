using DependencyInjectionDemoApi.Domain.Course;
using DependencyInjectionDemoApi.Domain.Exam;

namespace DependencyInjectionDemoApi.Domain.User
{

    public class User : IUser
    {
        public ICourse Course { get; }
        public IReviewable Reviewable { get; }
        public int ReviewCount { get; private set; }

        public User(ICourse course, IReviewable reviewable)
        {
            Course = course;
            Reviewable = reviewable;
        }

        public Exam.Exam ExamInstance { get; set; }
        public int ExamPassedTime { get; set; }

        public int id { get; set; }
        public string? name { get; set; }
        public string? CourseName { get; set; }


        public User GetUserWithCourseName()
        {
            CourseName = Course.ProcessCourseName();
            ReviewCount = Reviewable.CalculateReviewCount();
            ExamPassedTime = Course.LoadExamDetails() - 20;
            ExamInstance = new Exam.Exam();
            return this;
        }
    }


    public interface IUser
    {
        public int id { get; set; }
        public string? name { get; set; }

        public string? CourseName { get; set; }

        public User GetUserWithCourseName();

        public Exam.Exam ExamInstance { get; set; }

        public int ExamPassedTime { get; set; }
    }
}