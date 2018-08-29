using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeDes
{
    /* Le principe est de voir combien notre héros va pouvoir tuer de monstres faciles et de monstres difficiles avant de mourir, 
    en ayant perdu tous ses points de vie (mon héros démarre avec 150 points de vie). 
    Chaque monstre facile tué rapporte 1 point, chaque monstre difficile tué en rapporte 2.
    Un monstre aléatoire arrive, le héros attaque le monstre ; puis si le monstre a survécu il attaque à son tour le héros et ceci jusqu'à ce que mort s'en suive. */
    public class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            Jeu1();
            Console.ReadLine();
        }

        private static void Jeu1()
        {
            int PointsFacile = 0;
            int PointsDifficile = 0;

            Joueur joueur = new Joueur();

            Console.WriteLine(" ---  DEBUT JEU DE DE ---");

            while (joueur.estVivant)
            {
                MonstreFacile monstre = FabriqueDeMonstre();
                while (monstre.estVivant && joueur.estVivant)
                {
                    joueur.Attaque(monstre);
                    if (monstre.estVivant)
                        monstre.Attaque(joueur);
                }

                if (joueur.estVivant)
                {
                    if (monstre is MonstreDifficile)
                    {
                        Console.WriteLine("PDV : " + joueur.PointDeVie);
                        PointsDifficile++;
                    }
                    else
                    {
                        Console.WriteLine("PDV : " + joueur.PointDeVie);
                        PointsFacile++;
                    }
                }
                else
                {
                    Console.WriteLine("Vous êtes mort...");
                    break;
                }
            }
            Console.WriteLine("Monstres faciles tués : {0}", PointsFacile);
            Console.WriteLine("Monstres difficiles tués : {0}", PointsDifficile * 2);
            Console.WriteLine("Vous avez points : {0}", PointsFacile + PointsDifficile * 2);
        }
        private static MonstreFacile FabriqueDeMonstre()
        {
            if (random.Next(2) == 0)
                return new MonstreFacile();
            else
                return new MonstreDifficile();
        }
    }
}
