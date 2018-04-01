using System.Collections.Generic;
using static System.Console;

namespace BridgePatterns
{
    public class Faq : Manuscript
    {
        public Faq(IFormatter formatter) : base(formatter)
        {
        }

        public string Title { get; set; }
        public List<string> Questions { get; set; }

        public override void Print()
        {
            WriteLine(formatter.Format("Title", Title));
            WriteLine(formatter.Format("Questions", string.Join("\n", Questions)));
        }
    }
}
