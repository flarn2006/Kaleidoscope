namespace Kaleidoscope
{
    partial class KaleidoscopeCanvas
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.redraw = new Kaleidoscope.AutoRedraw(this.components);
            this.SuspendLayout();
            // 
            // redraw
            // 
            this.redraw.HostControl = this;
            // 
            // KaleidoscopeCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DoubleBuffered = true;
            this.Name = "KaleidoscopeCanvas";
            this.Size = new System.Drawing.Size(239, 244);
            this.Load += new System.EventHandler(this.KaleidoscopeCanvas_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KaleidoscopeCanvas_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KaleidoscopeCanvas_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private AutoRedraw redraw;
    }
}
