using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_oop
{
    
        public class Subject : ICloneable 
        {
            public int SubjectId { get; set; }
            public string SubjectName { get; set; }
            public Exams Exam { get; set; }

            public Subject(int subjectId, string subjectName, Exams exam)
            {
                SubjectId = subjectId;
                SubjectName = subjectName;
                Exam = exam;
            }

            

            public object Clone()
            {
                return new Subject(SubjectId, SubjectName, Exam);
            }

            

            public override string ToString()
            {
                return $"Subject ID: {SubjectId}, Subject Name: {SubjectName}";
            }
        }


    }
