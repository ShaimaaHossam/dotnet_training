using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Answer
    {        
        public string AnswerValue { get; set; }
        public bool isCorrect { get; set; }
        public Answer(string value)
        {
            AnswerValue = value;
        }
    }
}
