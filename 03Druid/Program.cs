using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Druid
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Run();
                RunChineseSolution();
            }
            catch(Exception ex)
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
            Console.WriteLine(DruidSolution.EnglishSolution);
            Console.WriteLine(DruidSolution.EnglishSolution.Length);
            Console.WriteLine(DruidSolution.TestSolution.Length);
        }

        static void RunChineseSolution()
        {
            Board board = new Board();

            var str = DruidSolution.ChineseSolution;
            str = str.Replace("\r\n", " ");
            var array = str.Split(' ');
            int count = 0;
            foreach (var item in array)
            {
                count++;
                var moveType = DruidSolution.ChineseDictionary[item];
                board.Move(moveType);
                Console.WriteLine($"{count:D2}, {item}, {board}");
            }

        }
    }
}
