﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeDes
{
    public class MonstreFacile : Monstre
    {
        public override void Attaque(Joueur joueur)
        {
            joueur.SubitDégats(10); 
        }
    }
}
