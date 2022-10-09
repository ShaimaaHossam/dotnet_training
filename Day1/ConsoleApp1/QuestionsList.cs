using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    class QuestionsList<Quesion> : List<Question>
    {
        public static int ListsCount =0;
        private TextWriter writeFile;
        public QuestionsList(){
            ListsCount++;
            writeFile = File.CreateText($"questionList{ListsCount}.txt");
        }
        public void AddQ(Question question)
        {
            this.Add(question);

            using (this.writeFile)
            {
                writeFile.WriteLine($"Question: {question.Body}");
            }
            Console.ReadKey();
            
        }
    }
}
