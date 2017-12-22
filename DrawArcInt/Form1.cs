using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawArcInt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create coordinates of rectangle to bound ellipse.
            int x = 0;
            int y = 0;
            int width = 100;
            int height = 200;

            // Create start and sweep angles on ellipse.
            int startAngle = 45;
            int sweepAngle = 270;

            // Draw arc to screen.
            e.Graphics.DrawArc(blackPen, x, y, width, height, startAngle, sweepAngle);
        }
    }
}
