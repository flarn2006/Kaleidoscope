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
    public partial class ColorPalette : UserControl
    {
        private Color[,] palette;
        private int rows, cols;
        private int selIndex = 0;
        private Color selColor;
        private int highlightIndex = -1;

        private Color defaultColor = Color.Black;
        public const int CustomColorIndex = -1;

        public event EventHandler ColorChanged;

        public ColorPalette()
        {
            InitializeComponent();
            SetPaletteSize(4, 4);
            RandomizeColors();
        }

        public void RandomizeColors()
        {
            Random rand = new Random();
            for (int r = 0; r < rows; r++) {
                for (int c = 0; c < cols; c++) {
                    palette[r, c] = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
                }
            }
        }

        private void InitializeArray()
        {
            palette = new Color[rows, cols];

            /*for (int r=0; r<rows; r++) {
                for (int c=0; c<cols; c++) {
                    palette[r, c] = defaultColor;
                }
            }*/

            RandomizeColors();
            palette[0, 0] = Color.Black;
            palette[rows - 1, cols - 1] = Color.White;

            SelectedIndex = 0;
        }

        public void SetPaletteSize(int rowCount, int colCount)
        {
            if (rowCount > 0 && colCount > 0) {
                rows = rowCount;
                cols = colCount;
                InitializeArray();
                Invalidate();
            }
        }

        public int RowCount
        {
            get { return rows; }
            set { SetPaletteSize(value, cols); }
        }

        public int ColumnCount
        {
            get { return cols; }
            set { SetPaletteSize(rows, value); }
        }

        private Color GetColorAtIndex(int index)
        {
            if (index < 0) {
                return selColor;
            } else {
                return palette[index / cols, index % cols];
            }
        }

        public int SelectedIndex
        {
            get { return selIndex; }
            set
            {
                if (value >= 0) {
                    if (value < rows * cols) {
                        selIndex = value;
                    } else {
                        selIndex = rows * cols - 1;
                    }
                    selColor = GetColorAtIndex(selIndex);
                    Invalidate();
                    OnColorChanged();
                }
            }
        }

        public Color SelectedColor
        {
            get { return selColor; }
            set
            {
                selIndex = CustomColorIndex;
                selColor = value;
                Invalidate();
                OnColorChanged();
            }
        }

        public void SetColor(int row, int column, Color color)
        {
            if (row < 0 || row >= rows || column < 0 || column >= cols) {
                throw new IndexOutOfRangeException();
            }

            palette[row, column] = color;

            if (cols * row + column == selIndex) {
                selColor = color;
                OnColorChanged();
            }
        }

        public Color GetColor(int row, int column)
        {
            return palette[row, column];
        }

        protected virtual int GetIndexAtPoint(PointF pt)
        {
            for (int i = -1; i < rows * cols; i++) {
                if (GetRectForIndex(i).Contains(pt)) {
                    return i;
                }
            }

            return -1;
        }

        protected virtual RectangleF GetRectForIndex(int colorIndex)
        {
            if (colorIndex < 0) {
                return new RectangleF(0.0f, (float)ClientSize.Height - (float)ClientSize.Height / (rows + 1), (float)ClientSize.Width, (float)ClientSize.Height / (rows + 1));
            } else {
                SizeF sz = new SizeF((float)ClientSize.Width / cols, (float)ClientSize.Height / (rows + 1));
                PointF pt = new PointF((float)(colorIndex % cols) * sz.Width, (float)(colorIndex / cols) * sz.Height);
                return new RectangleF(pt, sz);
            }
        }

        private void ColorPalette_Paint(object sender, PaintEventArgs e)
        {
            for (int r = 0; r < rows; r++) {
                for (int c = 0; c < cols; c++) {
                    Brush br = new SolidBrush(palette[r, c]);
                    e.Graphics.FillRectangle(br, GetRectForIndex(cols * r + c));
                }
            }
            e.Graphics.FillRectangle(new SolidBrush(selColor), GetRectForIndex(CustomColorIndex));
        }

        private void ColorPalette_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                int index = GetIndexAtPoint(e.Location);
                if (index < 0) {
                    colorDlg.Color = SelectedColor;
                    if (colorDlg.ShowDialog() == DialogResult.OK) {
                        SelectedColor = colorDlg.Color;
                    }
                } else {
                    SelectedIndex = index;
                }
            }
        }

        private void ColorPalette_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        protected virtual void OnColorChanged()
        {
            if (ColorChanged != null)
                ColorChanged(this, EventArgs.Empty);
        }

        private void HighlightIndex(int index)
        {
            Graphics g = CreateGraphics();
            Color c = GetColorAtIndex(index);
            Color ch = GetColorAtIndex(highlightIndex);
            RectangleF r = GetRectForIndex(index);
            RectangleF rh = GetRectForIndex(highlightIndex);
            Pen normal = new Pen(ch); normal.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
            Pen inverse = new Pen(Color.FromArgb(c.ToArgb() ^ 0xFFFFFF)); inverse.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

            r.Inflate(-1.0f, -1.0f);
            rh.Inflate(-1.0f, -1.0f);

            if (highlightIndex >= CustomColorIndex && highlightIndex != index) {
                // Why is there no Graphics.DrawRectangle(Pen, RectangleF)?
                g.DrawRectangle(normal, rh.X, rh.Y, rh.Width, rh.Height);
            }

            if (index >= CustomColorIndex) {
                g.DrawRectangle(inverse, r.X, r.Y, r.Width, r.Height);
            }

            highlightIndex = index;
        }

        private void ColorPalette_MouseMove(object sender, MouseEventArgs e)
        {
            int index = GetIndexAtPoint(e.Location);
            HighlightIndex(index);
        }

        private void ColorPalette_MouseLeave(object sender, EventArgs e)
        {
            HighlightIndex(CustomColorIndex - 1);
        }
    }
}
