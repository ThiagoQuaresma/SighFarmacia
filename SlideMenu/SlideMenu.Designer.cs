namespace SlideMenu
{
    partial class SlideMenu
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlideMenu));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sidemenu = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMnu = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BodyMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LogoAnimator = new BunifuAnimatorNS.Animator(this.components);
            this.PanelAnimator = new BunifuAnimatorNS.Animator(this.components);
            this.sidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMnu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.BodyMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sidemenu.Controls.Add(this.pictureBox3);
            this.sidemenu.Controls.Add(this.btnMnu);
            this.sidemenu.Controls.Add(this.bunifuFlatButton5);
            this.sidemenu.Controls.Add(this.bunifuFlatButton4);
            this.sidemenu.Controls.Add(this.bunifuFlatButton3);
            this.sidemenu.Controls.Add(this.bunifuFlatButton2);
            this.sidemenu.Controls.Add(this.bunifuFlatButton1);
            this.sidemenu.Controls.Add(this.logo);
            this.PanelAnimator.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 62);
            this.sidemenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(471, 730);
            this.sidemenu.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.LogoAnimator.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 49);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // btnMnu
            // 
            this.btnMnu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMnu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.PanelAnimator.SetDecoration(this.btnMnu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnMnu, BunifuAnimatorNS.DecorationType.None);
            this.btnMnu.Image = ((System.Drawing.Image)(resources.GetObject("btnMnu.Image")));
            this.btnMnu.ImageActive = null;
            this.btnMnu.Location = new System.Drawing.Point(428, 25);
            this.btnMnu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMnu.Name = "btnMnu";
            this.btnMnu.Size = new System.Drawing.Size(39, 35);
            this.btnMnu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMnu.TabIndex = 1;
            this.btnMnu.TabStop = false;
            this.btnMnu.Zoom = 10;
            this.btnMnu.Click += new System.EventHandler(this.btnMnu_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "                 Encerrar Sessão";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = true;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 611);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(471, 74);
            this.bunifuFlatButton5.TabIndex = 6;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "     Solicitar Medicamento";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconZoom = 50D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 325);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(471, 74);
            this.bunifuFlatButton4.TabIndex = 5;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "     Listar Pedidos";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconZoom = 50D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 408);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(471, 74);
            this.bunifuFlatButton3.TabIndex = 4;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "     Consultar Medicamento";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 242);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(471, 74);
            this.bunifuFlatButton2.TabIndex = 3;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "     Cadastrar Medicamento";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 158);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(471, 74);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // logo
            // 
            this.LogoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(70, 9);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(266, 125);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.header.Controls.Add(this.bunifuImageButton2);
            this.PanelAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1188, 62);
            this.header.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.LogoAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(51, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.LogoAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(96, 14);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(222, 30);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Menu de Estoque";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PanelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1142, 11);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(39, 35);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // BodyMain
            // 
            this.BodyMain.AutoSize = true;
            this.BodyMain.Controls.Add(this.panel1);
            this.PanelAnimator.SetDecoration(this.BodyMain, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.BodyMain, BunifuAnimatorNS.DecorationType.None);
            this.BodyMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyMain.Location = new System.Drawing.Point(471, 62);
            this.BodyMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BodyMain.Name = "BodyMain";
            this.BodyMain.Size = new System.Drawing.Size(717, 730);
            this.BodyMain.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.PanelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(87, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 304);
            this.panel1.TabIndex = 3;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.LogoAnimator.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(69, 108);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(385, 48);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "Menu de Medicamentos";
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation1;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation2;
            // 
            // SlideMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1188, 792);
            this.Controls.Add(this.BodyMain);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.header);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SlideMenu";
            this.Text = "Form1";
            this.sidemenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMnu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.BodyMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel sidemenu;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton btnMnu;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel BodyMain;
        private BunifuAnimatorNS.Animator PanelAnimator;
        private BunifuAnimatorNS.Animator LogoAnimator;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}

