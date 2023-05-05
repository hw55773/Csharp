using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace RayTrace
{
    internal class Vector3D
    {
        double a;
        double b;
        double c;
        public double Length()
        {
            return Math.Sqrt(a * a + b * b+c*c);
        }
        public void Normalize()
        {
           double len=Length();
            a/=len;
            b/=len; 
            c/=len;
            
        }
       /// <summary>
       /// 向量数乘
       /// </summary>
       /// <param name="n"></param>
       /// <param name="v"></param>
       /// <returns></returns>
        public static Vector3D operator*(double n, Vector3D v)
        {
            return new Vector3D(n * v.A, n * v.B,n * v.C);
        }
        public static Vector3D operator *(Vector3D v, double n)
        {
            return new Vector3D(n * v.A, n * v.B, n * v.C);
        }
        /// <summary>
        /// 向量的点乘
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static double operator *(Vector3D v1, Vector3D v2)
        {
            return v1.a * v2.a + v1.b * v2.b + v1.c * v2.c;
        }
        /// <summary>
        /// 向量叉乘
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector3D operator ^(Vector3D v1, Vector3D v2)
        {
            Vector3D v = new Vector3D();
            v.a = v1.b * v2.c - v2.b * v1.c;
            v.b = v2.a * v1.c - v1.a * v2.c;
            v.c = v1.a * v2.b - v2.a * v1.b;
            return new Vector3D(v.a, v.b, v.c);
        }
        /// <summary>
        /// 向量加
        /// </summary>
        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.a + v2.a , v1.b + v2.b , v1.c + v2.c);
        }
        /// <summary>
        /// 向量减
        /// </summary>
        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.a - v2.a, v1.b - v2.b, v1.c - v2.c);
        }
        
        public Vector3D()
        {
            a = 0;
            b = 0;
            c = 1;
        }
        public Vector3D(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
    }
}
