﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03Druid;

namespace _03DruidWinform
{
    class WinformSolution
    {
        internal static List<List<Point>> GetChineseSolution()
        {
            Coordinate coordinate = new Coordinate();

            var str = DruidSolution.ChineseSolution;
            str = str.Replace("\r\n", " ");
            var array = str.Split(' ');
            int count = 0;
            Console.WriteLine($"{count:D2}, , {coordinate}");
            foreach (var item in array)
            {
                count++;
                var moveType = DruidSolution.ChineseDictionary[item];

                coordinate.Action(moveType);
                //Console.WriteLine($"{count:D2}, {item}, {coordinate}");
            }
            Console.WriteLine($"({coordinate.MinX},{coordinate.MinY}),({coordinate.MaxX},{coordinate.MaxY})");

            var moves = coordinate.AllMoves;
            foreach (var move in moves)
            {
                foreach (var point in move)
                {
                    point.X = point.X + 2;
                }
            }

            return moves;
        }
    }
}
