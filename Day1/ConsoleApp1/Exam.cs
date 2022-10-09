using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    abstract class Exam
    {
        protected decimal _time;
        protected int _questions_count;
        protected Subject _subject;
        protected  Dictionary<Question, Answer[]> _QAdictionary;
        protected bool hasEnded;
        public decimal Time { get { return _time; } set { _time = value; } }
        public int QuestionsCount { get { return _questions_count; } set { _questions_count = value; } }
        public Subject ExamSubject { get { return _subject; } set { _subject = value; } }
        public Dictionary<Question, Answer[]> QADictionary { get { return _QAdictionary; } }
        public bool HasEnded { get { return hasEnded; } set { hasEnded = value; } }
        public virtual void ShowExam() { }
        public virtual void EndExam() {
            this.hasEnded = true;
        }

    }
}
