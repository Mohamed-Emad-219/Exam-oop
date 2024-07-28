using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_oop
{
    internal class Question
    {
        // MCQ will be in f & p 
        public void AddQuestion()
        {
            string? Body;
            string? Mark;
            short num_choice;
            Console.WriteLine("Please Enter Body Of Question :");
            Body = Console.ReadLine();
            Console.WriteLine("Please Enter Mark Of Question :");
            Mark = Console.ReadLine();
            Console.WriteLine("Please Enter Number choice Of Question :");
            num_choice = short.Parse(Console.ReadLine());
            string[] choice = new string[num_choice];

            for (int i = 0; i < num_choice; i++)
            {
                Console.WriteLine($"Please Enter choice {i+1} :");
                choice[i] = Console.ReadLine();
            }
            Console.WriteLine("Please Enter Id of Right Answer :");
            short ID = short.Parse(Console.ReadLine());

        }
    }
}
