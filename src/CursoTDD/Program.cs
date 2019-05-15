using System;

namespace CursoTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Wonderful life Katie Melua"));
            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("life wonderful Katie Melua"));
            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Katie Meluw Wonderful life "));

            Console.ReadKey();
        }
    }
}
