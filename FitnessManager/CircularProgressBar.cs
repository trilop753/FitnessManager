using System;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessManager
{
    public class CircularProgressBar : ProgressBar
    {
        public CircularProgressBar()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(10, 10, Width - 20, Height - 20);
            double scaleFactor = (double)(Value - Minimum) / (Maximum - Minimum);
            int angle = (int)(scaleFactor * 360);

            Color color = Color.FromArgb(
                (int)(255 * (1 - scaleFactor)),
                (int)(255 * scaleFactor),
                0);

            using (Pen trackPen = new Pen(Color.LightGray, 7))
            {
                e.Graphics.DrawArc(trackPen, rect, 0, 360);
            }

            using (Pen progressPen = new Pen(color, 9))
            {
                e.Graphics.DrawArc(progressPen, rect, -90, angle);
            }
        }
    }
}
