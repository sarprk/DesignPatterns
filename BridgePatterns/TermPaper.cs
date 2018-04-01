using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace BridgePatterns
{
    public class TermPaper : Manuscript
    {
        public TermPaper(IFormatter formatter) : base(formatter)
        {

        }

        public string Class { get; set; }
        public string Student { get; set; }
        public string Text { get; set; }

        public string Reference { get; set; }

        public override void Print()
        {
            WriteLine(formatter.Format("Class", Class));
            WriteLine(formatter.Format("Student", Student));
            WriteLine(formatter.Format("Text", Text));
            WriteLine(formatter.Format("Reference", Reference));
        }
    }
}
