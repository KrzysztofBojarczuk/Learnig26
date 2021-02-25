using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    class Coin
    {
        private string sideUp;
        Random rand = new Random();

        public Coin()
        {

            sideUp = "orzeł";
        }

        public void Toss()
        {
            if (rand.Next(2) == 0)
            {
                sideUp = "orzeł";
            }
            else
            {
                sideUp = "reszka";
            }

        }
        public string GetSideUp()
        {
            return sideUp;
        }
    }
}
