//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ExaminationsSystem
//{
//    classDiagram
//    class Subject
//    {
//        +int SubjectId
//        +string SubjectName
//        +Exam SubjectExam
//        +void CreateExam()
//    }

//    class Exam
//    {
//        <<Abstract>>
//        +int TimeInMinutes
//        +int NumberOfQuestions
//        +List <Question>QuestionList
//        +void StartExam()
//        +void ShowExam()
//    }

//    class FinalExam
//    {
//        +void ShowExam()
//    }

//    class PracticalExam
//    {
//        +void ShowExam()
//    }

//    class Question
//    {
//        +string Header
//        +string Body
//        +int Mark
//        +List <Answer>AnswerList
//        +Answer RightAnswer
//        +Answer UserAnswer


//    }

//    class TrueFalseQuestion
//    {
//    }

//    class MCQQuestion
//    {
//    }

//    class Answer
//    {
//        +int AnswerId
//        +string AnswerText
//    }

//    class UI
//    {
//        + GetExamType()
//        + GetExamTime()
//        + GetNumberOfQ()
//        + GetQType()
//        + GetMCQQuestion()
//        + GetTrueOrFalseQuestion()
//        + BeginExam(int)
//        + PrintQ(Question)
//        + GetUserAnswerID(Question)
//        + ShowPracticalExamResults(List~Question~)
//        + ShowFinalExamResults(List~Question~)
//        + PrintExamTime(Stopwatch)
//        + BreakTimerMessage() //Public
//        - GetValidChoice(int, int) //Private
//        - GetBody()
//        - GetMark()
//        - GetMcqAnswers(Question)
//        - SetQuestionRightAnswer(Question)
//        - GetRightAnswerID(int)
//        - PrintTrueOrFalseChoices()
//        - PrintUserAndRightAnswerScreen(Question)
//    } 

//    Subject --o Exam : aggregates //has-a
//    Exam<|-- FinalExam //is-a
//    Exam <|-- PracticalExam //is-a
//    Exam --o Question : aggregates //has-a
//    Question <|-- TrueFalseQuestion // is-a
//    Question <|-- MCQQuestion //is-a
//    Question --o Answer : aggregates // has-a
//}
