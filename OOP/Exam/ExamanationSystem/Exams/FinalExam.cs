using ExaminationsSystem.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExaminationsSystem.UI.UI;

namespace ExaminationsSystem.Exams
{
    public class FinalExam : Exam
    {
        public FinalExam( int timeInMin, int numOfQ) : base( timeInMin, numOfQ)
        {
        }

       
        public override void ShowExamResult()
        {
            ShowFinalExamResults(questions);
        }
    }
}
