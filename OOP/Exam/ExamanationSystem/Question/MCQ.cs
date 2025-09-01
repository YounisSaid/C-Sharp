using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationsSystem.Answers;


namespace ExaminationsSystem.Questions
{
    public class MCQ : Question
    {
        public MCQ( string? body, int? mark) : base(body, mark)
        {
            Header = "MCQ Question";
           

          
        }
    }
}
