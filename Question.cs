using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_oop
{
    public abstract class Question
    {
       

        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Answer[] AnswerList { get; set; }
        public Answer AnswerId { get; set; }
        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public abstract void print();
        // public int Time { get; set; }
        //// MCQ will be in f & p 
        //public void AddQuestion()
        //{
        //    string? Body;
        //    string? Mark;
        //    short num_choice;
        //    Console.WriteLine("Please Enter Body Of Question :");
        //    Body = Console.ReadLine();
        //    Console.WriteLine("Please Enter Mark Of Question :");
        //    Mark = Console.ReadLine();
        //    Console.WriteLine("Please Enter Number choice Of Question :");
        //    num_choice = short.Parse(Console.ReadLine());
        //    Answer[] choice = new Answer[num_choice];

        //    for (int i = 0; i < num_choice; i++)
        //    {
        //        Console.WriteLine($"Please Enter choice {i+1} :");
        //        choice[i].AnswerText = Console.ReadLine();
        //    }
        //    Console.WriteLine("Please Enter Id of Right Answer :");
        //    short ID = short.Parse(Console.ReadLine());

        //}
    }
}
