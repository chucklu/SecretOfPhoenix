using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Hunter
{
    public enum ActionType
    {
        Buy,
    }

    public class CustomAction
    {
        public ActionType ActionType { get; set; }

        public int ActionTargetId { get; set; }
    }

    public class Player
    {
        public Dictionary<string, int> Items = new Dictionary<string, int>();

        public Dictionary<int, CustomAction> ActionList = new Dictionary<int, CustomAction>();

        public Dictionary<int, Minion> MinionList = new Dictionary<int, Minion>();

        public Player()
        {
            Items.Add("金币", 10);
            
            InitActions();
        }

        public void InitMinions()
        {
            MinionList.Add(1, new _01BalloonMerchant());
        }


        public void InitActions()
        {
            ActionList.Add(1, new CustomAction() {ActionType = ActionType.Buy, ActionTargetId = 6});
        }

        public void DoAction(CustomAction action)
        {
            var minion = MinionList[action.ActionTargetId];
            minion.Action(this,action);
        }
    }
}
