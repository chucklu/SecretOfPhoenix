using System;
using System.Collections.Generic;
using System.Text;

namespace _03Druid
{
    public class Point
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

    public class CustomRectangle : ICloneable
    {
        public List<Point> PointList;

        public CustomRectangle()
        {
            PointList = new List<Point>()
            {
                LeftBottomCorner,
                RightBottomCorner,
                RightTopCorner,
                LeftTopCorner
            };
        }

        public int MinX { get; set; } = 0;

        public int MaxX { get; set; } = 1;

        public int MinY { get; set; } = 0;

        public int MaxY { get; set; } = 1;

        public Point LeftBottomCorner = new Point(0, 0);
        public Point RightBottomCorner = new Point(1, 0);
        public Point RightTopCorner = new Point(1, 1);
        public Point LeftTopCorner = new Point(0, 1);

        public void MoveWest()
        {
            //move left, x = x-1, y not change
            foreach (var point in PointList)
            {
                point.X = point.X - 1;
                if (point.X < MinX)
                {
                    MinX = point.X;
                }
            }
        }

        public void MoveNorth()
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

        public void MoveEast(int step=1)
        {
            //move right, x = x+1, y not change
            foreach (var point in PointList)
            {
                point.X = point.X + step;
                if (point.X > MaxX)
                {
                    MaxX = point.X;
                }
            }
        }

        public void MoveSouth()
        {
            //move up, y = y-1, x not change
            foreach (var point in PointList)
            {
                point.Y = point.Y - 1;
                if (point.Y < MinY)
                {
                    MinY = point.Y;
                }
            }
        }


        public object Clone()
        {
            var temp = new CustomRectangle();
            temp.LeftTopCorner = new Point(LeftTopCorner.X, LeftTopCorner.Y);
            temp.RightTopCorner = new Point(RightTopCorner.X, RightTopCorner.Y);
            temp.LeftBottomCorner = new Point(LeftBottomCorner.X, LeftBottomCorner.Y);
            temp.RightBottomCorner = new Point(RightBottomCorner.X, RightBottomCorner.Y);
            temp.PointList = new List<Point>()
            {
                temp.LeftTopCorner,
                temp.RightTopCorner,
                temp.LeftBottomCorner,
                temp.RightBottomCorner
            };
            return temp;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{LeftBottomCorner},{RightBottomCorner},{RightTopCorner},{LeftTopCorner}");
            return stringBuilder.ToString();
        }
    }

    /// <summary>
    /// assume the start cube is
    /// leftBottomCorner[0,0],
    /// rightBottomCorner[1,0],
    /// rightTopCorner[1,1],
    /// leftTopCorner[0,1]
    /// </summary>
    public class Coordinate
    {
        public DirectionType Direction = DirectionType.North;

        public CustomRectangle CustomRectangle;

        public List<CustomRectangle> AllMoves = new List<CustomRectangle>();

        public Coordinate()
        {
            CustomRectangle = new CustomRectangle();
            var temp = CustomRectangle.Clone() as CustomRectangle;
            AllMoves.Add(temp);
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
            return CustomRectangle.ToString();
        }

        public void TurnLeft()
        {
            switch (Direction)
            {
                case DirectionType.North:
                    Direction = DirectionType.West;
                    break;
                case DirectionType.West:
                    Direction = DirectionType.South;
                    break;
                case DirectionType.South:
                    Direction = DirectionType.East;
                    break;
                case DirectionType.East:
                    Direction = DirectionType.North;
                    break;
            }
        }

        public void TurnRight()
        {
            switch (Direction)
            {
                case DirectionType.North:
                    Direction = DirectionType.East;
                    break;
                case DirectionType.East:
                    Direction = DirectionType.South;
                    break;
                case DirectionType.South:
                    Direction = DirectionType.West;
                    break;
                case DirectionType.West:
                    Direction = DirectionType.North;
                    break;
            }
        }

        public void Move()
        {
            switch (Direction)
            {
                case DirectionType.North:
                    MoveNorth();
                    break;
                case DirectionType.East:
                 MoveEast();
                    break;
                case DirectionType.South:
                    MoveSouth();
                    break;
                case DirectionType.West:
                   MoveWest();
                    break;
            }

            var temp = CustomRectangle.Clone() as CustomRectangle;
            AllMoves.Add(temp);
        }

        public void MoveNorth()
        {
            CustomRectangle.MoveNorth();
        }

        public void MoveEast()
        {
            CustomRectangle.MoveEast();
        }

        public void MoveSouth()
        {
            CustomRectangle.MoveSouth();
        }

        public void MoveWest()
        {
            CustomRectangle.MoveWest();
        }
    }
}
