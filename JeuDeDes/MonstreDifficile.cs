using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeDes
{
    public class MonstreDifficile : MonstreFacile
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
            }
        }
    }
}
