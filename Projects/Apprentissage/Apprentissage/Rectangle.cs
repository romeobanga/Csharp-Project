using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apprentissage
{
    class Rectangle : MouvementFigure
    {
        private double hauteur;
        private double largeur;

        public void setHauteur (double hauteur)
        {
            this.hauteur = hauteur;
        }

        public void setLargeur (double largeur)
        {
            this.largeur = largeur;
        }

        public double getHauteur() { return hauteur; }
        public double getLargeur() { return largeur; }

        public  double surface()
        {
            return largeur * hauteur;
        }

        public void rotation()
        {
            Console.WriteLine("Je tourne à 90° vers la gauche...");
        }
    }
}
