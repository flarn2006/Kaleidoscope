using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kaleidoscope
{
    public partial class PreferencesForm : Form
    {
        public PreferencesForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void LoadSettings()
        {
            undoCheck.Checked = Properties.Settings.Default.LimitedUndo;
            undoSteps.Value = (decimal)Properties.Settings.Default.UndoBufferSize;
            defBgColor.SelectedColor = Properties.Settings.Default.DefaultBackColor;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.LimitedUndo = undoCheck.Checked;
            Properties.Settings.Default.UndoBufferSize = (int)undoSteps.Value;
            Properties.Settings.Default.DefaultBackColor = defBgColor.SelectedColor;
            Properties.Settings.Default.Save();
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void undoCheck_CheckedChanged(object sender, EventArgs e)
        {
            undoSteps.Enabled = undoCheck.Checked;
        }
    }
}
