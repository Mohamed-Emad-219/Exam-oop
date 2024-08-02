namespace Exam_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Answer[] answers = {
        new Answer(1, "Answer 1"),
        new Answer(2, "Answer 2"), };
     
     
            Question[] questions = 
                {
        new MSQQ("Q1", "------------?", 5, answers, answers[1]),
        new TrueFalseQ("Q2"," ==========?", 5)
                };


            Exams finalExam = new Final(DateTime.Now, 2, questions);
            Subject subject = new Subject(1, "Math", finalExam);
            //Subject.????????
        }
    }
}
