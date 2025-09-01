using ExaminationsSystem.Subjects;

namespace ExaminationsSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "Object-Oriented-Programming");
            subject.CreateExam();
            if(subject.ExamOfSubject !=null)
            {
                subject.ExamOfSubject.StartExam();
            }
        }
    }
}
