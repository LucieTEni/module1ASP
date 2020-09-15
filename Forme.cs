using System;
using System.Xml;

namespace App1Test
{
    public abstract class Forme
    {
        public abstract double Aire { get; }
        public abstract double Perimetre { get; }
        public override string ToString()
        {
            return string.Format("Aire = {0}", Aire)+ Environment.NewLine + string.Format("Perimetre = {0}",Perimetre) + Environment.NewLine;
        }

    }
}