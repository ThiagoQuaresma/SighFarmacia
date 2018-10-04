namespace SlideMenu
{
    partial class UserSearchControl
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSearchControl));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Via = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ML = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(19, 48);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(201, 21);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Consultar Medicamento";
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(224, 45);
            this.bunifuTextbox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(293, 30);
            this.bunifuTextbox1.TabIndex = 2;
            this.bunifuTextbox1.text = "";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Fabricação,
            this.Validade,
            this.Tarja,
            this.Lote,
            this.Via,
            this.Quantidade,
            this.ML});
            this.dataGridView2.Location = new System.Drawing.Point(9, 85);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(508, 381);
            this.dataGridView2.TabIndex = 4;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Fabricação
            // 
            this.Fabricação.HeaderText = "Fabricação";
            this.Fabricação.Name = "Fabricação";
            this.Fabricação.ReadOnly = true;
            // 
            // Validade
            // 
            this.Validade.HeaderText = "Validade";
            this.Validade.Name = "Validade";
            this.Validade.ReadOnly = true;
            // 
            // Tarja
            // 
            this.Tarja.HeaderText = "Tarja";
            this.Tarja.Name = "Tarja";
            this.Tarja.ReadOnly = true;
            // 
            // Lote
            // 
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            // 
            // Via
            // 
            this.Via.HeaderText = "Via";
            this.Via.Name = "Via";
            this.Via.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // ML
            // 
            this.ML.HeaderText = "ML";
            this.ML.Name = "ML";
            this.ML.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(3, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 458);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca por Medicamento";
            // 
            // UserSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserSearchControl";
            this.Size = new System.Drawing.Size(523, 475);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Via;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ML;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
