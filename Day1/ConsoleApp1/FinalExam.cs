using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FinalExam : Exam
    {
        public override void ShowExam()
        {
            if (this.hasEnded)
            {
                foreach(KeyValuePair<Question, Answer[]> pair in this.QADictionary)
                {
                    Console.WriteLine($"Question: {pair.Key.Body}");
                    foreach(Answer answer in pair.Key.Answers)
                    {
                        Console.WriteLine($"- {answer.AnswerValue}");
                    }
                }
            }
        }

    }
}
