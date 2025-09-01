using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationsSystem.Answers;
using ExaminationsSystem.Questions;
using static ExaminationsSystem.UI.UI;

namespace ExaminationsSystem.Exams
{
    public abstract class Exam
    {
        protected Exam( int timeInMin, int numOfQ)
        {
            TimeInMin = timeInMin;
            NumOfQ = numOfQ;
            questions = new List<Question>();
            Timer = new Stopwatch();    
        }

        public Stopwatch Timer { get; set; }
        public int TimeInMin { get; set; }
        public int NumOfQ { get; set; }

        public  List<Question> questions { get; set; }
        
        public void StartExam()
        {
            Console.Clear();
            if(BeginExam(TimeInMin))
            {
                Console.Clear();

                Timer.Start();
                foreach (Question question in questions)
                {
                    if (Timer.Elapsed.TotalMinutes >= TimeInMin)
                    {
                        BreakTimerMessage();
                        break;
                    }
                    Console.WriteLine();
                    PrintQ(question);
                    int UserAnswerID = GetUserAnswerID(question);
                    question.UserAnswer = question.AnswerList[UserAnswerID];

                }
                ShowExamResult();
                PrintExamTime(Timer);
            }
        }

        public abstract void ShowExamResult();

    }
}
