using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTrace
{
    internal class ViewPlan
    {
        Point3D leftTopLoc;
        double w;
        double h;
        int resW;//宽度分辨率
        int resH;//高度分辨率

        public double W { get => w; set => w = value; }
        public double H { get => h; set => h = value; }
        public int ResH { get => resH; set => resH = value; }
        public int ResW { get => resW; set => resW = value; }
        internal Point3D LeftTopLoc { get => leftTopLoc; set => leftTopLoc = value; }
    }
}
