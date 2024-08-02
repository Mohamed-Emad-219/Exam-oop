using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam_oop
{
    public class Answer  
    {

        public string AnswerText { get; set; }
        public int AnswerId { get; set; }
        public Answer( int answerId, string answerText) { 
            AnswerText = answerText;
            AnswerId = answerId;
        }

    }

	
}
