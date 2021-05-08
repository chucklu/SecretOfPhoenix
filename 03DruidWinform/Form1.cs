using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _03DruidWinform
{
    public partial class Form1 : Form
    {
        int multiple = 8;

        /// <summary>
        /// 最外层的矩形的宽
        /// </summary>
        int width = 60;//4*15

        /// <summary>
        /// 最外层的矩形的高度
        /// </summary>
        int height = 72;//4*18=72

        /// <summary>
        /// width/w 是垂直方向的格子数量 60/4=15  宽度被15等分
        /// </summary>
        int w = 4;

        /// <summary>
        /// height/h 是水平方向的格子数量 72/4=18  高度被18等分
        /// </summary>
        int h = 4;

        Pen bluePen = new Pen(Color.Blue);

        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Form长：{0}，宽：{1}", this.Width, this.Height);
            this.Multiple();
            DrawGrid(width, height, w, h, e);

            var moves = WinformSolution.GetChineseSolution();
            DrawPath(e, moves);
        }

        private void DrawPath(PaintEventArgs e, List<List<_03Druid.Point>> list)
        {
            DrawStartPoint(e);
            //List<Rectangle> l = new List<Rectangle>();
            //Rectangle r;
            //r = new Rectangle(0, w, 2 * w, h);
            //l.Add(r);
            //r = new Rectangle(3 * w, 0, 2 * w, h);
            //l.Add(r);
            //r = new Rectangle(2 * w, 3 * w, 2 * w, h);
            //l.Add(r);
            //foreach (Rectangle r1 in l)
            //{
            //    e.Graphics.FillRectangle(new SolidBrush(Color.Black), r1);
            //}
        }

        private void DrawStartPoint(PaintEventArgs e)
        {
            var r = new Rectangle(0, w, 2 * w, h);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), r);
        }

        /// <summary>
        /// 将比例放大
        /// </summary>
        private void Multiple()
        {
            width = width * multiple;
            height = height * multiple;
            w = w * multiple;
            h = h * multiple;
        }

        /// <summary>
        /// 画网格
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        private void DrawGrid(int width, int height, int w, int h, PaintEventArgs e)
        {
            Point p1 = new Point();
            Point p2 = new Point();

            p1.X = 0; p2.X = width;
            for (int y = 0; y <= height; y = y + h)
            {
                p1.Y = y; p2.Y = y;
                DrawLine(p1, p2, e);
            }
            p1.Y = 0; p2.Y = height;
            for (int x = 0; x <= width; x = x + w)
            {
                p1.X = x; p2.X = x;
                DrawLine(p1, p2, e);
            }
        }

        /// <summary>
        /// 画直线
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        private void DrawLine(Point p1, Point p2, PaintEventArgs e)
        {
            e.Graphics.DrawLine(bluePen, p1, p2);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("X={0},Y={1}", e.X, e.Y);
        }
    }
}
