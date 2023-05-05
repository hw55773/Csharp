using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo05
{
    class Lyricyline
    {
        public double time;
        public string text;
    }
    internal class KuwoMusic
    {
        public List<Lyricyline> lstLyric = new List<Lyricyline>();
      
        public void Lode(string fileName)
        {
            //读取歌词文件
            //类名 对象名=new 类名();
            Encoding en = Encoding.GetEncoding("GB2312");
            FileStream fs = new FileStream(fileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs, en);


            while (true)
            {
                //读一行
                string str = sr.ReadLine();
                if (str == null)
                {
                    break;
                }
                if (str == "")
                {
                    continue;
                }
                //时间信息
                string strMinut = str.Substring(1, 2);
                string strSecond = str.Substring(4, 5);
                double time = double.Parse(strMinut) * 60 + double.Parse(strSecond);

                //歌词信息

                string strLyric = str.Substring(10);
                Lyricyline ll = new Lyricyline();
                ll.time = time;
                ll.text = strLyric;

                lstLyric.Add(ll);
            }
            sr.Close();
            fs.Close();
        }
        
    }
}
