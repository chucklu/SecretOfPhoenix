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
                //RunEnglishSolution();
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
            Coordinate coordinate = new Coordinate();

            var str = DruidSolution.ChineseSolution;
            str = str.Replace("\r\n", " ");
            var array = str.Split(' ');
            int count = 0;
            Console.WriteLine($"{count:D2}, , {coordinate}");
            foreach (var item in array)
            {
                count++;
                var moveType = DruidSolution.ChineseDictionary[item];
                board.Move(moveType);
                //Console.WriteLine($"{count:D2}, {item}, {board}");

                coordinate.Action(moveType);
                Console.WriteLine($"{count:D2}, {item}, {coordinate}");
            }
            Console.WriteLine($"({coordinate.MinX},{coordinate.MinY}),({coordinate.MaxX},{coordinate.MaxY})");
        }

        static void RunEnglishSolution()
        {
            Board board = new Board();

            var str = DruidSolution.EnglishSolution;
            str = str.Replace("\r\n", string.Empty);
            str = str.Replace("RRR", "L");
            int count = 0;
            foreach (var item in str)
            {
                count++;
                var key = item.ToString();
                if (DruidSolution.EnglishDictionary.ContainsKey(key) == false)
                {
                    throw new ArgumentException($"{key} can not be recognized");
                }
                var moveType = DruidSolution.EnglishDictionary[item.ToString()];
                board.Move(moveType);
                Console.WriteLine($"{count:D2}, {item}, {board}");
            }

        }
    }
}
