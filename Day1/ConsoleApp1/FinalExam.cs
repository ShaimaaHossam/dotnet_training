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
            foreach(var question in this.Questions)
            {
                Console.WriteLine(question.Body);
                foreach(var answer in question.Answers)
                {
                    Console.WriteLine(answer.AnswerValue);
                }
            }
        }
    }
}
