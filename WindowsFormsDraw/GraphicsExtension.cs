using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDraw.Entities;

namespace WindowsFormsDraw
{
    public static class GraphicsExtension //La clase debe ser estática
    {
        private static float Height;

        public static void MeterParametros(this Graphics g , float height){
            Height = height;
        }

        private static void SetTransform(this Graphics g){
            g.PageUnit = GraphicsUnit.Millimeter;
            g.TranslateTransform(0 , Height);
            g.ScaleTransform(1.0f , -1.0f);
        }

        public static void DrawWea(this Graphics g , Pen pen , Entities.PPoint point){
            g.SetTransform();
            PointF p = point.Position.ToPointF;
            g.DrawEllipse(pen , p.X-1 , p.Y-1 , 3 , 3);
            g.ResetTransform();
        }
    }
}
