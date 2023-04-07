using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDraw
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Create List of Points
        private List<Entities.PPoint> points = new List<Entities.PPoint>();
        private Vectors _currentPosition;
        private Vectors _currentPositionPixels;
        private int drawindex = -1;
        private bool activedrawing = false;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _currentPosition = PoinTToCartesian(e.Location);
            _currentPositionPixels = PointToPixel(e.Location);
            lblCoordinates.Text = string.Format("{0}X , {1}Y", _currentPosition.X, _currentPosition.Y);
            lblPixels.Text = string.Format("{0,0:F3}X , {1,0:F3}Y", _currentPositionPixels.X , _currentPositionPixels.Y);
        }

        /// <summary>
        /// Convierte los valores de los ejes a un plano cartesiano. Osea que el punto 0x.0y
        /// se encuentra en la esquina inferior izquierda
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        private Vectors PoinTToCartesian(PointF point) {
            return new Vectors(point.X, pictureBox1.Height - point.Y);
        }
        private float DrawPixel {
            get
            {
                using (var g = CreateGraphics())
                    return g.DpiX;
            }
        }

        private float PixelToMilimeters(float pixel){
            return pixel * 25.4f / DrawPixel;
         }

        private Vectors PointToPixel(PointF point){
            return new Vectors(PixelToMilimeters(point.X),PixelToMilimeters(pictureBox1.Height - point.Y));
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left){
                if (activedrawing){
                    switch (drawindex){
                        case 0:
                            points.Add(new Entities.PPoint(_currentPosition));
                            break;
                    }
                    pictureBox1.Refresh();
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.MeterParametros(PixelToMilimeters(pictureBox1.Height));
            if (points.Count > 0) {
                foreach (Entities.PPoint pp in points){
                    e.Graphics.DrawWea(new Pen(Color.Purple , 0) , pp);
                }
            }
        }

        private void btnPoints_Click(object sender, EventArgs e)
        {
            drawindex= 0;
            activedrawing= true;
            pictureBox1.Cursor= Cursors.Cross;
        }
    }
}
