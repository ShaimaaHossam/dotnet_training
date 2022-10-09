using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Question
    {
        
        public string Body { get; set; }
        public   string Header { get; set; } 
        public   float Marks { get; set; }
        public   AnswersList<Answer> Answers { get; set; }

    }
}
