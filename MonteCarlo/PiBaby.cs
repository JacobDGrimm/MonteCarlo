using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    class PiBaby
    {
        Random rnd = new Random();

        public double Hipotanus()
        {
            double[] coord = new double[2];

            for (int i = 0; i < coord.Length; i++)
            {
                coord[i] = rnd.NextDouble();
            }

            double hipot = 
        }
    }
}
