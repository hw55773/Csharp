using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTrace
{
    /// <summary>
    /// 三维点类
    /// </summary>
    internal class Point3D
    {
        //字段
        double x;
        double y;
        double z;
        //构造函数
        public Point3D()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
           
        }
        public Point3D(double a)
        {
            this.x = a;
            this.y = a;
            this.z = a;
        }
        public static Vector3D operator-(Point3D p1, Point3D p2)
        {
            Vector3D v=new Vector3D(p2.X-p1.X,p2.Y-p1.Y,p2.Z-p1.Z);
            return v;   
        }
        //属性
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }
        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }
    }
}
