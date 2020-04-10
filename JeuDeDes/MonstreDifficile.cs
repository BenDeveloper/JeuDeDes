using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeDes
{
    public class MonstreDifficile : Monstre
    {
        public override void Attaque(Joueur joueur)
        {
            SortMagique(joueur);
        }

        private void SortMagique(Joueur joueur)
        {
            int de = De.LanceLeDe();

            if (de < 6)
            {
                joueur.SubitDégats(de * 5);
                Console.WriteLine("Joueur SubitDégats monstre difficile : PDV {0}", joueur.PointsDeVie);
            }
        }
    }
}
