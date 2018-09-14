using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    class PiBaby
    {

        


        public double Hipotanus(Random rnd)
        {
            double[] coord = new double[] { rnd.NextDouble(), rnd.NextDouble() };

            

            double hipot = (Math.Sqrt(Math.Pow(coord[0], 2) + Math.Pow(coord[1], 2)));
            return hipot;
        }
    }
}
