using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kaleidoscope
{
    [DefaultEvent("ColorChanged")]
    class ColorButton : Button
    {
        private ColorDialog dlg;
        private Color color;

        public event EventHandler ColorChanged;
        protected virtual void OnColorChanged()
        {
            if (ColorChanged != null)
                ColorChanged(this, EventArgs.Empty);
        }

        public ColorButton()
            : base()
        {
            color = Color.White;
            dlg = new ColorDialog();
            base.Text = "";
        }

        protected override void OnClick(EventArgs e)
        {
            dlg.Color = SelectedColor;
            if (dlg.ShowDialog() == DialogResult.OK) {
                SelectedColor = dlg.Color;
                OnColorChanged();
            }
            base.OnClick(e);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rect = ClientRectangle;
            rect.Inflate(-4, -4);
            pevent.Graphics.FillRectangle(Brushes.Black, rect);
            rect.Inflate(-1, -1);
            pevent.Graphics.FillRectangle(new SolidBrush(color), rect);
        }

        [DefaultValue(typeof(Color), "White")]
        [Category("Appearance")]
        [Description("Indicates which color is currently selected.")]
        public Color SelectedColor
        {
            get { return color; }
            set { color = value; Invalidate(); }
        }

        [Browsable(false)]
        public override string Text
        {
            get { return ""; }
            set { }
        }
    }
}
