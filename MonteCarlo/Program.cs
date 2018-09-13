using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How big would you like the array to be?");
            double[] arr = new double[Convert.ToInt32(Console.ReadLine())];
            double inCircle = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                var PB = new PiBaby();
                arr[i] = PB.Hipotanus();
                if (arr[i] <= 1.0)
                {
                    inCircle++;
                }
            }
            double piAproximation = (inCircle / arr.Length) * 4.0;
            Console.WriteLine($"The number of values inside the circle were {inCircle},\n" +
                $"The number calculated to pi for you is {piAproximation}\n" +
                $"The difference between real pi and your pi is: {Math.Abs(Math.PI - piAproximation)}");
        }
    }
}
