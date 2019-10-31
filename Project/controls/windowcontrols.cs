using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project.controls
{
    public partial class windowcontrols : UserControl
    {
        public windowcontrols()
        {
            InitializeComponent();
            btnResize.ForeColor = Color.Cornsilk;
            btnMinimize.ForeColor = Color.Cornsilk;
            btnExit.ForeColor = Color.Cornsilk;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                Form.ActiveForm.Close();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.WindowState = FormWindowState.Minimized;
        }
        private void btnResize_Click(object sender, EventArgs e)
        {
           if (StringPack._MAXIMIZED == 0)
            {
                Form.ActiveForm.Size = new Size(Screen.FromControl(Form.ActiveForm).Bounds.Width,
                Screen.FromControl(Form.ActiveForm).Bounds.Height);
                Form.ActiveForm.Location = new Point(0, 0);
                Form.ActiveForm.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);
                StringPack._MAXIMIZED = 1;
            }else
            {
                Form.ActiveForm.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width
                    / StringPack._DefaultSize,
                Screen.PrimaryScreen.WorkingArea.Height / StringPack._DefaultSize);
                Form.ActiveForm.SetDesktopLocation(200, 60);
                StringPack._MAXIMIZED = 0;
            }
        }

    }
}
