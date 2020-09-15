using System;
namespace App1Test
{
    internal class Rectangle : Forme
    {
        public int Largeur { get; set; }
        public int Longueur { get; set; }

        public override double Aire => Longueur*Largeur;

        public override double Perimetre => (Longueur*2)+(Largeur*2);
        public override string ToString()
        {
            return string.Format("Un rectangle de longueur {0} et de largeur {1}", Longueur, Largeur)+ Environment.NewLine + base.ToString();
        }
    }
}