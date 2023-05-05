using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayTrace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
         ViewPlan vp=new ViewPlan();
            vp.LeftTopLoc = new Point3D(-1,1,0);
            vp.W = 2;
            vp.H = 2;
            vp.ResH = 800;
            vp.ResW = 800;
            //x方向，y方向每个像素点所占的长度
            double xStep = vp.W / vp.ResW;
            double yStep = vp.H / vp.ResH;
            //球体
            Point3D center = new Point3D(0, 0, -10);
            double radius = 1;
            Sphere sphere= new Sphere(center,radius);


            //最终图片 
            Bitmap bmp =new Bitmap(vp.ResW,vp.ResH);



            //摄像机位置
            Point3D eye=new Point3D(0,0,20);

            //从摄像机所在位置，向成像平面的每一个像素点生成一条光线
            for(int i=0; i<vp.ResW; i++) {
               for(int j=0;j<vp.ResH; j++)
                {
                   // 生成一条光线
                    Point3D pixelLoc=new Point3D(vp.LeftTopLoc.X+xStep*i,vp.LeftTopLoc.Y-yStep*j,0);
                    Vector3D dir = pixelLoc - eye;
                    dir.Normalize();//归一化
                    Ray ray = new Ray(eye, dir);
                    //每条光线与球体求交
                    HitRrcord hr = ray.Hit(sphere);
                    if( hr.IsHit==true ) 
                    {
                        bmp.SetPixel(i, j, Color.YellowGreen);
                    }
                    else
                    {
                        bmp.SetPixel(i, j, Color.White);
                    }
                }
            }
            //设置背景图片
            this.BackgroundImage=bmp;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
