using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apprentissage
{
    class Rectangle2 : figureGeometrique //Heritage
    {
        private double hauteur;
        private double largeur;

        public Rectangle2(double hauteur, double largeur, double p) : base(p) //Appel du constructeur de la superclasse figureGeometrique
        {
            this.hauteur = hauteur;
            this.largeur = largeur;
        }

        public Rectangle2 (Rectangle2 autreRect) : base(autreRect.position) //Copie de surface
        {
            hauteur = autreRect.hauteur;
            largeur = autreRect.largeur;
        }

        
        public override double surface()
        {
            return hauteur * largeur * constante;
        }

        public String toString()
        {
            return "Rectangle: " + hauteur + " x " + largeur + " x " + position;
        }

        public bool equals(Object autreObjet)
        {
            if (autreObjet == null)
                return false;
            else
            {
                if (autreObjet.GetType() != GetType()) return false;
                else
                {
                    Rectangle2 rect = (Rectangle2)autreObjet;
                    return (largeur == rect.largeur && hauteur == rect.hauteur);
                }
            }
               
        }


    }
}
