using System;

namespace App1Test
{
    public class Cercle : Forme
    {
        public int Rayon { get; set; }

        public override double Aire => Math.PI * (Rayon * Rayon);

        public override double Perimetre => 2 * Rayon * Math.PI;
        public override string ToString()
        {
            return string.Format("Un cercle de rayon {0}", Rayon) + Environment.NewLine + base.ToString();
        }
    }
}