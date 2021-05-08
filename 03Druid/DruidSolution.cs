using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Druid
{
    public class DruidSolution
    {
        /// <summary>
        /// https://www.hearthstonetopdecks.com/new-secret-achievement-and-card-back-from-barrens-mysteries-of-the-phoenix-full-solution/
        /// </summary>
        public static string EnglishSolution = @"RRRMMRM
MRMRRRM
RRRMMRM
MRRRMMR
MRRRMMM
MRRRMMM
RMMRM
MRMRRRM
MMMMR
MMMRM
RRRMMRRRM
MRMMR
MRRRMRM
RRRMRRRMR
MMMMRRR
MMMRRRM
RMRRRMR
MMRRRMR
MRRRMRRRM
RMRMRRR
MM";

        public static string TestSolution = @"RRRMMRM
MRMRRRM";

        /// <summary>
        /// https://zhuanlan.zhihu.com/p/370273345
        /// </summary>
        public static string ChineseSolution = @"左转 直行 直行 右转 直行 直行
右转 直行 左转 直行 左转 直行
直行 右转 直行 直行 左转 直行
直行 右转 直行 左转 直行 直行
直行 直行 左转 直行 直行 直行
右转 直行 直行 右转 直行 直行
右转 直行 左转 直行 直行 直行
直行 直行 右转 直行 直行 直行
右转 直行 左转 直行 直行 左转
直行 直行 右转 直行 直行 右转
直行 左转 直行 右转 直行 左转
直行 左转 直行 右转 直行 直行
直行 直行 左转 直行 直行 直行
左转 直行 右转 直行 左转 直行
右转 直行 直行 左转 直行 右转
直行 左转 直行 左转 直行 右转
直行 右转 直行 左转 直行 直行";

        public static Dictionary<string, MoveType> ChineseDictionary = new Dictionary<string, MoveType>()
        {
            {"左转", MoveType.Left},
            {"直行", MoveType.Middle},
            {"右转", MoveType.Right},
        };

        public static Dictionary<string, MoveType> EnglishDictionary = new Dictionary<string, MoveType>()
        {
            {"L", MoveType.Left},
            {"M", MoveType.Middle},
            {"R", MoveType.Right},
        };
    }
}
