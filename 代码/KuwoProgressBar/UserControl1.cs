﻿namespace KuwoProgressBar
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        Graphics g ;

        //进度值
       int progressValue = 20;
     public  int ProgressValue 
        {
            get
            {
                return progressValue;
            }
            set
            {
                if (value <= 0)
                {
                    progressValue = 0;
                }
                else if (value >= 100)
                {
                    progressValue = 100;
                }
                else
                {
                    progressValue = value;
                }
                this.Invalidate();
            }
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            

        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Pen pen = new Pen(Color.Gold, 5);
            Pen pen2 = new Pen(Color.Gray, 5);
            int len =(int)( progressValue / 100.0 * this.Width);

            g.DrawLine(pen,0,this.Height/2,len,this.Height/2);
            g.DrawLine(pen2, len, this.Height / 2, this.Width, this.Height / 2);
            g.FillEllipse(Brushes.Gold, len, this.Height / 4, this.Height / 2, this.Height / 2);


        }
    }
}