using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDraw
{
    public class Vectors
    {
        private double x;
        private double y;
        private double z;

        public Vectors(double x, double y) {
            this.X = x;
            this.Y = y;
            this.Z = 0.0;
        }
        public Vectors(double x, double y, double z) : this(x, y) {
            this.Z = z;
        }

        public double Z {
            get { return z; }
            set { z = value; }
        }
        public double X {
            get { return x; }
            set { x = value; }
        }
        public double Y {
            get { return y; }
            set { y = value; }
        }
        public PointF ToPointF {
            /*La sintaxis de que "float se encuentre entre paréntesis ( '(float)' ) antes de una
              * variable significa que es una operación de Casting o Convert.
            
             Estmos pasando los valores de Double a Float para que puedan ser parámetros de
            PointF*/
            get { return new PointF((float)X, (float)Y); }
            /*Es importante tener en cuenta que, al realizar una conversión explícita, se puede
             * producir una pérdida de precisión si el valor original es demasiado grande para
             * ser representado con el tipo de destino. En este caso, los valores de X e Y deben ser lo
             * suficientemente pequeños como para ser representados con precisión por el tipo float,
             * de lo contrario se podrían perder algunos decimales.*/
        }
        public static Vectors Zero {
            get { return new Vectors(0.0, 0.0, 0.0); }
        }
    }
}
