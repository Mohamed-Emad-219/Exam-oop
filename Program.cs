namespace Exam_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter Type of Exam (.1 For Final .2 For practical");
            byte Type = byte.Parse(Console.ReadLine());
            if (Type == 1)
            {
                Final final = new Final();
                final.AddQuestion();
            }
            else
            {
                Parctical parctical = new Parctical();
                Console.WriteLine(".1 For MCQ .2 For True | False");
                string typeofquestion = Console.ReadLine();
                if (typeofquestion == "1")
                    parctical.AddQuestion();
                else
                    parctical.AddQuestionTrueOrFalse();
            }


        }
    }
}
