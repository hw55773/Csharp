using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demmo07
{
   
    class SwpuGeometry
    {
        public Color fillColor = Color.Red;
        public Color frameColor = Color.Yellow;
        public int frameWidth = 10;
        public DashStyle dashStyle = DashStyle.Dash;

        public virtual void Draw(Graphics g)
        { }
       
    }
    /// <summary>
    /// 矩形类
    /// </summary>
    internal class SwpuRecantg: SwpuGeometry
    {
       public Point startPoint;
       public int w;
       public int h;
      
        public override void Draw(Graphics g)
        {
            SolidBrush sb = new SolidBrush(fillColor);
            g.FillRectangle(sb,startPoint.X, startPoint.Y, w, h);

            Pen pen = new Pen(frameColor, frameWidth);
            pen.DashStyle = dashStyle;
            g.DrawRectangle(pen, startPoint.X, startPoint.Y, w, h);
            
        }

    }
    /// <summary>
    /// 自由曲线
    /// </summary>
    class SwpuFreeLine: SwpuGeometry
    {
      public  List<Point> lstpoint = new List<Point>();
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Gold, 3);
            g.DrawLines(pen, lstpoint.ToArray());
        }
    }
    /// <summary>
    /// 椭圆
    /// </summary>
    class SwpuEllipse:SwpuGeometry
    {
        public Point startPoint;
        public int w;
        public int h;
        
        public override void Draw(Graphics g)
        {
            SolidBrush sb = new SolidBrush(fillColor);
            g.FillEllipse(sb, startPoint.X, startPoint.Y, w, h);
            Pen pen = new Pen(frameColor, frameWidth);
            pen.DashStyle = dashStyle;
            g.DrawEllipse(pen, startPoint.X, startPoint.Y, w, h);
        }
    }
    /// <summary>
    /// 三角形
    /// </summary>
   class SwpuPolygon: SwpuGeometry
    {
        public Point startPoint;
        public Point triangle1;
        public Point triangle2;
        public Point triangle3;
        public override void Draw(Graphics g)
        {
            Point[] points = new Point[] {triangle1,triangle2,triangle3};
            g.FillPolygon(Brushes.Red, points);
            Pen pen = new Pen(frameColor, frameWidth);
            pen.DashStyle = dashStyle;
            g.DrawPolygon(pen,points);
        }
    }
    /// <summary>
    /// 直角三角形
    /// </summary>
    class SwpuLpolygon : SwpuGeometry
    {
        public Point startPoint;
        public Point triangle1;
        public Point triangle2;
        public Point triangle3;
        public override void Draw(Graphics g)
        {
            Point[] points = new Point[] { triangle1, triangle2, triangle3 };
            g.FillPolygon(Brushes.Red, points);
            Pen pen = new Pen(frameColor, frameWidth);
            pen.DashStyle = dashStyle;
            g.DrawPolygon(pen, points);
        }
    }
    /// <summary>
    /// 五边形
    /// </summary>
    class SwpuPentadram: SwpuGeometry
    {
        public Point startPoint;
        public Point[] pentadramPonints=new Point[5];

        public float scaleFactor = 1.0f;
        public override void Draw(Graphics g)
        {

         g.FillPolygon(Brushes.Red,pentadramPonints);
         Pen pen = new Pen(frameColor, frameWidth);
         pen.DashStyle = dashStyle;
         g.DrawPolygon(pen,pentadramPonints);


        }
    }
    /// <summary>
    /// 箭头
    /// </summary>
    class SwpuArrow : SwpuGeometry
    {
        public Point Point1;
        public Point Point2;
        public Point Point3;
        public Point Point4;
        public Point Point5;
        public Point Point6;
        public Point Point7;
        public Point startPoint; 
        
        public override void Draw(Graphics g)
        {
            //创建笔
            Pen pen = new Pen(frameColor, frameWidth);
            pen.DashStyle = dashStyle;
            //画箭头
            g.DrawPolygon(pen, new Point[] { Point1, Point2, Point3, Point7, Point5, Point4, Point6 });
            //填充箭头
            g.FillPolygon(Brushes.Red, new Point[] { Point1, Point2, Point3, Point7, Point5, Point4, Point6 });
        }
    }
}
