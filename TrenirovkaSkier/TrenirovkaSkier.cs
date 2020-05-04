using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenirovkaSkier
{
    public class TrenirovkaSkier
    {
        public double Raschet(double x, double y, double z)
        {
            double result = 1;
            for (double i = x; i <= z; i = x + (x + (x / 100) * y))
            {
                result += 2;
                x = i;
            }
            Console.WriteLine("Skier ran {0} kilometrs za {1} days", z, result);
            return result;
        }
        public double Validation(double i)
        {
            while (i <= 0)
            {
                Console.WriteLine("Input correct value");
                i = double.Parse(Console.ReadLine());
                Validation(i);
            }
            return i;
        }
    }
}
