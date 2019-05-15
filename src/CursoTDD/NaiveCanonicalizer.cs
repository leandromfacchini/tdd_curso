using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursoTDD
{
    public class NaiveCanonicalizer
    {
        public static string GetCanonicalForm(string searchTerm)
        {
            return searchTerm
                    .Split(new[] { ' ' })
                    .Select(x => x.ToUpper())
                    .OrderBy(x => x)
                    .Aggregate((x, y) => x + " " + y);

        }
    }
}
