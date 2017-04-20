using NUnit.Framework;
using Shouldly;

namespace CodingBat.Tests
{
    [TestFixture]
    public class Warmup1Tests
    {
        private Warmup1Test _warmup1 = new Warmup1Test();

        [Test]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]
        public void sleepIn(bool weekday, bool vacation, bool expected)
        {
            _warmup1.sleepIn(weekday, vacation).ShouldBe(expected);
        }

        [Test]
        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, false)]
        public void monkeyTrouble(bool aSmile, bool bSmile, bool expected)
        {
            _warmup1.monkeyTrouble(aSmile, bSmile).ShouldBe(expected);
        }

        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]
        [TestCase(-1, 2, -1)]
        [TestCase(3, 3, 12)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 1)]
        [TestCase(3, 4, 7)]
        public void sumDouble(int a, int b, int expected)
        {
            _warmup1.sumDouble(a, b).ShouldBe(expected);
        }

        [Test]
        [TestCase(19, 2)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]
        [TestCase(22, 2)]
        [TestCase(25, 8)]
        [TestCase(30, 18)]
        [TestCase(0, 21)]
        [TestCase(1, 20)]
        [TestCase(2, 19)]
        [TestCase(-1, 22)]
        [TestCase(-2, 23)]
        [TestCase(50, 58)]
        public void diff21(int n, int expected)
        {
            _warmup1.diff21(n).ShouldBe(expected);
        }

        [Test]
        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]
        [TestCase(true, 21, true)]
        [TestCase(false, 21, false)]
        [TestCase(false, 20, false)]
        [TestCase(true, 23, true)]
        [TestCase(false, 23, false)]
        [TestCase(true, 20, false)]
        [TestCase(false, 12, false)]
        public void parrotTrouble(bool talking, int hour, bool expected)
        {
            _warmup1.parrotTrouble(talking, hour).ShouldBe(expected);
        }

        [Test]
        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true)]
        [TestCase(10, 1, true)]
        [TestCase(10, 10, true)]
        [TestCase(8, 2, true)]
        [TestCase(8, 3, false)]
        [TestCase(10, 42, true)]
        [TestCase(12, -2, true)]
        public void makes10(int a, int b, bool expected)
        {
            _warmup1.makes10(a, b).ShouldBe(expected);
        }

        [Test]
        [TestCase(93, true)]
        [TestCase(90, true)]
        [TestCase(89, false)]
        [TestCase(110, true)]
        [TestCase(111, false)]
        [TestCase(121, false)]
        [TestCase(-101, false)]
        [TestCase(-209, false)]
        [TestCase(190, true)]
        [TestCase(209, true)]
        [TestCase(0, false)]
        [TestCase(0, false)]
        [TestCase(-50, false)]
        [TestCase(191, true)]
        [TestCase(189, false)]
        [TestCase(200, true)]
        [TestCase(210, true)]
        [TestCase(211, false)]
        [TestCase(290, false)]
        public void nearHundred(int n, bool expected)
        {
            _warmup1.nearHundred(n).ShouldBe(expected);
        }

        [Test]
        [TestCase(1, -1, false, true)]
        [TestCase(-1, 1, false, true)]
        [TestCase(-4, -5, true, true)]
        [TestCase(-4, -5, false, false)]
        [TestCase(-4, 5, false, true)]
        [TestCase(-4, 5, true, false)]
        [TestCase(1, 1, false, false)]
        [TestCase(-1, -1, false, false)]
        [TestCase(1, -1, true, false)]
        [TestCase(-1, 1, true, false)]
        [TestCase(1, 1, true, false)]
        [TestCase(-1, -1, true, true)]
        [TestCase(5, -5, false, true)]
        [TestCase(-6, 6, false, true)]
        [TestCase(-5, -6, false, false)]
        [TestCase(-2, -1, false, false)]
        [TestCase(1, 2, false, false)]
        [TestCase(-5, 6, true, false)]
        [TestCase(-5, -5, true, true)]
        public void posNeg(int a, int b, bool negative, bool expected)
        {
            _warmup1.posNeg(a, b, negative).ShouldBe(expected);
        }

        [Test]
        [TestCase("candy", "not candy")]
        [TestCase("", "not ")]
        [TestCase("not bad", "not bad")]
        [TestCase("bad", "not bad")]
        [TestCase("not", "not")]
        [TestCase("is not", "not is not")]
        [TestCase("no", "not no")]
        public void notString(string str, string expected)
        {
            _warmup1.notString(str).ShouldBe(expected);
        }

        [Test]
        [TestCase("kitten", 1, "ktten")]
        [TestCase("kitten", 0, "itten")]
        [TestCase("kitten", 4, "kittn")]
        [TestCase("Hi", 0, "i")]
        [TestCase("Hi", 1, "H")]
        [TestCase("code", 0, "ode")]
        [TestCase("code", 1, "cde")]
        [TestCase("code", 2, "coe")]
        [TestCase("code", 3, "cod")]
        [TestCase("chocolate", 8, "chocolat")]
        public void missingChar(string str, int n, string expected)
        {
            _warmup1.missingChar(str, n).ShouldBe(expected);
        }

        [Test]
        [TestCase("code", "eodc")]
        [TestCase("a", "a")]
        [TestCase("ab", "ba")]
        [TestCase("abc", "cba")]
        [TestCase("", "")]
        [TestCase("Chocolate", "ehocolatC")]
        [TestCase("aavJ", "Java")]
        [TestCase("hello", "oellh")]
        public void frontBack(string str, string expected)
        {
            _warmup1.frontBack(str).ShouldBe(expected);
        }

        [Test]
        [TestCase("Java", "JavJavJav")]
        [TestCase("Chocolate", "ChoChoCho")]
        [TestCase("abc", "abcabcabc")]
        [TestCase("abcXYZ", "abcabcabc")]
        [TestCase("ab", "ababab")]
        [TestCase("a", "aaa")]
        [TestCase("", "")]
        public void front3(string str, string expected)
        {
            _warmup1.front3(str).ShouldBe(expected);
        }

        [Test]
        [TestCase("cat", "tcatt")]
        [TestCase("Hello", "oHelloo")]
        [TestCase("a", "aaa")]
        [TestCase("abc", "cabcc")]
        [TestCase("read", "dreadd")]
        [TestCase("boo", "obooo")]
        public void backAround(string str, string expected)
        {
            _warmup1.backAround(str).ShouldBe(expected);
        }

        [Test]
        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(8, false)]
        [TestCase(15, true)]
        [TestCase(5, true)]
        [TestCase(9, true)]
        [TestCase(4, false)]
        [TestCase(7, false)]
        [TestCase(6, true)]
        [TestCase(17, false)]
        [TestCase(18, true)]
        [TestCase(29, false)]
        [TestCase(20, true)]
        [TestCase(21, true)]
        [TestCase(22, false)]
        [TestCase(45, true)]
        [TestCase(99, true)]
        [TestCase(100, true)]
        [TestCase(101, false)]
        [TestCase(121, false)]
        [TestCase(122, false)]
        [TestCase(123, true)]
        public void or35(int n, bool expected)
        {
            _warmup1.or35(n).ShouldBe(expected);
        }

        [Test]
        [TestCase("kitten", "kikittenki")]
        [TestCase("Ha", "HaHaHa")]
        [TestCase("abc", "ababcab")]
        [TestCase("ab", "ababab")]
        [TestCase("a", "aaa")]
        [TestCase("", "")]
        [TestCase("Logic", "LoLogicLo")]
        public void front22(string str, string expected)
        {
            _warmup1.front22(str).ShouldBe(expected);
        }

        [Test]
        [TestCase("hi there", true)]
        [TestCase("hi", true)]
        [TestCase("hello hi", false)]
        [TestCase("he", false)]
        [TestCase("h", false)]
        [TestCase("", false)]
        [TestCase("ho hi", false)]
        [TestCase("hi ho", true)]
        public void startHi(string str, bool expected)
        {
            _warmup1.startHi(str).ShouldBe(expected);
        }

        [Test]
        [TestCase(120, -1, true)]
        [TestCase(-1, 120, true)]
        [TestCase(2, 120, false)]
        [TestCase(-1, 100, false)]
        [TestCase(-2, -2, false)]
        [TestCase(120, 120, false)]
        public void icyHot(int temp1, int temp2, bool expected)
        {
            _warmup1.icyHot(temp1, temp2).ShouldBe(expected);
        }

        [Test]
        [TestCase(12, 99, true)]
        [TestCase(21, 12, true)]
        [TestCase(8, 99, false)]
        [TestCase(99, 10, true)]
        [TestCase(20, 20, true)]
        [TestCase(21, 21, false)]
        [TestCase(9, 9, false)]
        public void in1020(int a, int b, bool expected)
        {
            _warmup1.in1020(a, b).ShouldBe(expected);
        }

        [Test]
        [TestCase(13, 20, 10, true)]
        [TestCase(20, 19, 10, true)]
        [TestCase(20, 10, 13, true)]
        [TestCase(1, 20, 12, false)]
        [TestCase(19, 20, 12, true)]
        [TestCase(12, 20, 19, true)]
        [TestCase(12, 9, 20, false)]
        [TestCase(12, 18, 20, true)]
        [TestCase(14, 2, 20, true)]
        [TestCase(4, 2, 20, false)]
        [TestCase(11, 22, 22, false)]
        public void hasTeen(int a, int b, int c, bool expected)
        {
            _warmup1.hasTeen(a, b, c).ShouldBe(expected);
        }

        [Test]
        [TestCase(13, 99, true)]
        [TestCase(21, 19, true)]
        [TestCase(13, 13, false)]
        [TestCase(14, 20, true)]
        [TestCase(20, 15, true)]
        [TestCase(16, 17, false)]
        [TestCase(16, 9, true)]
        [TestCase(16, 18, false)]
        [TestCase(13, 19, false)]
        [TestCase(13, 20, true)]
        [TestCase(6, 18, true)]
        [TestCase(99, 13, true)]
        [TestCase(99, 99, false)]
        public void loneTeen(int a, int b, bool expected)
        {
            _warmup1.loneTeen(a, b).ShouldBe(expected);
        }

        [Test]
        [TestCase("adelbc", "abc")]
        [TestCase("adelHello", "aHello")]
        [TestCase("adedbc", "adedbc")]
        [TestCase("abcdel", "abcdel")]
        [TestCase("add", "add")]
        [TestCase("ad", "ad")]
        [TestCase("a", "a")]
        [TestCase("", "")]
        [TestCase("del", "del")]
        [TestCase("adel", "a")]
        [TestCase("aadelbb", "aadelbb")]
        public void delDel(string str, string expected)
        {
            _warmup1.delDel(str).ShouldBe(expected);
        }

        [Test]
        [TestCase("mix snacks", true)]
        [TestCase("pix snacks", true)]
        [TestCase("piz snacks", false)]
        [TestCase("nix", true)]
        [TestCase("ni", false)]
        [TestCase("n", false)]
        [TestCase("", false)]
        public void mixStart(string str, bool expected)
        {
            _warmup1.mixStart(str).ShouldBe(expected);
        }

        [Test]
        [TestCase("ozymandias", "oz")]
        [TestCase("bzoo", "z")]
        [TestCase("oxx", "o")]
        [TestCase("oz", "oz")]
        [TestCase("ounce", "o")]
        [TestCase("o", "o")]
        [TestCase("abc", "")]
        [TestCase("", "")]
        [TestCase("zoo", "")]
        [TestCase("aztec", "z")]
        [TestCase("zzzz", "z")]
        [TestCase("oznic", "oz")]
        public void startOz(string str, string expected)
        {
            _warmup1.startOz(str).ShouldBe(expected);
        }

        [Test]
        [TestCase(1, 2, 3, 3)]
        [TestCase(1, 3, 2, 3)]
        [TestCase(3, 2, 1, 3)]
        [TestCase(9, 3, 3, 9)]
        [TestCase(3, 9, 3, 9)]
        [TestCase(3, 3, 9, 9)]
        [TestCase(8, 2, 3, 8)]
        [TestCase(-3, -1, -2, -1)]
        [TestCase(6, 2, 5, 6)]
        [TestCase(5, 6, 2, 6)]
        [TestCase(5, 2, 6, 6)]
        public void intMax(int a, int b, int c, int expected)
        {
            _warmup1.intMax(a, b, c).ShouldBe(expected);
        }

        [Test]
        [TestCase(8, 13, 8)]
        [TestCase(13, 8, 8)]
        [TestCase(13, 7, 0)]
        [TestCase(7, 13, 0)]
        [TestCase(9, 13, 9)]
        [TestCase(13, 8, 8)]
        [TestCase(10, 12, 10)]
        [TestCase(11, 10, 10)]
        [TestCase(5, 21, 5)]
        [TestCase(0, 20, 0)]
        [TestCase(10, 10, 0)]
        public void close10(int a, int b, int expected)
        {
            _warmup1.close10(a, b).ShouldBe(expected);
        }

        [Test]
        [TestCase(30, 31, true)]
        [TestCase(30, 41, false)]
        [TestCase(40, 50, true)]
        [TestCase(40, 51, false)]
        [TestCase(39, 50, false)]
        [TestCase(50, 39, false)]
        [TestCase(40, 39, true)]
        [TestCase(49, 48, true)]
        [TestCase(50, 40, true)]
        [TestCase(50, 51, false)]
        [TestCase(35, 36, true)]
        [TestCase(35, 45, false)]
        public void in3050(int a, int b, bool expected)
        {
            _warmup1.in3050(a, b).ShouldBe(expected);
        }

        [Test]
        [TestCase(11, 19, 19)]
        [TestCase(19, 11, 19)]
        [TestCase(11, 9, 11)]
        [TestCase(9, 21, 0)]
        [TestCase(10, 21, 10)]
        [TestCase(21, 10, 10)]
        [TestCase(9, 11, 11)]
        [TestCase(23, 10, 10)]
        [TestCase(20, 10, 20)]
        [TestCase(7, 20, 20)]
        [TestCase(17, 16, 17)]
        public void max1020(int a, int b, int expected)
        {
            _warmup1.max1020(a, b).ShouldBe(expected);
        }

        [Test]
        [TestCase("Hello", true)]
        [TestCase("Heelle", true)]
        [TestCase("Heelele", false)]
        [TestCase("Hll", false)]
        [TestCase("e", true)]
        [TestCase("", false)]
        public void stringE(string str, bool expected)
        {
            _warmup1.stringE(str).ShouldBe(expected);
        }

        [Test]
        [TestCase(7, 17, true)]
        [TestCase(6, 17, false)]
        [TestCase(3, 113, true)]
        [TestCase(114, 113, false)]
        [TestCase(114, 4, true)]
        [TestCase(10, 0, true)]
        [TestCase(11, 0, false)]
        public void lastDigit(int a, int b, bool expected)
        {
            _warmup1.lastDigit(a, b).ShouldBe(expected);
        }

        [Test]
        [TestCase("Hello", "HeLLO")]
        [TestCase("hi there", "hi thERE")]
        [TestCase("hi", "HI")]
        [TestCase("woo hoo", "woo HOO")]
        [TestCase("xyz12", "xyZ12")]
        [TestCase("x", "X")]
        [TestCase("", "")]
        public void endUp(string str, string expected)
        {
            _warmup1.endUp(str).ShouldBe(expected);
        }

        [Test]
        [TestCase("Miracle", 2, "Mrce")]
        [TestCase("abcdefg", 2, "aceg")]
        [TestCase("abcdefg", 3, "adg")]
        [TestCase("Chocolate", 3, "Cca")]
        [TestCase("Chocolates", 3, "Ccas")]
        [TestCase("Chocolates", 4, "Coe")]
        [TestCase("Chocolates", 100, "C")]
        public void everyNth(string str, int n, string expected)
        {
            _warmup1.everyNth(str, n).ShouldBe(expected);
        }
    }
}
