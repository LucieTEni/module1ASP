using System;

namespace App1Test
{
    internal class Carre : Forme
    {
        public int Longueur { get; set; }

        public override double Aire => Longueur * Longueur;

        public override double Perimetre => Longueur * 4;
        public override string ToString()
        {
            return string.Format("Un carre de {0} cm de cote", Longueur) + Environment.NewLine + base.ToString();
        }
    }
}