using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDraw.Entities
{
    public class PPoint
    {
        private Vectors _vectors;
        private double _thickness; //Thickness = Espesor / Grosor / Capas de Grosor

        public PPoint(){
            this.Position = Vectors.Zero;
            this.Thickness = 0.0;
        }

        public PPoint(Vectors position){
            this.Position = position;
            this.Thickness = 0.0;
        }

        public double Thickness {
            get { return _thickness; }
            set { _thickness = value; }
        }

        public Vectors Position{
            get { return _vectors; }
            set { _vectors = value; }
        }
    }
}
