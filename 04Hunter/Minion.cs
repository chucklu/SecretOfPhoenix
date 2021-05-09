using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Hunter
{
    public class Minion
    {
        public int Id { get; set; }

        public virtual void Buy()
        {

        }

        public virtual void Sell()
        {

        }

        public virtual void Trade()
        {
        }

        public void Action(Player player,CustomAction action)
        {
            switch (action.ActionType)
            {
                case ActionType.Buy:
                    Buy();
                    break;
            }
        }
    }
}
