using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeDes
{
    public class Joueur
    {
        private De de;
        public int PointDeVie { get; private set; }
        public bool estVivant { get { return PointDeVie > 0; } }
        public Joueur()
        {
            de = new De();
            PointDeVie = 150;
        }
        public void Attaque(MonstreFacile monstre)
        {
            Console.WriteLine("Joueur attaque" );
            if (LanceLeDe() >= monstre.LanceLeDe())
            {
                monstre.SubitDegats();
            }
        }
        public int LanceLeDe()
        {
            return de.LanceLeDe();
        }
        public void SubitDegats(int degats)
        {
            if (!bouclier())
            {
                PointDeVie -= degats;
            }
        }
        /// <summary>
        /// Bouclier se déclenche si Dé >= 2 -> true
        /// Pas de dégâts
        /// </summary>
        /// <returns></returns>
        private bool bouclier()
        {
            return LanceLeDe() <= 2;
        }
    }
}
