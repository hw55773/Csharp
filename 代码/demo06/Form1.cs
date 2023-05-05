using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //绘图类
        Graphics g = null;

        /// <summary>
        /// 绘图事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //实例化
            g = e.Graphics;
            Pen pen = new Pen(Color.Transparent,3);
            pen.DashStyle=System.Drawing.Drawing2D.DashStyle.Dot;

            if (lstAllpoint.Count >= 2)
            {
                //画直线
                g.DrawLines(pen, lstAllpoint.ToArray());
            }
            for (int i = 0; i < lstAllpoint.Count; i++)
            {
                Color rndcolor = Color.FromArgb(r.Next(255), r.Next(255),r.Next(255));
                SolidBrush sb = new SolidBrush(rndcolor);
                g.FillEllipse(sb, lstAllpoint[i].X - 15, lstAllpoint[i].Y - 15, 30, 30);
            }

        }
        
        //存放移动过程中所有的点
        List<Point> lstAllpoint = new List<Point>();
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
          /*  lstAllpoint.Add(e.Location);
            this.Invalidate();*/
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lstAllpoint.Add(e.Location);
            this.Invalidate();
        }
        Random r = new Random();

        /// <summary>
        /// 随机的添加点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void timer1_Tick(object sender, EventArgs e)
        {
           int x= r.Next(this.Width);
            int y = r.Next(this.Height);


            lstAllpoint.Add(new Point(r.Next(this.Width), r.Next(this.Height)));
            this.Invalidate();
        }

    }
}
