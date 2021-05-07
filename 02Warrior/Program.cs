using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretOfPhoenix
{
    class Program
    {
        private const int maxCount = 3;

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

            int minLeftQuilboarCount = 0;
            int maxLeftQuilboarCount = maxCount;

            int minLeftOrcCount = 0;
            int maxLeftOrcCount = maxCount;

            List<Status> list = new List<Status>();
            int statusCount = 0;
            for (int i = minLeftQuilboarCount; i <= maxLeftQuilboarCount; i++)
            {
                for (int j = minLeftOrcCount; j <= maxLeftOrcCount; j++)
                {
                    statusCount++;
                    var status = new Status()
                    {
                        Id = statusCount,
                        LeftQuilboarCount = i,
                        RightQuilboarCount = maxCount - i,
                        LeftOrcCount = j,
                        RightOrcCount = maxCount - j
                    };

                    list.Add(status);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
