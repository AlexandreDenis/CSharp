using System;

namespace Isima.TD.Dimensions
{
    public struct Cercle : IFormePlane
    {
        public double Rayon;

        public Cercle(double rayon)
        {
            Rayon = rayon;
        }

        public double Surface
        {
            get { return Math.PI * Rayon * Rayon; }
        }

        public double Perimetre
        {
            get { return Math.PI * 2 * Rayon; }
        }

        public void Agrandir(double ratio)
        {
            this.Rayon *= ratio;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Calcul : surface={0} périmètre={1}", this.Surface, this.Perimetre);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
