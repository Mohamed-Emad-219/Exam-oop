using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_oop
{
    internal class MSQQ : Question
    {
        public MSQQ(string header, string body, int mark, Answer[] answers, Answer rightAnswer)
          : base(header, body, mark)
        {
            AnswerList = answers;
            AnswerId = rightAnswer;
        }

        public override void print()
        {
            Console.WriteLine($"{Header}\n{Body}");
            for (int i = 0; i < AnswerList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {AnswerList[i].AnswerText}");
            }
        }
    }
}
