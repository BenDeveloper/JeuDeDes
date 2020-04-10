using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeDes
{
    public class Joueur
    {
        /// <summary>
        /// Le nombre de point de vie du joueur.
        /// </summary>
        public int PointsDeVie { get; private set; }
        
        /// <summary>
        /// Indique si le joueur est vivant.
        /// </summary>
        public bool EstVivant
        {
            get
            {
                return PointsDeVie > 0;
            }
        }

        public int MonstresFacileTués { get; private set; }

        public int MonstresDifficileTués { get; private set; }

        public int PointsGagnés { get; private set; }

        /// <summary>
        /// Constructeur de la classe Joueur.
        /// </summary>
        public Joueur()
        {
            PointsDeVie = 150;
        }

        public void Attaque(Monstre monstre)
        {
            if (monstre is MonstreDifficile)
            {
                MonstresDifficileTués++;
                PointsGagnés += 2;
                Console.WriteLine("MonstresDifficileTués : {0}", MonstresDifficileTués);
            }
            else if (monstre is MonstreFacile)
            {
                MonstresFacileTués++;
                PointsGagnés++;
                Console.WriteLine("MonstresFacileTués : {0}", MonstresFacileTués);
            }

            monstre.EstVivant = false;
        }

        public void Attaque(BossDeFin boss)
        {
            boss.SubitDégats(De.LanceLeDe25());
            Console.WriteLine("Boss SubitDégats : PDV {0}", boss.PointsDeVie);
        }

        public void SubitDégats(int degatsSubit)
        {
            if (De.LanceLeDe() > 2)
            {
                PointsDeVie -= degatsSubit;
            }
        }
    }
}
