using System;
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
            int[,] array = new int[7, 7]
            {
                {1, 2, 1, -2, 2, 0, -3},//attack the first enemy minion
                {-2, 1, -2, -2, 3, -2, -2},//attack the second enemy minion
                {0, -2, 1, 1, 2, -2, -2},
                {0, 0, 1, 1, -2, 3, -3},
                {-3, 0, -1, 2, 1, -2, 3},
                {2, 3, 2, -3, 0, 1, 1},
                {-2, -2, -1, -3, 0, 3, 1},
            };
        }
    }
}
