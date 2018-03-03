using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Language2
    {
        static void Main(string[] args)
        {
            //String[] C =
            //{
            //    "S=>ab",
            //    "S=>aaSbb"
            //};

            String[] C =
            {
                "S=>A",
                "A=>aB",
                "A=>bA",
                "A=>a",
                "A=>b",
                "B=>bA",
                "B=>b"
            };

            //String[] C =
            //{
            //    "S=>ba",
            //    "S=>aaSaa",
            //};

            //String[] C =
            //{
            //    "S=>zA",
            //    "A=>xA",
            //    "A=>B",
            //    "B=>yyB",
            //    "B=>C",
            //    "C=>z"
            //};

            string inString, startWkString;
            bool accept1;
            CFG CFG1 = new CFG(C);

            if (args.Length >= 1)
            {
                inString = args[0];
                char startNonTerm = CFG1.getStartNT();
                startWkString = Char.ToString(startNonTerm);
                accept1 = CFG1.processData(inString, startWkString);
                Console.WriteLine("Accept String? " + accept1);
            }
        }

    }
}
