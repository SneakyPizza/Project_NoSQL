using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CircleProgressControl : UserControl
    {

        private Color _fillColor = Color.White;
        private Color _progressColor = Color.Orange;
        private double _maxValue = 100;
        private double _currentValue = 50;

        public Color FillColor { get => _fillColor; set => _fillColor = value; }
        public Color ProgressColor { get => _progressColor; set => _progressColor = value; }
        public double MaxValue { get => _maxValue; set => _maxValue = value; }
        public double CurrentValue { get => _currentValue; set => _currentValue = value; }

        public CircleProgressControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Bitmap map = new Bitmap(this.Width, this.Height);   //Creating a displayfield
            Graphics graphic = Graphics.FromImage(map);         //using the bitmap as field for draw
            Pen p = new Pen( new SolidBrush(_progressColor), 10f); //Creating a pen to draw using the given color and thickness

            graphic.SmoothingMode = SmoothingMode.AntiAlias;
            //Drawing the progressbar and setting starting and endpoint 
            //Starting point -90 to start at the top (0 for right, 90 bottom, 180 left)
            graphic.DrawArc(p, 3*6, 3*6, (this.Width - 7*5) - 2, (this.Height - 7*5) - 2, -90, (int)Math.Round((double)((360.0 / ((double)_maxValue)) * _currentValue)));
            graphic.FillEllipse(new SolidBrush(_fillColor), 4*6, 4*6, (this.Width - 8*6) - 1, (this.Height - 8*6) - 1);

            e.Graphics.DrawImage(map, 0, 0);
            graphic.Dispose();
            map.Dispose();
        }
    }
}
