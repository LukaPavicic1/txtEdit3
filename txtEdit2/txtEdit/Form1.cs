using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace txtEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:\\txtEdit", rtbUpis.Text);
        }

        private void btnSaveas_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            rtbUpis.SaveFile(saveFileDialog1.FileName);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files |*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbUpis.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            Font new1, old1;
            old1 = rtbUpis.SelectionFont;
            if (old1.Bold)
                new1 = new Font(old1, old1.Style & ~FontStyle.Bold);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Bold);

            rtbUpis.SelectionFont = new1;
            rtbUpis.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            rtbUpis.Clear();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            Font new1, old1;
            old1 = rtbUpis.SelectionFont;
            if (old1.Italic)
                new1 = new Font(old1, old1.Style & ~FontStyle.Italic);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Italic);

            rtbUpis.SelectionFont = new1;
            rtbUpis.Focus();
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            Font new1, old1;
            old1 = rtbUpis.SelectionFont;
            if (old1.Underline)
                new1 = new Font(old1, old1.Style & ~FontStyle.Underline);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Underline);

            rtbUpis.SelectionFont = new1;
            rtbUpis.Focus();
        }
    }
}
