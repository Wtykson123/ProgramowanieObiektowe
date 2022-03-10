using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ułamek : IEquatable<Ułamek>, IComparable<Ułamek>
    {
        private int Licznik { get; set; }
        private int Mianownik { get; set; }


        public Ułamek()
        {

        }


        public Ułamek(int licznik, int mianownik)
        {
            Mianownik = mianownik;
            Licznik = licznik;
        }

        public Ułamek(Ułamek licznik, Ułamek mianownik)
        {

            Licznik = licznik.Licznik;
            Mianownik = mianownik.Mianownik;
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public bool Equals(Ułamek other)
        {
            return this.Licznik / this.Mianownik == other.Licznik / other.Mianownik;
        }

        public int CompareTo(Ułamek other)
        {
            return String.Compare(this.Licznik, compare.Fraction );
        }

       
        public readonly struct Fraction
        {
            private readonly int num;
            private readonly int den;

            public Fraction(int numerator, int denominator)
            {
                if (denominator == 0)
                {
                    throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
                }
                num = numerator;
                den = denominator;
            }
            public static Fraction operator +(Fraction a) => a;
            public static Fraction operator -(Fraction a) => new Fraction(-a.num, a.den);

            public static Fraction operator +(Fraction a, Fraction b)
                => new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);

            public static Fraction operator -(Fraction a, Fraction b)
                => a + (-b);

            public static Fraction operator *(Fraction a, Fraction b)
                => new Fraction(a.num * b.num, a.den * b.den);

            public static Fraction operator /(Fraction a, Fraction b)
            {
                if (b.num == 0)
                {
                    throw new DivideByZeroException();
                }
                return new Fraction(a.num * b.den, a.den * b.num);
            }

            public override string ToString() => $"{num} / {den}";
        }

        public static class OperatorOverloading
        {
            public static void Main()
            {
                var a = new Fraction(5, 4);
                var b = new Fraction(1, 2);
                Console.WriteLine(-a); 
                Console.WriteLine(a + b);  
                Console.WriteLine(a - b);
                Console.WriteLine(a * b); 
                Console.WriteLine(a / b); 
            }
        }
        public void TestMethod1()
        {
            Ułamek u = new Ułamek(3, 4);
        }
    }

    }
