using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExaminationsSystem.Answers;
namespace ExaminationsSystem.Questions
{
    public  class Question
    {
        public Question( string? body, int? mark)
        {
           
            Body = body;
            Mark = mark;
            AnswerList = new List<Answer>();    
            
        }

        public string? Header { get; set; }
        public string? Body { get; set; }
        public int? Mark {  get; set; }

        public List<Answer> AnswerList { get; set; }
        public Answer? RightAnswer { get; set; }

        public Answer? UserAnswer { get; set; }
        public override string ToString()
        {
            var result = new StringBuilder();

            // Header + Body
            result.AppendLine($"[{Header}]");
            result.AppendLine($"{Body}   (Mark: {Mark})");

            // Answers (if exist)
            if (AnswerList != null && AnswerList.Count > 0)
            {
                foreach (var ans in AnswerList)
                {
                    if (ans != null)
                        result.AppendLine(ans.ToString());
                }
            }

            return result.ToString();
        }


    }
}
