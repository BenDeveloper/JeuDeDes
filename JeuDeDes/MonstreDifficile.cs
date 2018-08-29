using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeDes
{
    public class MonstreDifficile : MonstreFacile
    {
        private const int degatsSort = 5;
        public override void Attaque(Joueur joueur)
        {
            Console.WriteLine("Monstre difficile attaque");
            base.Attaque(joueur);
            joueur.SubitDegats(SortMagique());
        }
        private int SortMagique()
        {
            int valeur = de.LanceLeDe();
            if (valeur == 6)
                return 0;
            int d = degatsSort * valeur;
            Console.WriteLine("Sort magique : " + d);
            return d;
        }
    }
}
