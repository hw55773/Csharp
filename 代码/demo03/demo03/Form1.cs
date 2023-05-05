using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo03
{
    
    public partial class Frmwindows : Form
    {
        int delty = 20;
        int deltx = 20;
        public Frmwindows()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            lblName.Top+=delty;
            lblName.Left+=deltx;
            if ((lblName.Top + lblName.Height) >= this.Height)
            {
                //设置偏移量为负数
                delty = -delty;

            }
             if ((lblName.Left+ lblName.Width) >= this.Width)
            {
                //设置偏移量为负数
                deltx = -deltx;
            }
             if(lblName.Top < 0)
            {
                delty = -delty;

            }
             if(lblName.Left< 0)
            {
                deltx = -deltx;

            }
        }

        private void Frmwindows_KeyPress(object sender, KeyPressEventArgs e)
        {
            //退出程序
            Application.Exit();
        }
    }
}
