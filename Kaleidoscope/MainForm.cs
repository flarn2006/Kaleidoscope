using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kaleidoscope
{
    public partial class MainForm : Form
    {
        IStack<Image> undo;
        Point center;
        bool centerVisible = false;

        public MainForm()
        {
            InitializeComponent();
            undo = CreateUndoBuffer();
            bgColor.SelectedColor = canvas.BackColor = Properties.Settings.Default.DefaultBackColor;
        }

        private IStack<Image> CreateUndoBuffer()
        {
            if (Properties.Settings.Default.LimitedUndo) {
                return new MostRecentStack<Image>(Properties.Settings.Default.UndoBufferSize);
            } else {
                return new Stack<Image>();
            }
        }

        private void palette_ColorChanged(object sender, EventArgs e)
        {
            canvas.DrawingPen.Color = palette.SelectedColor;
        }

        private void palette_Load(object sender, EventArgs e)
        {

        }

        private void UpdateKaleidoscope()
        {
            RadialKaleidoscope.AngleMode mode;
            if (doubled.Checked) {
                mode = RadialKaleidoscope.AngleMode.TwoWay;
            } else {
                mode = RadialKaleidoscope.AngleMode.OneWay;
            }
            canvas.Kaleidoscope = new RadialKaleidoscope((int)reflections.Value, center, mode);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Clear();
            undo.Clear();
            undoToolStripMenuItem.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(canvas.RenderBitmap());
        }

        private void colorPaletteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            palette.Visible = colorPaletteToolStripMenuItem.Checked;
        }

        private void drawingSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.Visible = drawingSettingsToolStripMenuItem.Checked;
        }

        private void closeSettings_Click(object sender, EventArgs e)
        {
            settings.Visible = false;
            drawingSettingsToolStripMenuItem.Checked = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            center = new Point(canvas.ClientSize.Width / 2, canvas.ClientSize.Height / 2);
            UpdateKaleidoscope();
            palette.LoadColors(DefaultPalette.Palette);
        }

        private void UpdateKaleidoscope(object sender, EventArgs e)
        {
            UpdateKaleidoscope();
        }

        private void penwidth_ValueChanged(object sender, EventArgs e)
        {
            canvas.DrawingPen.Width = (float)penwidth.Value;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                undo.Push(canvas.GetBitmap().Clone() as Image);
                undoToolStripMenuItem.Enabled = true;
            } else if (e.Button == MouseButtons.Right) {
                center = e.Location;
                canvas.Invalidate();
                UpdateKaleidoscope();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undo.Count > 0) {
                Image img = undo.Pop();
                canvas.Clear();
                Graphics.FromImage(canvas.GetBitmap()).DrawImage(img, Point.Empty);
                canvas.Invalidate();
                if (undo.Count == 0) {
                    undoToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            if (centerVisible) {
                Color inverse = Color.FromArgb(canvas.BackColor.ToArgb() ^ 0xFFFFFF);
                Rectangle r = new Rectangle(center, new Size(3, 3));
                r.Offset(-1, -1);
                e.Graphics.FillRectangle(new SolidBrush(inverse), r);
            }
        }

        private void centerPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            centerVisible = centerPointToolStripMenuItem.Checked;
            canvas.Invalidate();
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgSaveDlg.ShowDialog() == DialogResult.OK) {
                canvas.RenderBitmap().Save(imgSaveDlg.FileName, ImageFormat.Png);
            }
        }

        private void reflectionsLabel_ValueDrag(object sender, ValueDragLabel.ValueDragEventArgs e)
        {
            decimal newValue = reflections.Value + e.Delta;
            if (newValue > reflections.Maximum) newValue = reflections.Maximum;
            if (newValue < reflections.Minimum) newValue = reflections.Minimum;
            reflections.Value = newValue;
        }

        private void penWidthLabel_ValueDrag(object sender, ValueDragLabel.ValueDragEventArgs e)
        {
            decimal newValue = penwidth.Value + e.Delta;
            if (newValue > penwidth.Maximum) newValue = penwidth.Maximum;
            if (newValue < reflections.Minimum) newValue = reflections.Minimum;
            penwidth.Value = newValue;
        }

        private void bgColor_ColorChanged(object sender, EventArgs e)
        {
            canvas.BackColor = bgColor.SelectedColor;
        }

        private void loadDefaultColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            palette.LoadColors(DefaultPalette.Palette);
        }

        private void randomizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            palette.RandomizeColors();
            palette.SetColor(0, 0, Color.Black);
            palette.SetColor(0, 1, Color.White);
            palette.Invalidate();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            palette.Width = palette.Height / 9;
            tip.Visible = (Height > 284);
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PreferencesForm().ShowDialog();
        }
    }
}
