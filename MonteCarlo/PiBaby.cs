using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    class PiBaby
    {
        

        public double Hipotanus()
        {
            double[] coord = new double[2];

            for (int i = 0; i < coord.Length; i++)
            {
                Random rnd = new Random();
                coord[i] = rnd.NextDouble();
            }

            double hipot = (Math.Sqrt(Math.Pow(coord[0], 2) + Math.Pow(coord[1], 2)));
            return hipot;
        }
    }
}
