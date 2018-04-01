using static System.Console;

namespace BridgePatterns
{
    public class Book : Manuscript
    {
        public Book(IFormatter formatter) : base(formatter)
        {
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        public override void Print()
        {
            WriteLine(formatter.Format("Title", Title));
            WriteLine(formatter.Format("Author", Author));
            WriteLine(formatter.Format("Text", Text));
        }
    }
}
