using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HearthDb;
using HearthDb.Enums;

namespace _04HunterTest
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
            Print1();
        }

        static void Print1()
        {
            for (int i = 1; i <= 7; i++)
            {
                var cardId = $"BAR_763m{i}";
                PrintCards(cardId);
            }
        }

        static void Print2()
        {
            for (int i = 1; i <= 7; i++)
            {
                var cardId = $"BAR_763a{i}";
                PrintCards(cardId);
            }
        }

        static void PrintCards(string id)
        {
            var list= Cards.All.Where(x => x.Value.Id.Contains(id));
           var cards = list.Select(x => x.Value).ToList();
           foreach (var card in cards)
           {
               var name = card.GetLocName(Locale.zhCN);
               var text = card.GetLocText(Locale.zhCN);
               var str = $"//{card.Id} {name}{text}";
               Console.WriteLine(str);
           }
           Console.WriteLine();
        }
    }
}
