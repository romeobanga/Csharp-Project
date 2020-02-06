using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apprentissage
{
    class figureGeometrique
    {
        protected double position;
        public static double constante;

        public figureGeometrique(double p)
        {
            position = p;
        }

        public double positionCarre()
        {
            return position * position;
        }

        public virtual double surface() //une methode qui sera redefinie dans une sous-classe
        {
            return position * 2;
        }

        static void Afficher()
        {
            Console.WriteLine("Fin du Programme....");
        }
    }
}
