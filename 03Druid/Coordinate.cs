using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Druid
{
    class Point
    {
        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }

    /// <summary>
    /// assume the start cube is
    /// leftBottomCorner[0,0],
    /// rightBottomCorner[1,0],
    /// rightTopCorner[1,1],
    /// leftTopCorner[0,1]
    /// </summary>
    class Coordinate
    {
        public List<Point> PointList;

        public Point LeftBottomCorner = new Point(0, 0);
        public Point RightBottomCorner = new Point(1, 0);
        public Point RightTopCorner = new Point(1, 1);
        public Point LeftTopCorner = new Point(0, 1);

        public int MinX { get; set; } = 0;

        public int MaxX { get; set; } = 1;

        public int MinY { get; set; } = 0;

        public int MaxY { get; set; } = 1;

        public Coordinate()
        {
            PointList = new List<Point>()
            {
                LeftBottomCorner,
                RightBottomCorner,
                RightTopCorner,
                LeftTopCorner
            };
        }

        public void MoveLeft()
        {
            //move left, x = x-1, y not change
            foreach (var point in PointList)
            {
                point.X = point.X -1;
                if (point.X < MinX)
                {
                    MinX = point.X;
                }
            }
        }

        public void MoveMiddle()
        {
            //move up, y = y+1, x not change
            foreach (var point in PointList)
            {
                point.Y = point.Y + 1;
                if (point.Y > MaxY)
                {
                    MaxY = point.Y;
                }
            }
        }

        public void MoveRight()
        {
            //move right, x = x+1, y not change
            foreach (var point in PointList)
            {
                point.X = point.X + 1;
                if (point.X > MaxX)
                {
                    MaxX = point.X;
                }
            }
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
            stringBuilder.Append($"{LeftBottomCorner},{RightBottomCorner},{RightTopCorner},{LeftTopCorner}");
            return stringBuilder.ToString();
        }

    }
}
