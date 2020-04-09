using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeDes
{
    public abstract class Monstre
    {
        /// <summary>
        /// Indique si le monstre est vivant.
        /// </summary>
        public virtual bool EstVivant { get; set; }

        public Monstre()
        {
            EstVivant = true;
        }

        public abstract void Attaque(Joueur joueur);
    }
}
