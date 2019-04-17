using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace TestLocaleBug
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TestHashSetComparison(StringComparer.OrdinalIgnoreCase);
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfoByIetfLanguageTag("tr-TR");
            TestHashSetComparison(StringComparer.OrdinalIgnoreCase);
        }

        private static void TestHashSetComparison(IEqualityComparer<string> comparer)
        {
            Console.WriteLine(Thread.CurrentThread.CurrentCulture);

            var set = new HashSet<string>(comparer)
            {
                "A",
            };

            if (!set.Contains("a"))
            {
                throw new InvalidProgramException();
            }
        }
    }
}
