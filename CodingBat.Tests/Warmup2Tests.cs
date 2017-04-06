using System;
using NUnit.Framework;
using Shouldly;

namespace CodingBat.Tests
{
    [TestFixture]
    public class Warmup2Tests
    {
        private Warmup2 _warmup2 = new Warmup2();

        [Test]
        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]
        [TestCase("Hi", 0, "")]
        [TestCase("Hi", 5, "HiHiHiHiHi")]
        [TestCase("Oh Boy!", 2, "Oh Boy!Oh Boy!")]
        [TestCase("x", 4, "xxxx")]
        [TestCase("", 4, "")]
        [TestCase("code", 2, "codecode")]
        [TestCase("code", 3, "codecodecode")]
        public void stringTimes(String str, int n, string expected)
        {
            _warmup2.stringTimes(str, n).ShouldBe(expected);
        }

        [Test]
        [TestCase("Chocolate", 2, "ChoCho")]
        [TestCase("Chocolate", 3, "ChoChoCho")]
        [TestCase("Abc", 3, "AbcAbcAbc")]
        [TestCase("Ab", 4, "AbAbAbAb")]
        [TestCase("A", 4, "AAAA")]
        [TestCase("", 4, "")]
        [TestCase("Abc", 0, "")]
        public void frontTimes(String str, int n, string expected)
        {
            _warmup2.frontTimes(str, n).ShouldBe(expected);
        }

        [Test]
        [TestCase("abcxx", 1)]
        [TestCase("xxx", 2)]
        [TestCase("xxxx", 3)]
        [TestCase("abc", 0)]
        [TestCase("Hello there", 0)]
        [TestCase("Hexxo thxxe", 2)]
        [TestCase("", 0)]
        [TestCase("Kittens", 0)]
        [TestCase("Kittensxxx", 2)]
        public void countXX(String str, int expected)
        {
            _warmup2.countXX(str).ShouldBe(expected);
        }

        [Test]
        [TestCase("axxbb", true)]
        [TestCase("axaxax", false)]
        [TestCase("xxxxx", true)]
        [TestCase("xaxxx", false)]
        [TestCase("aaaax", false)]
        [TestCase("", false)]
        [TestCase("abc", false)]
        [TestCase("x", false)]
        [TestCase("xx", true)]
        [TestCase("xax", false)]
        [TestCase("xaxx", false)]
        public void doubleX(string str, bool expected)
        {
            _warmup2.doubleX(str).ShouldBe(expected);
        }

        [Test]
        [TestCase("Hello", "Hlo")]
        [TestCase("Hi", "H")]
        [TestCase("Heeololeo", "Hello")]
        [TestCase("HiHiHi", "HHH")]
        [TestCase("", "")]
        [TestCase("Greetings", "Getns")]
        [TestCase("Chocoate", "Coot")]
        [TestCase("pi", "p")]
        [TestCase("Hello Kitten", "HloKte")]
        [TestCase("hxaxpxpxy", "happy")]
        public void stringBits(String str, string expected)
        {
            _warmup2.stringBits(str).ShouldBe(expected);
        }

        [Test]
        [TestCase("Code", "CCoCodCode")]
        [TestCase("abc", "aababc")]
        [TestCase("ab", "aab")]
        [TestCase("x", "x")]
        [TestCase("fade", "ffafadfade")]
        [TestCase("There", "TThTheTherThere")]
        [TestCase("Kitten", "KKiKitKittKitteKitten")]
        [TestCase("Bye", "BByBye")]
        [TestCase("Good", "GGoGooGood")]
        [TestCase("Bad", "BBaBad")]
        public void stringSplosion(String str, string expected)
        {
            _warmup2.stringSplosion(str).ShouldBe(expected);
        }

