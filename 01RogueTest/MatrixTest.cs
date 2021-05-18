using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using NUnit.Framework;

namespace _01RogueTest
{
    [TestFixture]
    public class MatrixTest
    {
        [Test]
        public void Test20210518001()
        {
            var M = Matrix<double>.Build;
            var V = Vector<double>.Build;

            // From a 2D-array
            double[,] x = {{ 1.0, 2.0 },
                { 1.0, -1.0 }};

            double[,] y = {{ 1.0, 2.0 ,-3},
                { -1.0, 1.0 ,2.0}};
            var left = M.DenseOfArray(x);
            var right = M.DenseOfArray(y);

            var result = left.Multiply(right);
            Console.WriteLine(result);
        }
    }
}
