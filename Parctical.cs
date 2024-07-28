using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_oop
{
    internal class Parctical :Question
    { 
        public void AddQuestionTrueOrFalse()
        {
            Console.WriteLine("Please Enter Body Of Question :");
            string body = Console.ReadLine();
            Console.WriteLine("Please Enter Mark Of Question :");
            string Mark = Console.ReadLine();

            Console.WriteLine("Please Enter Number choice Of Question :");
         short num_choice = short.Parse(Console.ReadLine());
            string[] choice = new string[num_choice];

            for (int i = 0; i < num_choice; i++)
            {
                Console.WriteLine($"Please Enter choice {i + 1} :");
                choice[i] = Console.ReadLine();
            }

            Console.WriteLine("Please Enter Id of Right Answer :");
            short ID = short.Parse(Console.ReadLine());

        }
    }
}
