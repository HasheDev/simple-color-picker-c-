using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        PictureBox Picture = new PictureBox();

        public void Createpic(int w, int h, int xx, int yy, String name, int x, int y, int z)
        {
            body.BackColor = Color.Red;
            PictureBox picture = new PictureBox
            {
                Name = name,
                Size = new Size(xx, yy),
                Location = new Point(w, h),
                BackColor = Color.FromArgb(x, y, z),
                Anchor = (AnchorStyles.Top | AnchorStyles.Left),
                
            };
            
            picture.Click += new EventHandler(delegate (object s, EventArgs e) {
                string hex;
                hex = (picture.BackColor.ToArgb() & 0x00FFFFFF).ToString("X6");
                Color color = Color.FromArgb(Convert.ToInt32(hex, 16));
                panelHeader.BackColor = picture.BackColor;
                lbltitle.BackColor = picture.BackColor;
                lbltitle.Text = "#" + hex;
                Clipboard.SetText(lbltitle.Text);
                BackColor = Color.FromArgb(picture.BackColor.ToArgb());
                btnRandom.BackColor = Color.FromArgb(picture.BackColor.ToArgb());
                btnRandom.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            });
            body.Parent = picture;
            StringPack.Count = 1;
            if (StringPack.Count > 0)
            {
                StringPack.Count = +1;
                this.Controls.Add(picture);
            }

        }
        int locxresolver = 0;
        public void size(int x, int y)
        {
            Size loc = new Size(x, y);
            return;
        }
        public void width(int x,int y)
        {
            Point size = new Point(x, y);
        }
        private void BtnRandom_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                int d = 13;
                int y = 15;
                Createpic(0, d + locxresolver + y, 120, 60, "NewHexColor" + i, rnd.Next(255), rnd.Next(255), rnd.Next(255));
                Createpic(121, d + locxresolver + y, 120, 60, "NewHexColor" + i +rnd.Next(1000), rnd.Next(255), rnd.Next(255), rnd.Next(255));
                Createpic(121 + 120, d + locxresolver + y, 120, 60, "NewHexColor" + i + rnd.Next(1000 | 69), rnd.Next(255), rnd.Next(255), rnd.Next(255));
                Createpic(121 + 120 + 120, d + locxresolver + y, 120, 60, "NewHexColor" + i + rnd.Next(7888 | 1000), rnd.Next(255), rnd.Next(255), rnd.Next(255));
                Createpic(121 + 120 + 120 + 120, d + locxresolver + y, 120, 60, "NewHexColor" + i + rnd.Next(7888 | 1000), rnd.Next(255), rnd.Next(255), rnd.Next(255));
                Createpic(121 + 120 + 120 + 120 + 120, d + locxresolver + y, 120, 60, "NewHexColor" + i + rnd.Next(7888 | 1000), rnd.Next(255), rnd.Next(255), rnd.Next(255));
                Createpic(121 + 120 + 120 + 120 + 120 + 120, d + locxresolver + y, 120, 60, "NewHexColor" + i + rnd.Next(7888 | 1000), rnd.Next(255), rnd.Next(255), rnd.Next(255));
                Createpic(121 + 120 + 120 + 120 + 120 + 120 + 120, d + locxresolver + y, 120, 60, "NewHexColor" + i + rnd.Next(7888 | 1000), rnd.Next(255), rnd.Next(255), rnd.Next(255));
                Createpic(121 + 120 + 120 + 120 + 120 + 120 + 120 + 120, d + locxresolver + y, 120, 60, "NewHexColor" + i + rnd.Next(7888 | 1000), rnd.Next(255), rnd.Next(255), rnd.Next(255));
                Createpic(121 + 120 + 120 + 120 + 120 + 120 + 120 + 120 +120, d + locxresolver + y, 120, 60, "NewHexColor" + i + rnd.Next(7888 | 1000), rnd.Next(255), rnd.Next(255), rnd.Next(255));
                if (i > 0)
                {
                    locxresolver += 62;
                }
            }

        }

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        #region Form(Move)
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
       }
        #endregion
        #region Form(Borders)
    protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(BackColor);
            e.Graphics.FillRectangle(brush, Top);
            e.Graphics.FillRectangle(brush, Left);
            e.Graphics.FillRectangle(brush, Right);
            e.Graphics.FillRectangle(Brushes.Red, Bottom);
        }
    private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int _ = 10;

#pragma warning disable
        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
      
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }

        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }
#pragma warning restore
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84)
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(this.PointToClient(Cursor.Position))) message.Result = (IntPtr)HTBOTTOM;
            }
        }
#endregion
        #region PanelHeader(Mouse and LblTitle)
        int mouseX, mouseY;

        private void Lbltitle_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void Lbltitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
                this.body.Cursor = Cursors.SizeAll;
            }
        }

        private void Lbltitle_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            this.body.Cursor = Cursors.Default;
        }

        bool mouseDown;

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X;
            mouseY = e.Y;
        }
        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
                this.body.Cursor = Cursors.SizeAll;
            }
        }
        private void PanelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            this.body.Cursor = Cursors.Default;
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            EffectTitle.Enabled = true;
            EffectTitle.Interval = 100;
        }
        int EffectTitleCount = 0;
        private void EffectTitle_Tick(object sender, EventArgs e)
        {
            lbltitle.Parent = body;
            EffectTitleCount += 1;
            lbltitle.BackColor = TransparencyKey;
            lbltitle.Location = new Point(lbltitle.Location.X, lbltitle.Location.Y - 8);
            if (EffectTitleCount >= 4)
            {
                EffectTitle.Enabled = false;
                lbltitle.BackColor = panelHeader.BackColor;
                lbltitle.Parent = null;
                lbltitle.Parent = panelHeader;
                lbltitle.Update();
            }
        }
    }
}
