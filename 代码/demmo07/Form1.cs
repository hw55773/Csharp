using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demmo07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Graphics g=null;
        bool isDrawing =false;
        List<SwpuGeometry> lstGeo = new List<SwpuGeometry>();
    

        SwpuRecantg rect;
        SwpuFreeLine freeline;
        SwpuEllipse ellipse;
        SwpuPolygon triangle;
        SwpuLpolygon Ltriangle;
        SwpuPentadram pentadram;
        SwpuArrow arrow;
        int drawIndex = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            for (int i = 0; i < drawIndex; i++)
            {
                lstGeo[i].Draw(g);
            }
          
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            if (rbtnRect.Checked)
            {
                rect = new SwpuRecantg();
                rect.startPoint = e.Location;
                
                lstGeo.Add(rect);

            }
            else if (rbtnFreeLine.Checked)
            {
                freeline = new SwpuFreeLine();
                freeline.lstpoint.Add(e.Location);
              
                lstGeo.Add(freeline);
            }
            else if (rbtnEllipse.Checked)
            {
                ellipse = new SwpuEllipse();

                ellipse.startPoint = e.Location;
                
                lstGeo.Add(ellipse);
            }
            else if (rbtnPolygon.Checked)
            {
                triangle= new SwpuPolygon();

                triangle.startPoint = e.Location;
                
                lstGeo.Add(triangle);
            }
            else if (rbtnLtriangle.Checked)
            {
                Ltriangle = new SwpuLpolygon();

                Ltriangle.startPoint = e.Location;

                lstGeo.Add(Ltriangle);
            }
            else if (rbtnPentadram.Checked)
            {
                pentadram= new SwpuPentadram();

                pentadram.startPoint = e.Location;
                
                lstGeo.Add(pentadram);
            }
            else if (rbtArrow.Checked)
            {
                arrow = new SwpuArrow();
                arrow.startPoint = e.Location;
                lstGeo.Add(arrow);
            }
            drawIndex = lstGeo.Count;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (rbtnRect.Checked)
                {
                    SwpuRecantg rect = (SwpuRecantg)lstGeo[lstGeo.Count - 1];
                    rect.w = e.Location.X - rect.startPoint.X;
                    rect.h = e.Location.Y - rect.startPoint.Y;
                }
                else if (rbtnFreeLine.Checked)
                {
                    SwpuFreeLine freeLine = (SwpuFreeLine)lstGeo[lstGeo.Count - 1];
                    freeline.lstpoint.Add(e.Location);
                }
                else if (rbtnEllipse.Checked)
                {
                    SwpuEllipse ellipse = (SwpuEllipse)lstGeo[lstGeo.Count - 1];
                    ellipse.w = e.Location.X - ellipse.startPoint.X;
                    ellipse.h = e.Location.Y - ellipse.startPoint.Y;
                }
                else if (rbtnPolygon.Checked)
                {
                    SwpuPolygon triangle= (SwpuPolygon)lstGeo[lstGeo.Count - 1];
                    triangle.triangle1 = new Point((e.Location.X+triangle.startPoint.X)/2,triangle.startPoint.Y);
                    triangle.triangle2 = new Point(triangle.startPoint.X, e.Location.Y);
                    triangle.triangle3 = new Point(e.Location.X,e.Location.Y);
                }
                else if (rbtnLtriangle.Checked)
                {
                    SwpuLpolygon triangle = (SwpuLpolygon)lstGeo[lstGeo.Count - 1];
                    Ltriangle.triangle1 = new Point( Ltriangle.startPoint.X, Ltriangle.startPoint.Y);
                    Ltriangle.triangle2 = new Point(Ltriangle.startPoint.X, e.Location.Y);
                    Ltriangle.triangle3 = new Point(e.Location.X, e.Location.Y);
                }
                else if(rbtnPentadram.Checked)
                {
                    SwpuPentadram pentadram = (SwpuPentadram)lstGeo[lstGeo.Count - 1];
                    pentadram.pentadramPonints[1] = new Point((e.Location.X + pentadram.startPoint.X) / 2,pentadram.startPoint.Y);
                    pentadram.pentadramPonints[2] = new Point(pentadram.startPoint.X, pentadram.pentadramPonints[0].Y);
                    pentadram.pentadramPonints[3] = new Point((pentadram.pentadramPonints[2].X+ pentadram.pentadramPonints[1].X)/2,e.Location.Y);
                    pentadram.pentadramPonints[4] = new Point((pentadram.pentadramPonints[0].X + pentadram.pentadramPonints[1].X)/2, e.Location.Y);
                    pentadram.pentadramPonints[0] = new Point(e.Location.X, (e.Location.Y + pentadram.startPoint.Y) / 2);
                }
                else if (rbtArrow.Checked)
                {
                    SwpuArrow arrow = (SwpuArrow)lstGeo[lstGeo.Count - 1];
                    arrow.Point1 = new Point(arrow.startPoint.X, (arrow.startPoint.Y + e.Location.Y) / 2);
                    arrow.Point2 = new Point((arrow.startPoint.X + e.Location.X) / 2, arrow.startPoint.Y);
                    arrow.Point3 = new Point(e.Location.X, arrow.Point1.Y);
                    arrow.Point4 = new Point((arrow.startPoint.X + arrow.Point2.X) / 2, e.Location.Y);
                    arrow.Point5 = new Point((e.Location.X + arrow.Point2.X) / 2, e.Location.Y);
                    arrow.Point6 = new Point(arrow.Point4.X, arrow.Point1.Y);
                    arrow.Point7 = new Point(arrow.Point5.X, arrow.Point1.Y);
                }
                this.Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            if (drawIndex < lstGeo.Count - 1)
            {
                drawIndex++;
            }
            this.Invalidate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (drawIndex > 0)
            {
                drawIndex--;
            }
            this.Invalidate();
        }
    }
}
