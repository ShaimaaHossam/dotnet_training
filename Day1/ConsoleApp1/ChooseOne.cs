using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ChooseOne : Question
    {
        public ChooseOne(string body, string header, float marks, AnswersList<Answer> answers)
        {
            this.Body = body;
            this.Header = header;
            this.Marks = marks;
            this.Answers = answers;
        }    
    }
}
