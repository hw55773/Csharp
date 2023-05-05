using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTrace
{
    internal class HitRrcord
    {
        bool isHit;//是否击中
        double t;//击中点参数数据
        Point3D hitpoint;//击中点
        Color color;
        Vector3D normal;//法线向量

        public bool IsHit { get => isHit; set => isHit = value; }
        public double T { get => t; set => t = value; }
        internal Point3D Hitpoint { get => hitpoint; set => hitpoint = value; }
        internal Vector3D Normal { get => normal; set => normal = value; }
    }
}
