using System;
using System.Text;

namespace _03Druid
{
    public class Board
    {
        public int LeftHealth { get; set; } = 9;

        public int MiddleHealth { get; set; } = 99;

        public int RightHealth { get; set; } = 999;

        public void MoveLeft()
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

        public void MoveMiddle()
        {
            MiddleHealth--;
        }

        public void MoveRight()
        {
            RightHealth--;
        }

        public void Move(ActionType moveType)
        {
            switch (moveType)
            {
                case ActionType.TurnLeft:
                    MoveLeft();
                    break;
                case ActionType.Move:
                    MoveMiddle();
                    break;
                case ActionType.TurnRight:
                    MoveRight();
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
