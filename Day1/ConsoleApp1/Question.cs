using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Question
    {
        protected string _body, _header;
        protected float _marks;
        protected AnswersList _answers;
        protected Answer _answer;

        public string Body { get { return _body } set { _body = value; } }
        public   string Header { get { return _header } set { _header = value; } } 
        public   float Marks { get { return _marks } set { _marks = value; } }

        public   AnswersList Answers { get { return _answers; } }
        public  Answer CorrectAnswer { get { return _answer } set { _answer = value; } }


    }
}
