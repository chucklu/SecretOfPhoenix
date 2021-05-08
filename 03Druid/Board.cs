using System;
using System.Text;

namespace _03Druid
{
    public class Board
    {
        public int LeftHealth { get; set; } = 9;

        public int MiddleHealth { get; set; } = 99;

        public int RightHealth { get; set; } = 999;

        public void TurnLeft()
        {
            if (LeftHealth > 1)//should not deduct to zero
            {
                LeftHealth--;
            }
            else
            {
                RightHealth = RightHealth - 3;
            }
        }

        public void Move()
        {
            MiddleHealth--;
        }

        public void TurnRight()
        {
            RightHealth--;
        }

        public void Action(ActionType moveType)
        {
            switch (moveType)
            {
                case ActionType.TurnLeft:
                    TurnLeft();
                    break;
                case ActionType.Move:
                    Move();
                    break;
                case ActionType.TurnRight:
                    TurnRight();
                    break;
                default:
                    throw new ArgumentException($"{moveType} is not supported");
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{LeftHealth},{MiddleHealth},{RightHealth}");
            return stringBuilder.ToString();
        }
    }
}
