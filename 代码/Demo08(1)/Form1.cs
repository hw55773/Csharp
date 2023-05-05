using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo08_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        Image imgGirl;
        Image[] imgEars;
        Image[] imgMoustache;
        Image[] imgGrass;
        Image[] imgYuan;
        int idx = 0;
        public enum SpecaialEffectType { None,Cat, Grass };
        SpecaialEffectType seType;
        /// <summary>
        /// 绘图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawImage(imgGirl, 0, 0);
            if (seType == SpecaialEffectType.Cat)
            {
                g.DrawImage(imgEars[idx % 80], 93, 0);
                g.DrawImage(imgMoustache[idx % 80], 100, 180);
            }
            else if (seType == SpecaialEffectType.Grass)
            {
                g.DrawImage(imgGrass[idx % 61], 93, -10);
                g.DrawImage(imgYuan[idx % 61], 180, 180);
            }
        }

        private void btnEars_Click(object sender, EventArgs e)
        {
            seType = SpecaialEffectType.Cat;
            idx = 0;
        }
      
        private void btnGrass_Click(object sender, EventArgs e)
        {
            seType = SpecaialEffectType.Grass;
            idx = 0;
        }
        /// <summary>
        /// 载入资源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            imgGirl = Image.FromFile("res/girl/girl1.jpg");
            imgEars = new Image[80];
            imgMoustache = new Image[80];
            imgGrass = new Image[61];
            imgYuan = new Image[61];
            for (int i = 0; i < 80; i++)
            {
                imgEars[i] = Image.FromFile("res/ear/ear_" +
                    i.ToString("D3") + ".png");//占三位，不足自动补0
                imgMoustache[i] = Image.FromFile("res/moustache/moustache_" +
                    i.ToString("D3") + ".png");
            }
                for (int j = 0; j < 61; j++)
                {
                    imgGrass[j] = Image.FromFile("res/grass/grass_" +
                        j.ToString("D3") + ".png");//占三位，不足自动补0
                    imgYuan[j] = Image.FromFile("res/yuan/yuan_" +
                        j.ToString("D3") + ".png");
                }
                timer1.Enabled = true;
            
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            idx++;
            pictureBox1.Invalidate();
        }
    }
}
