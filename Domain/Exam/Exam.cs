namespace DependencyInjectionDemoApi.Domain.Exam
{

    public class Exam : IExam
    {
        public string ExamName
        {
            get => "my Exam";
            set { }
        }


        public int ExamDuration { get; private set; }

        public int CalculateActivityDuration()
        {
            ExamDuration = 60;
            return 60;
        }
    }

}