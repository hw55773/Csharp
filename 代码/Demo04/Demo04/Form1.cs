using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo04
{
    public partial class lblapp : Form
    {
        double OpA;//操作数A
        double OpB;//操作数B
        string operate;
        double result;
        public lblapp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

      

        private void lblapp_Load(object sender, EventArgs e)
        {

        }

        private void btncuti_Click(object sender, EventArgs e)
        {
            txtanswer.Text="";//刷新
            //出题
            //随机生成操作数，操作符
            Random rnd = new Random();
            OpA = rnd.Next(10);
            
            OpB = rnd.Next(10);
            int opr = rnd.Next(4);//运算符
                                  //对应控件显示运算式
            lblNew1.Text = OpA.ToString();
            lblNew2.Text = OpB.ToString();
            switch (opr)
            {
                case 0:
                    operate = "+"; break;
                case 1:
                    operate = "-"; break;
                case 2:
                    operate = "*"; break;
                case 3:
                    operate = "/"; break;
            }
            lblstring.Text = operate;
        }

        private void btnpanfen_Click(object sender, EventArgs e)
        {
            string str;
            switch (lblstring.Text)
            {
                case "+":
                    result = OpA + OpB; break;
                case "-":
                    result = OpA - OpB; break;
                case "*":
                    result = OpA * OpB; break;
                case "/":
                    result = OpA / OpB; break;
           

            }
            if (lblstring.Text=="/"&&OpB==0)
            {
                 str = "算式不存在";
            }
           else if (Convert.ToDouble(txtanswer.Text) == result){
                 str=lblNew1.Text+lblstring.Text+lblNew2.Text+lbljudge.Text
                    +result.ToString()+"\t\t恭喜你，回答正确！"; 
            }
            
            else
            {
                 str = lblNew1.Text + lblstring.Text + lblNew2.Text + lbljudge.Text
                    + result.ToString() + "\t\t很遗憾，回答错误！";
            }
            listBox1.Items.Add(str);
        }
    }
}