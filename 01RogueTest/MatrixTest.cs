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

        [Test]
        public void Test20210518002()
        {
            var M = Matrix<double>.Build;
            var V = Vector<double>.Build;

            var attackArray = new double[] {5, 1, 0, 2, 0, 5, 2};
            var attackVector = V.DenseOfArray(attackArray);

            var list = new List<Vector<double>>()
            {
                V.DenseOfArray(new double[] {1, 2, 1, -2, 2, 0, -3}),//attack the first enemy minion
                V.DenseOfArray(new double[] {-2, 1, -2, -2, 3, -2, -2}),//attack the second enemy minion
                V.DenseOfArray(new double[] {0, -2, 1, 1, 2, -2, -2}),
                V.DenseOfArray(new double[] {0, 0, 1, 1, -2, 3, -3}),
                V.DenseOfArray(new double[] {-3, 0, -1, 2, 1, -2, 3}),
                V.DenseOfArray(new double[] {2, 3, 2, -3, 0, 1, 1}),
                V.DenseOfArray(new double[] {-2, -2, -1, -3, 0, 3, 1}),
            };


            var solutionArray = new double[] {1, 2, 3, 0, 0, 3, 2}; //1*7

            for (int i = 0; i < solutionArray.Length; i++)
            {
                var temp = list[i].Multiply(solutionArray[i]);
                attackVector = attackVector.Add(temp);
            }

            Console.WriteLine(attackVector);
            Console.WriteLine(IsValid(attackVector));

        }

        [Test]
        public void Test20210520001()
        {
            for (int i = 1; i <= 7; i++)
            {
                var variable = $"i{i}";
                Console.WriteLine($"for (int {variable} = 0; {variable} <= 4; {variable}++)");
                Console.WriteLine("{");
            }

            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("}");
            }
        }

        [Test]
        public void Test20210520002()
        {
            for (int i1 = 0; i1 <= 4; i1++)
            {
                for (int i2 = 0; i2 <= 4; i2++)
                {
                    for (int i3 = 0; i3 <= 4; i3++)
                    {
                        for (int i4 = 0; i4 <= 4; i4++)
                        {
                            for (int i5 = 0; i5 <= 4; i5++)
                            {
                                for (int i6 = 0; i6 <= 4; i6++)
                                {
                                    for (int i7 = 0; i7 <= 4; i7++)
                                    {
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private bool IsValid(Vector<double> vector)
        {
            bool flag = true;
            for (int i = 0; i < vector.Count; i++)
            {
                var item = vector[i];
                while (item < 0)
                {
                    item += 10;
                }

                while (item > 10)
                {
                    item -= 10;
                }

                vector[i] = item;
            }

            var item0 = vector[0];
            foreach (var item in vector)
            {
                if (Math.Abs(item0 - item) > 0.000001)
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }
    }
}
