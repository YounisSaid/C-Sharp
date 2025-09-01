using ExaminationsSystem.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationsSystem.Questions
{
    public class TrueOrFalse : Question
    {
        public TrueOrFalse( string? body, int? mark) : base(body, mark)
        {
            Header = "True | False Question";
            AnswerList.Add(new Answer(1, "True"));
            AnswerList.Add(new Answer(2, "False"));

        }
    }
}
