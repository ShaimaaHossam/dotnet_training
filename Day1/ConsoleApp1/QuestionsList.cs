using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class QuestionsList<Question> : List<Question>
    {
        public static int ListsCount =0;
        private TextWriter writeFile;
        public QuestionsList(){
            ListsCount++;
            writeFile = new StreamWriter($"questionList{ListsCount}.txt");
        }
        public override void Add(Question question)
        {
            this.Add(question);

            try {
                foreach (var q in this)
                {
                    writeFile.WriteLine(q.Body);
                }

                writeFile.Flush();
                writeFile.Close();
                writeFile = null;
            } catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
