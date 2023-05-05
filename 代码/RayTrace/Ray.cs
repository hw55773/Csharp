using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTrace
{
    /// <summary>
    /// 光线类
    /// </summary>
    internal class Ray
    {
        //起点和方向
        Point3D org;

        Vector3D dir;
        public Ray(Point3D org, Vector3D dir)
        {
            this.org = org; 
            this.dir = dir;
        }
        public HitRrcord Hit(Sphere sphere)
        {
            dir.Normalize();
            HitRrcord hr =new HitRrcord();
            double A = dir.A*dir.A+dir.B*dir.B+dir.C*dir.C;
            double B = 2*(dir.A* (org.X-sphere.Center.X)+dir.B*(org.Y-sphere.Center.Y)+dir.C*(org.Z-sphere.Center.Z));
            double C =( org.X - sphere.Center.X)* (org.X - sphere.Center.X )
                + (org.Y - sphere.Center.Y) * (org.Y - sphere.Center.Y )
                + (org.Z - sphere.Center.Z)* (org.Z - sphere.Center.Z) 
                - sphere.Radius*sphere.Radius;
            double delta2 = B * B - 4 * A * C;
            if (delta2 < 0)
            {
              
                hr.IsHit = false;
            }
            else
            {

                double delta = Math.Sqrt(delta2);
                double t0 = (-B - delta2) / 2 * A;
                Point3D hitPoint = new Point3D(org.X + dir.A * t0, org.Y + dir.B * t0, org.Z + dir.C * t0);
                Vector3D normalV = hitPoint - sphere.Center;
                hr.T = t0;
                hr.Hitpoint= hitPoint;
                hr.Normal= normalV;
               hr.IsHit= true;
            }
           
            return hr;
        }
    }
}
