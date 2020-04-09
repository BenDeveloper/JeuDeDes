using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeDes
{
    /// <summary>
    /// Un dé à lancer.
    /// </summary>
    public static class De
    {
        private static Random de = new Random();

        public static int LanceLeDe()
        {
            return de.Next(1, 7);
        }
    }
}
