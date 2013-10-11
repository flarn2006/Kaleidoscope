using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kaleidoscope
{
    public partial class KaleidoscopeCanvas : UserControl
    {
        private Pen pen;
        private Point cursor = Point.Empty;
        private IKaleidoscope k = null;

        public KaleidoscopeCanvas()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 4.0f);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        [Browsable(false)]
        public Pen DrawingPen
        {
            get { return pen; }
            set { pen = value; }
        }

        public Bitmap GetBitmap()
        {
            return redraw.Bitmap;
        }

        public Bitmap RenderBitmap()
        {
            Bitmap b = new Bitmap(ClientSize.Width, ClientSize.Height);
            Graphics g = Graphics.FromImage(b);
            g.FillRectangle(new SolidBrush(BackColor), new Rectangle(Point.Empty, redraw.Bitmap.Size));
            g.DrawImage(redraw.Bitmap, Point.Empty);
            return b;
        }

        [Browsable(false)]
        public IKaleidoscope Kaleidoscope
        {
            get { return k; }
            set { k = value; }
        }

        private void KaleidoscopeCanvas_Load(object sender, EventArgs e)
        {

        }

        private void KaleidoscopeCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            cursor = e.Location;
        }

        private void KaleidoscopeCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) > 0) {
                if (k == null) {
                    redraw.Graphics.DrawLine(pen, cursor, e.Location);
                } else {
                    Point[] start = k.GetReflectedPoints(cursor);
                    Point[] end = k.GetReflectedPoints(e.Location);
                    for (int i = 0; i < start.Length; i++) {
                        redraw.Graphics.DrawLine(pen, start[i], end[i]);
                    }
                }
                cursor = e.Location;
                Invalidate();
            }
        }

        public void Clear()
        {
            redraw.Clear();
            Invalidate();
        }
    }
}
