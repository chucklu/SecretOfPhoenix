﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Rogue
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        static void Run()
        {
            var attackArray = new int[] {5, 1, 0, 2, 0, 5, 2};
            int[,] attackChangeArray = new int[,]
            {
                {1, 2, 1, -2, 2, 0, -3}, //attack the first enemy minion
                {-2, 1, -2, -2, 3, -2, -2}, //attack the second enemy minion
                {0, -2, 1, 1, 2, -2, -2},
                {0, 0, 1, 1, -2, 3, -3},
                {-3, 0, -1, 2, 1, -2, 3},
                {2, 3, 2, -3, 0, 1, 1},
                {-2, -2, -1, -3, 0, 3, 1},
            };

            var solutionArray = new int[] {1, 2, 3, 0, 3, 2};
            for (int i = 0; i < solutionArray.Length; i++)
            {
                var attackChange = attackChangeArray.GetRow(i);
                var count = solutionArray[i];
                AddTwoArray(attackArray, attackChange, count);
            }

            string str = string.Join(",", attackArray);
            Console.WriteLine(str);
        }

        static void AddTwoArray(int[] array1, int[] array2,int count)
        {
            if (array1.Length != array2.Length)
            {
                throw new ArgumentException($"{nameof(array1)}'s Length != {nameof(array1)}'s Length ");
            }

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] += array2[i] * count;
            }
        }
    }
}
