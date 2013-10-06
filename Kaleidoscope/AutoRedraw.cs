using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kaleidoscope
{
    public partial class AutoRedraw : Component, IDisposable
    {
        private Bitmap bmp;
        private Control host = null;

        public AutoRedraw()
        {
            InitializeComponent();
        }

        [Category("Behavior")]
        [Description("Indicates the control whose events to monitor and respond to.")]
        public Control HostControl
        {
            get { return host; }
            set { SetHost(value); }
        }

        protected virtual void SetHost(Control newHost)
        {
            if (host != null) RemoveEventHooks(host);
            host = newHost;

            if (host != null) {
                bmp = new Bitmap(host.ClientSize.Width, host.ClientSize.Height);
                AttachEventHooks(host);
            } else if (bmp != null) {
                bmp.Dispose();
            }
        }

        public AutoRedraw(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        [Browsable(false)]
        public Graphics Graphics
        {
            get { return Graphics.FromImage(bmp); }
        }

        [Browsable(false)]
        public Bitmap Bitmap
        {
            get { return bmp; }
        }

        public void Clear()
        {
            int width = bmp.Width;
            int height = bmp.Height;
            bmp.Dispose();
            bmp = new Bitmap(width, height);
        }

        private void host_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
        }

        private void host_Resize(object sender, EventArgs e)
        {
            if (host.ClientSize.Width > bmp.Width || host.ClientSize.Height > bmp.Height) {
                Bitmap saved = bmp;
                bmp = new Bitmap(host.ClientSize.Width, host.ClientSize.Height);
                System.Drawing.Graphics.FromImage(bmp).DrawImage(saved, Point.Empty);
            }
        }

        private void AttachEventHooks(Control ctl)
        {
            ctl.Paint += new PaintEventHandler(host_Paint);
            ctl.Resize += new EventHandler(host_Resize);
        }

        private void RemoveEventHooks(Control ctl)
        {
            if (ctl != null) {
                ctl.Paint -= new PaintEventHandler(host_Paint);
                ctl.Resize -= new EventHandler(host_Resize);
            }
        }

        public new void Dispose()
        {
            RemoveEventHooks(host);
            base.Dispose();
        }
    }
}
