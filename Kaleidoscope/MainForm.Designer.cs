namespace Kaleidoscope
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawingSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.centerPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDefaultColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settings = new System.Windows.Forms.Panel();
            this.tip = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.doubled = new System.Windows.Forms.CheckBox();
            this.closeSettings = new System.Windows.Forms.Button();
            this.penwidth = new System.Windows.Forms.NumericUpDown();
            this.reflections = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.imgSaveDlg = new System.Windows.Forms.SaveFileDialog();
            this.canvas = new Kaleidoscope.KaleidoscopeCanvas();
            this.bgColor = new Kaleidoscope.ColorButton();
            this.penWidthLabel = new Kaleidoscope.ValueDragLabel();
            this.reflectionsLabel = new Kaleidoscope.ValueDragLabel();
            this.palette = new Kaleidoscope.ColorPalette();
            this.menuStrip1.SuspendLayout();
            this.settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penwidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reflections)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.colorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveImageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveImageToolStripMenuItem.Text = "&Save Image...";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.toolStripSeparator1,
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorPaletteToolStripMenuItem,
            this.drawingSettingsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.centerPointToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // colorPaletteToolStripMenuItem
            // 
            this.colorPaletteToolStripMenuItem.Checked = true;
            this.colorPaletteToolStripMenuItem.CheckOnClick = true;
            this.colorPaletteToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.colorPaletteToolStripMenuItem.Name = "colorPaletteToolStripMenuItem";
            this.colorPaletteToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.colorPaletteToolStripMenuItem.Text = "Color &Palette";
            this.colorPaletteToolStripMenuItem.Click += new System.EventHandler(this.colorPaletteToolStripMenuItem_Click);
            // 
            // drawingSettingsToolStripMenuItem
            // 
            this.drawingSettingsToolStripMenuItem.Checked = true;
            this.drawingSettingsToolStripMenuItem.CheckOnClick = true;
            this.drawingSettingsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.drawingSettingsToolStripMenuItem.Name = "drawingSettingsToolStripMenuItem";
            this.drawingSettingsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.drawingSettingsToolStripMenuItem.Text = "Drawing &Settings";
            this.drawingSettingsToolStripMenuItem.Click += new System.EventHandler(this.drawingSettingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(194, 6);
            // 
            // centerPointToolStripMenuItem
            // 
            this.centerPointToolStripMenuItem.CheckOnClick = true;
            this.centerPointToolStripMenuItem.Name = "centerPointToolStripMenuItem";
            this.centerPointToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.C)));
            this.centerPointToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.centerPointToolStripMenuItem.Text = "&Center Point";
            this.centerPointToolStripMenuItem.Click += new System.EventHandler(this.centerPointToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDefaultColorsToolStripMenuItem,
            this.randomizeToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorsToolStripMenuItem.Text = "&Colors";
            // 
            // loadDefaultColorsToolStripMenuItem
            // 
            this.loadDefaultColorsToolStripMenuItem.Name = "loadDefaultColorsToolStripMenuItem";
            this.loadDefaultColorsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.loadDefaultColorsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.loadDefaultColorsToolStripMenuItem.Text = "Load &Default Colors";
            this.loadDefaultColorsToolStripMenuItem.Click += new System.EventHandler(this.loadDefaultColorsToolStripMenuItem_Click);
            // 
            // randomizeToolStripMenuItem
            // 
            this.randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
            this.randomizeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.randomizeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.randomizeToolStripMenuItem.Text = "&Randomize";
            this.randomizeToolStripMenuItem.Click += new System.EventHandler(this.randomizeToolStripMenuItem_Click);
            // 
            // settings
            // 
            this.settings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settings.Controls.Add(this.tip);
            this.settings.Controls.Add(this.bgColor);
            this.settings.Controls.Add(this.label2);
            this.settings.Controls.Add(this.penWidthLabel);
            this.settings.Controls.Add(this.reflectionsLabel);
            this.settings.Controls.Add(this.doubled);
            this.settings.Controls.Add(this.closeSettings);
            this.settings.Controls.Add(this.penwidth);
            this.settings.Controls.Add(this.reflections);
            this.settings.Controls.Add(this.label1);
            this.settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.settings.Location = new System.Drawing.Point(456, 24);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(144, 357);
            this.settings.TabIndex = 3;
            // 
            // tip
            // 
            this.tip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tip.Location = new System.Drawing.Point(7, 277);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(123, 69);
            this.tip.TabIndex = 14;
            this.tip.Text = "TIP:\r\nDrag left and right on the Reflections and Pen Width labels to quickly chan" +
                "ge their values.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Background Color:";
            // 
            // doubled
            // 
            this.doubled.Checked = true;
            this.doubled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doubled.Location = new System.Drawing.Point(6, 58);
            this.doubled.Name = "doubled";
            this.doubled.Size = new System.Drawing.Size(124, 20);
            this.doubled.TabIndex = 6;
            this.doubled.Text = "Doubled";
            this.doubled.UseVisualStyleBackColor = true;
            this.doubled.CheckedChanged += new System.EventHandler(this.UpdateKaleidoscope);
            // 
            // closeSettings
            // 
            this.closeSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeSettings.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.closeSettings.Location = new System.Drawing.Point(116, 0);
            this.closeSettings.Name = "closeSettings";
            this.closeSettings.Size = new System.Drawing.Size(24, 23);
            this.closeSettings.TabIndex = 5;
            this.closeSettings.TabStop = false;
            this.closeSettings.Text = "r";
            this.closeSettings.UseVisualStyleBackColor = true;
            this.closeSettings.Click += new System.EventHandler(this.closeSettings_Click);
            // 
            // penwidth
            // 
            this.penwidth.Location = new System.Drawing.Point(73, 89);
            this.penwidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penwidth.Name = "penwidth";
            this.penwidth.Size = new System.Drawing.Size(64, 20);
            this.penwidth.TabIndex = 0;
            this.penwidth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.penwidth.ValueChanged += new System.EventHandler(this.penwidth_ValueChanged);
            // 
            // reflections
            // 
            this.reflections.Location = new System.Drawing.Point(73, 32);
            this.reflections.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reflections.Name = "reflections";
            this.reflections.Size = new System.Drawing.Size(64, 20);
            this.reflections.TabIndex = 0;
            this.reflections.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.reflections.ValueChanged += new System.EventHandler(this.UpdateKaleidoscope);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgSaveDlg
            // 
            this.imgSaveDlg.DefaultExt = "png";
            this.imgSaveDlg.Filter = "Portable Network Graphics (*.png)|*.png";
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Window;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Kaleidoscope = null;
            this.canvas.Location = new System.Drawing.Point(39, 24);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(417, 357);
            this.canvas.TabIndex = 1;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            // 
            // bgColor
            // 
            this.bgColor.Location = new System.Drawing.Point(104, 125);
            this.bgColor.Name = "bgColor";
            this.bgColor.Size = new System.Drawing.Size(33, 23);
            this.bgColor.TabIndex = 13;
            this.bgColor.UseVisualStyleBackColor = true;
            this.bgColor.ColorChanged += new System.EventHandler(this.bgColor_ColorChanged);
            // 
            // penWidthLabel
            // 
            this.penWidthLabel.AutoSize = true;
            this.penWidthLabel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.penWidthLabel.Location = new System.Drawing.Point(4, 91);
            this.penWidthLabel.Name = "penWidthLabel";
            this.penWidthLabel.Size = new System.Drawing.Size(60, 13);
            this.penWidthLabel.TabIndex = 9;
            this.penWidthLabel.Text = "Pen Width:";
            this.penWidthLabel.ValueDrag += new System.EventHandler<Kaleidoscope.ValueDragLabel.ValueDragEventArgs>(this.penWidthLabel_ValueDrag);
            // 
            // reflectionsLabel
            // 
            this.reflectionsLabel.AutoSize = true;
            this.reflectionsLabel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.reflectionsLabel.Location = new System.Drawing.Point(3, 34);
            this.reflectionsLabel.Name = "reflectionsLabel";
            this.reflectionsLabel.Size = new System.Drawing.Size(63, 13);
            this.reflectionsLabel.TabIndex = 8;
            this.reflectionsLabel.Text = "Reflections:";
            this.reflectionsLabel.ValueDrag += new System.EventHandler<Kaleidoscope.ValueDragLabel.ValueDragEventArgs>(this.reflectionsLabel_ValueDrag);
            // 
            // palette
            // 
            this.palette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palette.ColumnCount = 2;
            this.palette.Dock = System.Windows.Forms.DockStyle.Left;
            this.palette.Location = new System.Drawing.Point(0, 24);
            this.palette.Name = "palette";
            this.palette.RowCount = 16;
            this.palette.SelectedColor = System.Drawing.Color.Black;
            this.palette.SelectedIndex = 0;
            this.palette.Size = new System.Drawing.Size(39, 357);
            this.palette.TabIndex = 0;
            this.palette.TabStop = false;
            this.palette.ColorChanged += new System.EventHandler(this.palette_ColorChanged);
            this.palette.Load += new System.EventHandler(this.palette_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 381);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.palette);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(356, 227);
            this.Name = "MainForm";
            this.Text = "Kaleidoscope";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penwidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reflections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorPalette palette;
        private KaleidoscopeCanvas canvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.Panel settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown reflections;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorPaletteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawingSettingsToolStripMenuItem;
        private System.Windows.Forms.Button closeSettings;
        private System.Windows.Forms.CheckBox doubled;
        private System.Windows.Forms.NumericUpDown penwidth;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem centerPointToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog imgSaveDlg;
        private ValueDragLabel reflectionsLabel;
        private ValueDragLabel penWidthLabel;
        private System.Windows.Forms.Label label2;
        private ColorButton bgColor;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDefaultColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItem;
        private System.Windows.Forms.Label tip;

    }
}

