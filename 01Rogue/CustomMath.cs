using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Rogue
{
    public class CustomMath
    {
        public static int Add(int a,int b)
        {
            var result = a + b;
            if (result > 10)
            {
                result = result - 10;
            }

            if (result < 0)
            {
                result = result + 10;
            }

            return result;
        }
    }
}
