using System;

namespace CursoTDD
{
    static class Program
    {
        static void Main(string[] args)
        {
            string empty = NaiveCanonicalizer.GetCanonicalForm("");

            Console.WriteLine(empty == "");
            empty = NaiveCanonicalizer.GetCanonicalForm(" ");

            Console.WriteLine(empty == "");
            empty = NaiveCanonicalizer.GetCanonicalForm("    ");

            Console.WriteLine(empty);


            //Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Katie Melua life wonderful "));
            //Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Katie     Melua     life      wonderful "));

            //Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Wonderful life Katie Melua"));
            //Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("life wonderful Katie Melua"));
            //Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Katie Meluw Wonderful life"));

            Console.ReadKey();
        }
    }
}