        [Test]
        [TestCase("hixxhi", 1)]
        [TestCase("xaxxaxaxx", 1)]
        [TestCase("axxxaaxx", 2)]
        [TestCase("xxaxxaxxaxx", 3)]
        [TestCase("xaxaxaxx", 0)]
        [TestCase("xxxx", 2)]
        [TestCase("13121312", 1)]
        [TestCase("11212", 1)]
        [TestCase("13121311", 0)]
        [TestCase("1717171", 2)]
        [TestCase("hi", 0)]
        [TestCase("h", 0)]
        [TestCase("", 0)]
        public void last2(String str, int expected)
        {
            _warmup2.last2(str).ShouldBe(expected);
        }

        [Test]
        [TestCase(new[] { 1, 2, 9 }, 1)]
        [TestCase(new[] { 1, 9, 9 }, 2)]
        [TestCase(new[] { 1, 9, 9, 3, 9 }, 3)]
        [TestCase(new[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new[] { 4, 2, 4, 3, 1 }, 0)]
        [TestCase(new[] { 9, 2, 4, 3, 1 }, 1)]
        public void arrayCount9(int[] nums, int expected)
        {
            _warmup2.arrayCount9(nums).ShouldBe(expected);
        }

        [Test]
        [TestCase(new[] { 1, 2, 9, 3, 4 }, true)]
        [TestCase(new[] { 1, 2, 3, 4, 9 }, false)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, false)]
        [TestCase(new[] { 9, 2, 3 }, true)]
        [TestCase(new[] { 1, 9, 9 }, true)]
        [TestCase(new[] { 1, 2, 3 }, false)]
        [TestCase(new[] { 1, 9 }, true)]
        [TestCase(new[] { 5, 5 }, false)]
        [TestCase(new[] { 2 }, false)]
        [TestCase(new[] { 9 }, true)]
        [TestCase(new int[] { }, false)]
        [TestCase(new[] { 3, 9, 2, 3, 3 }, true)]
        public void arrayFront9(int[] nums, bool expected)
        {
            _warmup2.arrayFront9(nums).ShouldBe(expected);
        }

        [Test]
        [TestCase(new[] { 1, 1, 2, 3, 1 }, true)]
        [TestCase(new[] { 1, 1, 2, 4, 1 }, false)]
        [TestCase(new[] { 1, 1, 2, 1, 2, 3 }, true)]
        [TestCase(new[] { 1, 1, 2, 1, 2, 1 }, false)]
        [TestCase(new[] { 1, 2, 3, 1, 2, 3 }, true)]
        [TestCase(new[] { 1, 2, 3 }, true)]
        [TestCase(new[] { 1, 1, 1 }, false)]
        [TestCase(new[] { 1, 2 }, false)]
        [TestCase(new[] { 1 }, false)]
        [TestCase(new int[] { }, false)]
        public void array123(int[] nums, bool expected)
        {
            _warmup2.array123(nums).ShouldBe(expected);
        }

        [Test]
        [TestCase("xxcaazz", "xxbaaz", 3)]
        [TestCase("abc", "abc", 2)]
        [TestCase("abc", "axc", 0)]
        [TestCase("hello", "he", 1)]
        [TestCase("he", "hello", 1)]
        [TestCase("h", "hello", 0)]
        [TestCase("", "hello", 0)]
        [TestCase("aabbccdd", "abbbxxd", 1)]
        [TestCase("aaxxaaxx", "iaxxai", 3)]
        [TestCase("iaxxai", "aaxxaaxx", 3)]
        public void stringMatch(String a, String b, int expected)
        {
            _warmup2.stringMatch(a, b).ShouldBe(expected);
        }

        [Test]
        [TestCase("xxHxix", "xHix")]
        [TestCase("abxxxcd", "abcd")]
        [TestCase("xabxxxcdx", "xabcdx")]
        [TestCase("xKittenx", "xKittenx")]
        [TestCase("Hello", "Hello")]
        [TestCase("xx", "xx")]
        [TestCase("x", "x")]
        [TestCase("", "")]
        public void stringX(String str, string expected)
        {
            _warmup2.stringX(str).ShouldBe(expected);
        }

