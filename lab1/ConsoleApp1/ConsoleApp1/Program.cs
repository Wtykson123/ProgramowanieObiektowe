using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ułamek : IEquatable<Ułamek>, IComparable<Ułamek>
    {
        public int Licznik { get; private set; }
       public int Mianownik { get; private set; }


        public Ułamek()
        {

        }


        public Ułamek(int licznik, int mianownik)
        {
            Mianownik = mianownik;
            Licznik = licznik;
        }

        public Ułamek(Ułamek ułamek)
        {

            Licznik = ułamek.Licznik;
            Mianownik = ułamek.Mianownik;
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
            if (other == null) return -1;
            if (other == this) return 0;

            int diff = this.Licznik - other.Mianownik;

            if (diff > 0) return +1;
            if (diff < 0) return -1;

            return 0; 
        }


        public readonly struct Fraction
        {
            public readonly int licznik;
            public readonly int mianownik;

            public Fraction (int numerator, int denominator)
            {
                if (denominator == 0)
                {
                    throw new ArgumentException("Nie może być równy zero.", nameof(denominator));
                }
                licznik = numerator;
                mianownik = denominator;
            }
            public static Fraction operator +(Fraction a) => a;
            public static Fraction operator -(Fraction a) => new Fraction(-a.licznik, a.mianownik);

            public static Fraction operator +(Fraction a, Fraction b)
                => new Fraction(a.licznik * b.mianownik + b.licznik * a.mianownik, a.mianownik * b.mianownik);

            public static Fraction operator -(Fraction a, Fraction b)
                => a + (-b);

            public static Fraction operator *(Fraction a, Fraction b)
                => new Fraction(a.licznik * b.licznik, a.mianownik * b.mianownik);

            public static Fraction operator /(Fraction a, Fraction b)
            {
                if (b.licznik == 0)
                {
                    throw new DivideByZeroException();
                }
                return new Fraction(a.licznik * b.mianownik, a.mianownik * b.licznik);
            }

            public override string ToString() => $"{licznik} / {mianownik}";
        }

        public static class OperatorOverloading
        {
            public static void Main()
            {
                Console.WriteLine("Hello World!");
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
           
        }
    }

    }
