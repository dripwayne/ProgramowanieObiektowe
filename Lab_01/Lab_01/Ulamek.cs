using System;
namespace Lab_01
{
    public class Ulamek
    {
        private double licznik;
        protected double Licznik { get => licznik; }
        
        private double mianownik;
        protected double Mianownik { get => mianownik; }
       
        public Ulamek()
        {
            licznik = 0;
            mianownik = 0;
        }
        public Ulamek(double licznik, double mianownik)
        {
            this.licznik = licznik;
            this.mianownik = mianownik;
        }
        public Ulamek( Ulamek ulamek)
        {
            licznik = ulamek.licznik;
            mianownik = ulamek.mianownik;
        }

        public override string ToString()
        {
            return $"{licznik}/{mianownik}";
        }

        public static Ulamek operator +(Ulamek a) => a;
        public static Ulamek operator -(Ulamek a) => new Ulamek(-a.licznik, a.mianownik);
        public static Ulamek operator +(Ulamek a, Ulamek b) => new Ulamek(a.licznik * b.mianownik + b.licznik * a.mianownik, a.mianownik * b.mianownik);
        public static Ulamek operator -(Ulamek a, Ulamek b) => new Ulamek(a.licznik * b.Mianownik - b.licznik * a.mianownik, a.mianownik * b.mianownik);
        public static Ulamek operator *(Ulamek a, Ulamek b) => new Ulamek(a.licznik * b.licznik, a.mianownik * b.mianownik);
        public static Ulamek operator /(Ulamek a, Ulamek b) => new Ulamek(a.licznik * b.mianownik, a.mianownik * b.licznik);

        public bool IEquatable(Ulamek other)
        {
            return licznik == other.licznik && mianownik == other.mianownik;
        }

        public double IComparable(Ulamek other)
        {
            return (this - other).licznik;
        }

        static Ulamek CompareTo(Ulamek other
            )
        {
            double Y;
            Y = (this.licznik * other.mianownik - this.mianownik * other.licznik);
            return (Y > 0) ? true : false;
        }

        public double ZaokDol()
        {
            return (double)Math.Floor((licznik / mianownik));
        }
        public double ZaokGor()
        {
            return (double)Math.Ceiling(licznik / mianownik);
        }
          }
 
}
