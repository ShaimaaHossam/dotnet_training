using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PracticeExam : Exam
    {
        public PracticeExam(QuestionsList<Question> questions, AnswersList<Answer> answer)
        {

        }
        public override void ShowExam()
        {
            if (this.hasEnded)
            {
                foreach (KeyValuePair<Question, Answer[]> pair in this.QADictionary)
                {
                    Console.WriteLine($"Question: {pair.Key.Body}");
                    foreach(Answer answer in pair.Value)
                    {
                        if (answer.isCorrect)
                        {
                            Console.WriteLine($"- {answer.AnswerValue}");
                        }
                    }
                }
            }
        }
    }
}
