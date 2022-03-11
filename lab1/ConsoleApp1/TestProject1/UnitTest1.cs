using System;
using Xunit;
using static ConsoleApp1.U³amek;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {


            Fraction a = new Fraction(5, 4);
            Fraction b = new Fraction(1, 2);
            /* Console.WriteLine(-a);
             Console.WriteLine(a + b);
             Console.WriteLine(a - b);
             Console.WriteLine(a * b);
             Console.WriteLine(a / b); */
            Assert.Equal(5, a.licznik);
            Assert.Equal(4, a.mianownik);
            Assert.Equal(-1, a.mianownik - a.licznik);
            Assert.Equal(9, a.mianownik + a.licznik);
            Assert.Equal(20, a.mianownik * a.licznik);
            Assert.Equal(0, a.mianownik / a.licznik);

            

    }
        [Fact]
        public void TestujKonstruktorKopiujacy()
        {
            Fraction a = new Fraction(5, 4);
            Fraction b = new Fraction(a);
        }

        public const string Expected = "Hello World!";
    }
}
