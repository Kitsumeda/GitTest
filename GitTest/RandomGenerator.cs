using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class RandomGenerator
    {
        private static Random random;
        private RandomGenerator()
        {

        }

        public static int NextInt(int number)
        {
            if (random == null)
            {
                random = new Random();
            }

            return random.Next(number);
        }
    }
}
