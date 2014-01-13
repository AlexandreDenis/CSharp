using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericite
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> lint = new LinkedList<int>();
            LinkedList<string> lstring = new LinkedList<string>();

            lint.AddLast(5);
            lint.AddLast(1);
            lint.AddLast(4);
            lint.AddLast(3);

            Console.WriteLine(lint);

            lstring.AddLast("cinq");
            lstring.AddLast("un");
            lstring.AddLast("quatre");
            lstring.AddLast("trois");

            Console.WriteLine(lstring);

            Console.ReadLine();
        }
    }
}
