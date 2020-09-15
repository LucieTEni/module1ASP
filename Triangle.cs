using System;

namespace App1Test
{
    internal class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override double Aire => CalculDeLaire(A, B, C);

        private double CalculDeLaire(int a, int b, int c)
        {
            double p = (a + b + c)/2d;
            double aire = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return aire;
        }

        public override double Perimetre => A+B+C;

        public override string ToString()
        {
            return string.Format("Une triangle de cote A= {0} B= {1} C= {2}", A, B, C) + Environment.NewLine + base.ToString();
        }
    }
}