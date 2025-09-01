using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  ExaminationsSystem.Exams;
using ExaminationsSystem.Questions;
using ExaminationsSystem.Answers;
using System.Diagnostics;

namespace ExaminationsSystem.UI
{
    public static class UI
    {
        private static int GetValidChoice(int minChoice, int maxChoice)
        {
            int choice;
            while (true)
            {
                Console.Write($"Enter your choice ({minChoice} - {maxChoice}): ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out choice) && choice >= minChoice && choice <= maxChoice)
                {
                    return choice; 
                }

                Console.WriteLine("Invalid choice, please try again.");
            }
        }


        public static int GetExamType()
        {
            Console.WriteLine("Please Enter Type Of Exam (1.practical |2.Final)");
            return  GetValidChoice(1,2);
          
        }

        public static int GetExamTime()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter Exam Time (30min-80min)");
            return GetValidChoice(30, 80);

        }

        public static int GetNumberOfQ()
        {
            Console.WriteLine();
            Console.WriteLine("Please Enter Num Of Q max 10 )");
            return GetValidChoice(1,10);
        }

        public static int GetQType()
        {
            Console.Clear();
            Console.WriteLine("Please Enter Q Type (1 for MCQ |2 for True |False)");
            return GetValidChoice(1,2);
        }
        private static string GetBody()
        {
            Console.WriteLine();
            Console.WriteLine("Please Enter Question Body");
            return Console.ReadLine();
        }

        private static int GetMark()
        {
            Console.WriteLine();
            Console.WriteLine("Please Enter Question Mark (10 max)");
            return GetValidChoice(1,10);
        }

        public static void GetMcqAnswers( Question question)
        {
            Console.WriteLine();
            Console.WriteLine("Choices Of Questions ");
            Console.WriteLine();
            for (int i = 0;i<3;i++)
            {
                Console.WriteLine($"Please Enter Choice Num {i + 1}");
                
                question.AnswerList.Add(new Answer(i+1,Console.ReadLine()));
            }
        }

        public static void SetQuestionRightAnswer(Question question)
        {
            int MaxNumOfChoices = question.AnswerList.Count;
            question.RightAnswer = question.AnswerList[GetRightAnswerID(MaxNumOfChoices)];
        }
        public static Question GetMCQQuestion()
        {
            Console.Clear();
            Console.WriteLine("MCQ Question");
            Question question = new MCQ(GetBody(), GetMark());
            GetMcqAnswers(question);
            SetQuestionRightAnswer(question);
            return question;
        }

        public static int GetRightAnswerID(int MaxNumOfChoices)
        {
            Console.WriteLine();
            Console.WriteLine("Please Enter Right Answer ID");
            
                return GetValidChoice(1, MaxNumOfChoices); 

        }
        public static void PrintTrueOrFalseChoices()
        {
            Console.WriteLine("1-True");
            Console.WriteLine("2-False");

        }
        public static Question GetTrueOrFalseQuestion()
        {
            Console.WriteLine();
            Console.WriteLine("True|False Question");
            Question question = new TrueOrFalse(GetBody(), GetMark());
            PrintTrueOrFalseChoices();
            SetQuestionRightAnswer(question) ;
            return question;
        }

        public static bool BeginExam(int TimeInMin)
        {
            Console.Clear();
            Console.WriteLine($"Do You Want to start Exam ({TimeInMin})min (Y/N)");
            return Console.ReadLine().ToLower() =="y"; 
        }
        
        public static void PrintQ(Question question)
        {
            
            Console.WriteLine(question.Header);
            Console.WriteLine(question.Body + $"   ({question.Mark}) Mark");
            foreach (Answer answer in question.AnswerList)
            {
                Console.WriteLine($"{answer.AnswerID} - {answer.AnswerText}");
            }
        }

        public static int GetUserAnswerID(Question question)
        {
            Console.WriteLine();
            Console.WriteLine("Choose the Correct AnswerID");
           return GetValidChoice(1, question.AnswerList.Count);
        }

        private static void PrintUserAndRightAnswerScreen(Question question)
        {
            Console.WriteLine($"Your Answer : {question.UserAnswer.AnswerText}");
            Console.WriteLine($"Right Answer : {question.RightAnswer.AnswerText}");
            Console.WriteLine();

        }
         public static void ShowPracticalExamResults(List<Question> questions)
        {
            Console.Clear();
            Console.WriteLine("==============Practical Exam Result================");
            foreach (Question question in questions)
            {
                PrintUserAndRightAnswerScreen(question);
            }
        }

        public static void ShowFinalExamResults(List<Question> questions)
        {
            Console.Clear();
            Console.WriteLine("==============Final Exam Result================");
            int? Grade = 0;
            int? TotalMarks = questions.Sum(question => question.Mark) ?? 0;
            foreach (Question question in questions)
            {

            Console.WriteLine(question.Header);
            Console.WriteLine(question.Body);
            PrintUserAndRightAnswerScreen(question);
            if (question.UserAnswer == question.RightAnswer) Grade += question.Mark;

            }
            Console.WriteLine();
            Console.WriteLine($"Your Total Grades are {Grade}/{TotalMarks}");
            

        }

        public static void PrintExamTime(Stopwatch timer)
        {
            Console.WriteLine($"\nTime taken: {timer.Elapsed:hh\\:mm\\:ss}");
            Console.WriteLine("Thank You");
        }

        public static void BreakTimerMessage()
        {
            Console.WriteLine("\nTime's up! The exam will now end.");
        }
    }
}

