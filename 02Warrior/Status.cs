using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretOfPhoenix
{
    public class Status
    {
        public int Id { get; set; }

        /// <summary>
        /// 野猪人数量 身材3/3
        /// </summary>
        public int LeftQuilboarCount { get; set; }

        public int RightQuilboarCount { get; set; }

        /// <summary>
        /// 兽人数量 身材1/1
        /// </summary>
        public int LeftOrcCount { get; set; }

        public int RightOrcCount { get; set; }

        public bool IsValid()
        {
            if (LeftQuilboarCount > LeftOrcCount && LeftOrcCount > 0)
            {
                return false;
            }

            if (RightQuilboarCount > RightOrcCount && RightOrcCount > 0)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(LeftQuilboarCount);
            stringBuilder.Append(LeftOrcCount);
            stringBuilder.Append("LR");
            stringBuilder.Append(RightQuilboarCount);
            stringBuilder.Append(RightOrcCount);
            stringBuilder.Append($" , {Id:D2},isValid = {IsValid()}");
            return stringBuilder.ToString();
        }
    }

}
