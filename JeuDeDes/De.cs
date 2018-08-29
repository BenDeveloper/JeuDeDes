using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeDes
{
    public class De
    {
        Random random;

        public De()
        {
            random = new Random();
        }
        public int LanceLeDe()
        {
            return random.Next(1, 7);
        }
    }
}
