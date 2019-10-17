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
            this.lblhex = new System.Windows.Forms.Label();
            this.Btncopy = new System.Windows.Forms.Button();
            this.hexcolor = new System.Windows.Forms.PictureBox();
            this.diagcolor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.hexcolor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblhex
            // 
            this.lblhex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblhex.AutoSize = true;
            this.lblhex.Location = new System.Drawing.Point(201, 205);
            this.lblhex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhex.Name = "lblhex";
            this.lblhex.Size = new System.Drawing.Size(11, 15);
            this.lblhex.TabIndex = 0;
            this.lblhex.Text = ":";
            // 
            // Btncopy
            // 
            this.Btncopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btncopy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btncopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncopy.Location = new System.Drawing.Point(355, 181);
            this.Btncopy.Name = "Btncopy";
            this.Btncopy.Size = new System.Drawing.Size(85, 21);
            this.Btncopy.TabIndex = 1;
            this.Btncopy.Text = "Copiar";
            this.Btncopy.UseVisualStyleBackColor = true;
            this.Btncopy.Click += new System.EventHandler(this.Btncopy_Click);
            // 
            // hexcolor
            // 
            this.hexcolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hexcolor.Location = new System.Drawing.Point(355, 132);
            this.hexcolor.Name = "hexcolor";
            this.hexcolor.Size = new System.Drawing.Size(85, 43);
            this.hexcolor.TabIndex = 2;
            this.hexcolor.TabStop = false;
            this.hexcolor.Click += new System.EventHandler(this.hexcolor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 229);
            this.Controls.Add(this.hexcolor);
            this.Controls.Add(this.Btncopy);
            this.Controls.Add(this.lblhex);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Color Picker in c#";
            ((System.ComponentModel.ISupportInitialize)(this.hexcolor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhex;
        private System.Windows.Forms.Button Btncopy;
        private System.Windows.Forms.PictureBox hexcolor;
        private System.Windows.Forms.ColorDialog diagcolor;
    }
}

