using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeDes
{
    public class MonstreFacile
    {
        private const int degats = 10;
        protected De de;
        public bool estVivant { get; private set; }
        public MonstreFacile()
        {
            de = new De();
            estVivant = true;
        }
        public virtual void Attaque(Joueur joueur)
        {
            Console.WriteLine("Monstre facile attaque");
            if (joueur.LanceLeDe() < LanceLeDe())
            {
                Console.WriteLine("Joueur subit dégâts : - 10pts");
                joueur.SubitDegats(degats);
            }
        }
        public void SubitDegats()
        {
            estVivant = false;
            Console.WriteLine("Monstre vaincu");
        }

        public int LanceLeDe()
        {
            return de.LanceLeDe();
        }

    }
}
