using NUnit.Framework;
using System.Collections.Generic;
using System.Threading;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [SetCulture("tr-TR")]
        public void Test1()
        {
            TestHashSetComparison(StringComparer.OrdinalIgnoreCase);
        }

        [Test]
        public void Test2()
        {
            TestHashSetComparison(StringComparer.OrdinalIgnoreCase);
        }

        [Test]
        [SetCulture("tr-TR")]
        public void Test3()
        {
            TestHashSetComparison(StringComparer.OrdinalIgnoreCase);
        }

        private static void TestHashSetComparison(IEqualityComparer<string> comparer)
        {
            Console.WriteLine(Thread.CurrentThread.CurrentCulture);

            var set = new HashSet<string>(comparer)
            {
                "A",
            };

            Assert.IsTrue(set.Contains("a"));
        }
    }
}
