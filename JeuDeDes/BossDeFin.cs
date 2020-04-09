using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeDes
{
    public class BossDeFin : Monstre
    {
        /// <summary>
        /// Le nombre de point de vie du joueur.
        /// </summary>
        public int PointsDeVie { get; private set; }

        /// <summary>
        /// Indique si le Boss est vivant.
        /// </summary>
        public override bool EstVivant
        {
            get
            {
                return PointsDeVie > 0;
            }
        }

        public BossDeFin()
        {
            PointsDeVie = 250;
        }

        public override void Attaque(Joueur joueur)
        {
            joueur.SubitDégats(De.LanceLeDe25());
            Console.WriteLine("Joueur SubitDégats : PDV {0}", joueur.PointsDeVie);
        }

        public void SubitDégats(int degatsSubit)
        {
            PointsDeVie -= degatsSubit;
        }
    }
}
