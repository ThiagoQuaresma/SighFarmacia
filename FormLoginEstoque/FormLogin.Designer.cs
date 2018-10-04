namespace FormLoginEstoque
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.bunifuThinButton1 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextbox2 = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuThinButton1
            // 
            this.bunifuThinButton1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.bunifuThinButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuThinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton1.ButtonText = "Entrar";
            this.bunifuThinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton1.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton1.ForeColorHoverState = System.Drawing.Color.DarkGreen;
            this.bunifuThinButton1.Iconimage = null;
            this.bunifuThinButton1.IconVisible = true;
            this.bunifuThinButton1.IconZoom = 90D;
            this.bunifuThinButton1.ImageIconOverlay = true;
            this.bunifuThinButton1.Location = new System.Drawing.Point(119, 238);
            this.bunifuThinButton1.Name = "bunifuThinButton1";
            this.bunifuThinButton1.Size = new System.Drawing.Size(184, 36);
            this.bunifuThinButton1.TabIndex = 0;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.Black;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(63, 97);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(305, 34);
            this.bunifuTextbox1.TabIndex = 1;
            this.bunifuTextbox1.text = "User Name";
            // 
            // bunifuTextbox2
            // 
            this.bunifuTextbox2.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox2.BackgroundImage")));
            this.bunifuTextbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox2.ForeColor = System.Drawing.Color.Black;
            this.bunifuTextbox2.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox2.Icon")));
            this.bunifuTextbox2.Location = new System.Drawing.Point(63, 168);
            this.bunifuTextbox2.Name = "bunifuTextbox2";
            this.bunifuTextbox2.Size = new System.Drawing.Size(305, 34);
            this.bunifuTextbox2.TabIndex = 2;
            this.bunifuTextbox2.text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.bunifuTextbox1);
            this.panel1.Controls.Add(this.bunifuThinButton1);
            this.panel1.Controls.Add(this.bunifuTextbox2);
            this.panel1.Location = new System.Drawing.Point(199, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 313);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton1;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox2;
        private System.Windows.Forms.Panel panel1;
    }
}

