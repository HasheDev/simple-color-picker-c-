using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hexcolor_Click(object sender, EventArgs e)
        {
            if (diagcolor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                hexcolor.BackColor = diagcolor.Color;
                string hex;
                hex = (diagcolor.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                Color color = Color.FromArgb(Convert.ToInt32(hex, 16));
                lblhex.Text = "#" + hex;

            }
            else
            {
                Application.Exit();
            }
        }

        private void Btncopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblhex.Text);
        }
    }
}
