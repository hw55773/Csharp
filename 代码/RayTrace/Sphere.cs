using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTrace
{
    /// <summary>
    /// 球体
    /// </summary>
    internal class Sphere
    {
        //球体+半径
        Point3D center;
        double radius;
        public Sphere()
        { 
            center=new Point3D();
            radius = 1;
        }
       public Sphere(Point3D c,double r)
        {
            center = c;
            radius = r;
        }

        public double Radius { get => radius; set => radius = value; }
        internal Point3D Center { get => center; set => center = value; }
    }
}
