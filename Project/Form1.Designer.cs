namespace Project
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.EffectTitle = new System.Windows.Forms.Timer(this.components);
            this.lbltitle = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.PictureBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.windowcontrols1 = new Project.controls.windowcontrols();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.body)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.Purple;
            this.panelHeader.Controls.Add(this.windowcontrols1);
            this.panelHeader.Location = new System.Drawing.Point(0, -4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelHeader.Size = new System.Drawing.Size(514, 34);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            // 
            // EffectTitle
            // 
            this.EffectTitle.Interval = 1000;
            this.EffectTitle.Tick += new System.EventHandler(this.EffectTitle_Tick);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbltitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltitle.Font = new System.Drawing.Font("YD2002", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbltitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbltitle.Location = new System.Drawing.Point(12, 36);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(128, 21);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "Color Picker";
            this.lbltitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lbltitle_MouseDown);
            this.lbltitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lbltitle_MouseMove);
            this.lbltitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Lbltitle_MouseUp);
            // 
            // body
            // 
            this.body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.body.BackColor = global::Project.Properties.Settings.Default.DesignColor;
            this.body.Location = new System.Drawing.Point(3, 3);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(508, 290);
            this.body.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.body.TabIndex = 3;
            this.body.TabStop = false;
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRandom.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRandom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRandom.FlatAppearance.BorderSize = 0;
            this.btnRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnRandom.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnRandom.Location = new System.Drawing.Point(0, 267);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(514, 28);
            this.btnRandom.TabIndex = 4;
            this.btnRandom.Text = "Generate";
            this.btnRandom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // windowcontrols1
            // 
            this.windowcontrols1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowcontrols1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.windowcontrols1.Location = new System.Drawing.Point(430, 7);
            this.windowcontrols1.Name = "windowcontrols1";
            this.windowcontrols1.Size = new System.Drawing.Size(81, 24);
            this.windowcontrols1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Project.Properties.Settings.Default.DesignColor;
            this.ClientSize = new System.Drawing.Size(514, 295);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Simple Color Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.body)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Timer EffectTitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.PictureBox body;
        private controls.windowcontrols windowcontrols1;
        private System.Windows.Forms.Button btnRandom;
    }
}

