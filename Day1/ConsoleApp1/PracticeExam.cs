using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PracticeExam : Exam
    {
        public override void ShowExam()
        {
            foreach(var question in this.Questions)
            {
                Console.WriteLine(question.CorrectAnswer);
            }
        }
    }
}
