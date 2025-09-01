using ExaminationsSystem.Exams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExaminationsSystem.UI.UI;

namespace ExaminationsSystem.Subjects
{
    public class Subject
    {
        public Subject(int subjectId, string? subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public Exam? ExamOfSubject { get; set; }

        public void CreateExam()
        {
            // Create Exam
            int ExamType = GetExamType();
            int TimeInMin = GetExamTime();
            int NumOfQ = GetNumberOfQ();
            if (ExamType == 1)
            {
                ExamOfSubject = new PracticalExam(TimeInMin, NumOfQ);
            }
            else
            {
                ExamOfSubject = new FinalExam(TimeInMin, NumOfQ);
            }

            CreateQuestions(ExamOfSubject);


        }

        private void CreateQuestions(Exam exam)

        {
            // Create Q
            for (int i = 0; i < exam.NumOfQ; i++)
            {
                int QuestionType = 0;
                if (ExamOfSubject is PracticalExam)
                {
                    // 1 for MCQ
                    QuestionType = 1;
                }
                else
                {
                    // Get Q type MCQ or True|False
                    QuestionType = GetQType();
                }

                if (QuestionType == 1)
                {
                    // Add MCQ Q
                    ExamOfSubject.questions.Add(GetMCQQuestion());

                }
                else
                {
                    // Add TrueOrFalseQuestion
                    ExamOfSubject.questions.Add(GetTrueOrFalseQuestion());
                }
            }
        }
    }
}
            
        

