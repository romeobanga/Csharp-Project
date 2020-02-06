using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apprentissage
{
    class Program
    {
        static void Main(string[] args)
        {
           // bool saisieValid = false;
            double hauteur, largeur;
          //  double H, L;

         //   while (!saisieValid)
            {
                Console.WriteLine("1er Rectangle.....");
                Console.WriteLine("Veuillez saisir la hauteur .....");
                String haut = Console.ReadLine();

                /*   if (double.TryParse(haut, out hauteur))
                   {
                       saisieValid = true;
                      // hauteur = Convert.ToDouble(haut);
                   }
                   else
                   {
                       saisieValid = false;
                       Console.WriteLine("Veuillez saisir un double !!!");
                   }*/
                hauteur = Convert.ToDouble(haut);

                Console.WriteLine("Veuillez saisir la largeur .....");
                String larg = Console.ReadLine();

              /*  if (double.TryParse(larg, out largeur))
                {
                    saisieValid = true;
                  //  largeur = Convert.ToDouble(larg);
                }
                else
                {
                    saisieValid = false;
                    Console.WriteLine("Veuillez saisir un double !!!");
                }*/
                largeur = Convert.ToDouble(larg);
                

            }

           // Console.WriteLine(hauteur);
          //  Console.WriteLine(largeur);
            // hauteur = 2;

            Rectangle2 r = new Rectangle2(hauteur, largeur, hauteur);
            figureGeometrique.constante = 10;
            Console.WriteLine("Paramètres Rectangle: " + r.toString());
            Console.WriteLine("Surface Rectangle: " + r.surface());

            figureGeometrique fig = new Rectangle2(hauteur, largeur, hauteur);
            Console.WriteLine("Surface Polymorphique Rectangle: " + fig.surface());
            Console.WriteLine("Comparaison de 2 Rectangles: " + r.equals(fig));

            Rectangle2 rect = new Rectangle2(r); //Constructeur de copie
            Console.WriteLine("Paramètres Rectangle Copié: " + rect.toString());
            Console.WriteLine("Surface Rectangle Copié: " + rect.surface());


            /*Console.WriteLine("2e Rectangle.....");
            Console.WriteLine("Veuillez saisir la hauteur .....");
            String haute = Console.ReadLine();

            largeur = Convert.ToDouble(larg);*/
            Rectangle rect2 = new Rectangle();
            rect2.setHauteur(hauteur);
            rect2.setLargeur(largeur);
            Console.WriteLine("Paramètres Rectangle2 Hauteur: " + rect2.getHauteur());
            Console.WriteLine("Paramètres Rectangle2 Largeur: " + rect2.getLargeur());
            Console.WriteLine("Surface Rectangle2 : " + rect2.surface());

            rect2.rotation();

            //Gestion des exceptions
            int nbEssai = 1;
            double bases;
            do
            {
                Console.WriteLine("Veuillez entrer la base.... ");
                try
                {
                    String bas = Console.ReadLine();
                    bases = Convert.ToDouble(bas);
                  //  Console.WriteLine("Bravo, vous avez entré: "+bases);
                  /*  if (double.TryParse(bas, out bases))
                    {
                        throw new System.FormatException();
                    }*/
                    if (bases == 0) { throw new ArithmeticException(); }
                    if (bases < 0)  { throw new ArgumentOutOfRangeException(); }

                }

                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Veuillez renseigner un nombre !!!");
                    nbEssai += nbEssai;
                }

                catch (ArithmeticException ex)
                {
                    Console.WriteLine("Arithmetic: "+ex.Message);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Argument: " + ex.Message);
                }


            } while (  (nbEssai!=1) );


            Console.ReadKey();

        }
    }
}
