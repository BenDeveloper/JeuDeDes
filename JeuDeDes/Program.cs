using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeDes
{
    public class Program
    {
        private static Monstre monstre;
        private static Joueur joueur;

        static void Main(string[] args)
        {
            DemarrerJeu();
            Console.ReadLine();
        }

        private static void DemarrerJeu()
        {
            // Nouveau joueur
            joueur = new Joueur();

            do
            {
                // Nouveau monstre aléatoire
                monstre = CreeMonstreAleatoire();

                // Lancer de dé
                int DeJoueur = De.LanceLeDe();
                int DeMonstre = De.LanceLeDe();

                while (monstre.EstVivant && joueur.EstVivant)
                {
                    if (DeJoueur >= DeMonstre)
                    {
                        joueur.Attaque(monstre);
                    }
                    else
                    {
                        DeMonstre = De.LanceLeDe();
                        DeJoueur = De.LanceLeDe();

                        if (DeMonstre > DeJoueur)
                        {
                            if (monstre is MonstreDifficile)
                            {
                                MonstreDifficile monstreDifficile = (MonstreDifficile)monstre;
                                monstreDifficile.Attaque(joueur);
                            }
                            else
                            {
                                MonstreFacile monstreFacile = (MonstreFacile)monstre;
                                monstreFacile.Attaque(joueur);
                            }
                        }
                    }
                }
            } while (joueur.EstVivant);

            Console.WriteLine("Snif, vous êtes mort...");
            Console.WriteLine("Bravo !!!Vous avez tué {0} monstres faciles et {1} monstres difficiles.Vous avez {2} points.",
                joueur.MonstresFacileTués, joueur.MonstresDifficileTués, joueur.PointsGagnés);
        }

        private static Monstre CreeMonstreAleatoire()
        {
            Random random = new Random();
            
            if (random.Next(0, 2) == 0)
            {
                monstre = new MonstreFacile();
            }
            else
            {
                monstre = new MonstreDifficile();
            }

            return monstre;
        }
    }
}
