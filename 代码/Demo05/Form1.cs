using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//导入IO流引入命名空间
namespace Demo05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KuwoMusic kl = new KuwoMusic();
        bool IsPlaying = false;//代表音乐是否播放
        private void picPlayer_Click(object sender, EventArgs e)
        {
            if (IsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                picPlayer.BackgroundImage = Properties.Resources.play;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                picPlayer.BackgroundImage = Properties.Resources.pause;
            }
            IsPlaying = !IsPlaying;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //显示播放时间
            lbltime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString
                +"/"+axWindowsMediaPlayer1.currentMedia.durationString;
           
           
            for(int i = 0; i < kl.lstLyric.Count-1; i++)
            {
                if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition > kl.lstLyric[i].time && 
                    axWindowsMediaPlayer1.Ctlcontrols.currentPosition < kl.lstLyric[i+1].time)
                {
                    //根据歌曲播放，显示歌词
                    lblLyric.Text = kl.lstLyric[i].text;
                }
                
            }

            
        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void lblLyric_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 找到一个目录下的所有文件
        /// <summary>
        /// <param name="directory"></param>
        /// <param name="pattern"></param>
        /// <param name="fileList"></param>
        public void GetFiles(DirectoryInfo directory, string pattern, ref List<string> fileList)
        {
            if (directory.Exists || pattern.Trim() != string.Empty)
            {
                try
                {
                    foreach (FileInfo info in directory.GetFiles(pattern))
                    {
                        fileList.Add(info.Name.Remove(info.Name.LastIndexOf(".")).ToString());
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                foreach (DirectoryInfo info in directory.GetDirectories())//获取文件夹下的子文件夹
                {
                    GetFiles(info, pattern, ref fileList);//递归调用该函数，获取子文件夹下的文件
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curMp3Name = listBox1.SelectedItem.ToString();
            //利用歌词类，实现歌词的载入，解析
            kl = new KuwoMusic();
            kl.Lode("Lyric/" + curMp3Name + ".lrc");
            axWindowsMediaPlayer1.URL = "song/" + curMp3Name + ".mp3";
            IsPlaying = true;
           /* picPlayer.BackgroundImage = Properties.Resources.pause;*/
            this.BackgroundImage = Image.FromFile("bg/" + curMp3Name + ".jpg");
            timer1.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> lstAllMp3FileName = new List<string>();
            string dir = Environment.CurrentDirectory + "/song";
            GetFiles(new DirectoryInfo(dir), "*.*", ref lstAllMp3FileName);
            //显示到listbox
            listBox1.Items.AddRange(lstAllMp3FileName.ToArray());

        }
    }
}
