using System;

namespace Isima.TD.Dimensions
{
    public struct Rectangle : IFormePlane
    {
        public double Largeur;
        public double Longueur;

        public Rectangle(double largeur, double longueur)
        {
            Largeur = largeur;
            Longueur = longueur;
        }

        public double Surface
        {
            get { return Largeur * Longueur; }
        }

        public double Perimetre
        {
            get { return Largeur * Longueur * 2; }
        }

        public void Agrandir(double ratio)
        {
            this.Largeur *= ratio;
            this.Longueur *= ratio;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Calcul : surface={0} périmètre={1}", this.Surface, this.Perimetre);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
