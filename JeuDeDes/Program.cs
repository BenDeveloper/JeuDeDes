using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeDes
{
    public class Program
    {
        private static Joueur joueur;
        private static Monstre monstre;
        private static BossDeFin boss;

        static void Main(string[] args)
        {
            DemarrerJeu1();
            Console.ReadLine();
        }

        private static void DemarrerJeu1()
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
                            monstre.Attaque(joueur);
                        }
                    }
                }

            } while (joueur.EstVivant);

            Console.WriteLine("Snif, vous êtes mort...");
            Console.WriteLine("Bravo !!!Vous avez tué {0} monstres faciles et {1} monstres difficiles.Vous avez {2} points.",
                joueur.MonstresFacileTués, joueur.MonstresDifficileTués, joueur.PointsGagnés);
        }

        private static void DemarrerJeu2()
        {
            joueur = new Joueur();
            boss = new BossDeFin();

            while (joueur.EstVivant && boss.EstVivant)
            {
                joueur.Attaque(boss);

                if (boss.EstVivant)
                {
                    boss.Attaque(joueur);
                }
            }

            if (joueur.EstVivant)
            {
                Console.WriteLine("Bravo ! Vous avez gagné.");
            }
            else if (boss.EstVivant)
            {
                Console.WriteLine("Perdu ! Le boss a gagné.");
            }
            else
            {
                Console.WriteLine("Recode batard!");
            }
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
