using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BridgePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormatter formatterStandard = new StandardFormatter();
            IFormatter backwardFormatter = new ReverseFormatter();

            Book book = new Book(formatterStandard) { Author = "Rajesh", Text = " Happy coding", Title = "Design Patterns" };
            TermPaper term = new TermPaper(backwardFormatter) {
                Class="Phd",
                Text="Internet and Revolution",
                Reference="Internet of Things",
                Student = "Mr. Rajesh Kumar"
            };

            Faq faq = new Faq(formatterStandard)
            {
                Title = "Design patterns!!",
                Questions = new List<string>
                {
                    "Better way of design patterns",
                    "More Organised."
                }
            };

            book.Print();
            term.Print();
            faq.Print();

            ReadLine();
        }
    }
}
