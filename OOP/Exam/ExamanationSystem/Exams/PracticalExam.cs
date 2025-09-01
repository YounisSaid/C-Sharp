using ExaminationsSystem.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExaminationsSystem.UI.UI;
namespace ExaminationsSystem.Exams
{
    internal class PracticalExam : Exam
    {
        public PracticalExam( int timeInMin, int numOfQ) : base( timeInMin, numOfQ)
        {

        }

       

        public override void ShowExamResult()
        {
            ShowPracticalExamResults(questions);
        }
    }
}
