using System;
using System.Text;

namespace _03Druid
{
    public enum MoveType
    {
        Left,
        Middle,
        Right
    }

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

        public void Move(MoveType moveType)
        {
            switch (moveType)
            {
                case MoveType.Left:
                    MoveLeft();
                    break;
                case MoveType.Middle:
                    MoveMiddle();
                    break;
                case MoveType.Right:
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
