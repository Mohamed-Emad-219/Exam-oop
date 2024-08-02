using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_oop
{
    internal class Final : Exams, ICloneable
    {
        public Final(DateTime examTime, int numberOfQuestions, Question[] questions)
         : base(examTime, numberOfQuestions, questions) { }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public override void print()
        {
            Console.WriteLine($"");
        }
    }
}
