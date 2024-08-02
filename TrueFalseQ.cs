using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam_oop
{
    internal class TrueFalseQ :Question
    {
        public TrueFalseQ(string header, string body, int mark)
        : base(header, body, mark) { }

        public override void print()
        {
            Console.WriteLine($"{Header}\n{Body}\n1. True\n2. False");

        }
    }
}