        [Test]
        [TestCase("kitten", "kien")]
        [TestCase("Chocolate", "Chole")]
        [TestCase("CodingHorror", "Congrr")]
        [TestCase("yak", "ya")]
        [TestCase("ya", "ya")]
        [TestCase("y", "y")]
        [TestCase("", "")]
        [TestCase("ThisThatTheOther", "ThThThth")]
        public void altPairs(String str, string expected)
        {
            _warmup2.altPairs(str).ShouldBe(expected);
        }

        [Test]
        [TestCase("yakpak", "pak")]
        [TestCase("pakyak", "pak")]
        [TestCase("yak123ya", "123ya")]
        [TestCase("yak", "")]
        [TestCase("yakxxxyak", "xxx")]
        [TestCase("HiyakHi", "HiHi")]
        [TestCase("xxxyakyyyakzzz", "xxxyyzzz")]
        public void stringYak(String str, string expected)
        {
            _warmup2.stringYak(str).ShouldBe(expected);
        }

        [Test]
        [TestCase(new[] { 6, 6, 2 }, 1)]
        [TestCase(new[] { 6, 6, 2, 6 }, 1)]
        [TestCase(new[] { 6, 7, 2, 6 }, 1)]
        [TestCase(new[] { 6, 6, 2, 6, 7 }, 2)]
        [TestCase(new[] { 1, 6, 3 }, 0)]
        [TestCase(new[] { 6, 1 }, 0)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new[] { 3, 6, 7, 6 }, 1)]
        [TestCase(new[] { 3, 6, 6, 7 }, 2)]
        [TestCase(new[] { 6, 3, 6, 6 }, 1)]
        [TestCase(new[] { 6, 7, 6, 6 }, 2)]
        [TestCase(new[] { 1, 2, 3, 5, 6 }, 0)]
        [TestCase(new[] { 1, 2, 3, 6, 6 }, 1)]
        public void array667(int[] nums, int expected)
        {
            _warmup2.array667(nums).ShouldBe(expected);
        }

        [Test]
        [TestCase(new[] { 1, 1, 2, 2, 1 }, true)]
        [TestCase(new[] { 1, 1, 2, 2, 2, 1 }, false)]
        [TestCase(new[] { 1, 1, 1, 2, 2, 2, 1 }, false)]
        [TestCase(new[] { 1, 1, 2, 2, 1, 2, 1 }, true)]
        [TestCase(new[] { 1, 2, 1 }, true)]
        [TestCase(new[] { 1, 1, 1 }, false)]
        [TestCase(new[] { 1, 1 }, true)]
        [TestCase(new[] { 1 }, true)]
        [TestCase(new int[] { }, true)]
        public void noTriples(int[] nums, bool expected)
        {
            _warmup2.noTriples(nums).ShouldBe(expected);
        }

        [Test]
        [TestCase(new[] { 1, 2, 7, 1 }, true)]
        [TestCase(new[] { 1, 2, 8, 1 }, false)]
        [TestCase(new[] { 2, 7, 1 }, true)]
        [TestCase(new[] { 3, 8, 2 }, true)]
        [TestCase(new[] { 2, 7, 3 }, true)]
        [TestCase(new[] { 2, 7, 4 }, false)]
        [TestCase(new[] { 2, 7, -1 }, true)]
        [TestCase(new[] { 2, 7, -2 }, false)]
        [TestCase(new[] { 4, 5, 3, 8, 0 }, true)]
        [TestCase(new[] { 2, 7, 5, 10, 4 }, true)]
        [TestCase(new[] { 2, 7, -2, 4, 9, 3 }, true)]
        [TestCase(new[] { 2, 7, 5, 10, 1 }, false)]
        [TestCase(new[] { 2, 7, -2, 4, 10, 2 }, false)]
        [TestCase(new[] { 1, 1, 4, 9, 0 }, false)]
        [TestCase(new[] { 1, 1, 4, 9, 4, 9, 2 }, true)]
        public void has271(int[] nums, bool expected)
        {
            _warmup2.has271(nums).ShouldBe(expected);
        }
    }
}
