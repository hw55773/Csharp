using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo02
{
    public partial class frmMain01 : Form
    {
        
        public frmMain01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btnlogin_Click(object sender, EventArgs e)//事件相应处理代码
        {

            string name = txtAcount.Text;
            string password = txtPassword.Text;
            frmMain fmain = new frmMain();
            if (name == "2073578174" && password == "qqwenhao2002")
            {
              fmain.ShowDialog();
                this.Close();
            }
            else if (name != "2073578174" && password == "qqwenhao2002")
            {
                MessageBox.Show("您的账号输入错误，请重新输入！");
            }
            else if (name == "2073578174" && password != "qqwenhao2002")
            {
                MessageBox.Show("您的密码输入错误，请重新输入！");
            }
            else if (name != "2073578174" && password != "qqwenhao2002")
            {
                MessageBox.Show("您的账号和密码输入错误，请重新输入！");
            }
        }

        private void txtAcount_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            //关闭的控件背景色变为红色
            picClose.BackColor = Color.Red;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            //离开控件回复其颜色
            picClose.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picHat_Click(object sender, EventArgs e)
        {

        }
        int seder=0 ;
        bool right=true;

        private void picHat_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            seder = 5;
            right = true;
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (picAdd.Location.X >= 400&& right)
            {
                seder = 0;
                
                
            }
            if (picAdd.Location.X <290 && !right) {
                seder = 0;
            }

            picAdd.Location = new Point(picAdd.Location.X + seder, picAdd.Location.Y);

        }

        private void picAdd_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void picHat_MouseLeave(object sender, EventArgs e)
        {
            right = false;
            seder = -5;
        }
    }
}
