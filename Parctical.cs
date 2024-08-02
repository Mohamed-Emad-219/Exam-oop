using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_oop
{
    internal class Parctical :Question ,ICloneable
    {
        public Parctical(string header, string body, int mark) : base(header, body, mark)
        {
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public override void print()
        {
            throw new NotImplementedException();
        }
    }
}
