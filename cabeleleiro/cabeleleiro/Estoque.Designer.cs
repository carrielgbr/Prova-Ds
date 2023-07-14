namespace cabeleleiro
{
    partial class Estoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.cbxEstoque = new System.Windows.Forms.ComboBox();
            this.txtQTDE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantidade = new System.Windows.Forms.Label();
            this.BTNCAdastrar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.serviçosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.serviçosToolStripMenuItem.Text = "Serviço";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(469, 62);
            this.dgvEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.RowHeadersWidth = 51;
            this.dgvEstoque.Size = new System.Drawing.Size(557, 284);
            this.dgvEstoque.TabIndex = 1;
            this.dgvEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbxEstoque
            // 
            this.cbxEstoque.FormattingEnabled = true;
            this.cbxEstoque.Location = new System.Drawing.Point(123, 101);
            this.cbxEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEstoque.Name = "cbxEstoque";
            this.cbxEstoque.Size = new System.Drawing.Size(253, 24);
            this.cbxEstoque.TabIndex = 2;
            // 
            // txtQTDE
            // 
            this.txtQTDE.Location = new System.Drawing.Point(123, 199);
            this.txtQTDE.Margin = new System.Windows.Forms.Padding(4);
            this.txtQTDE.Name = "txtQTDE";
            this.txtQTDE.Size = new System.Drawing.Size(253, 22);
            this.txtQTDE.TabIndex = 3;
            this.txtQTDE.TextChanged += new System.EventHandler(this.txtQTDE_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Produto";
            // 
            // quantidade
            // 
            this.quantidade.AutoSize = true;
            this.quantidade.Location = new System.Drawing.Point(17, 203);
            this.quantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(77, 16);
            this.quantidade.TabIndex = 5;
            this.quantidade.Text = "Quantidade";
            // 
            // BTNCAdastrar
            // 
            this.BTNCAdastrar.Location = new System.Drawing.Point(176, 318);
            this.BTNCAdastrar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCAdastrar.Name = "BTNCAdastrar";
            this.BTNCAdastrar.Size = new System.Drawing.Size(100, 28);
            this.BTNCAdastrar.TabIndex = 6;
            this.BTNCAdastrar.Text = "Cadastrar";
            this.BTNCAdastrar.UseVisualStyleBackColor = true;
            this.BTNCAdastrar.Click += new System.EventHandler(this.BTNCAdastrar_Click);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 409);
            this.Controls.Add(this.BTNCAdastrar);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQTDE);
            this.Controls.Add(this.cbxEstoque);
            this.Controls.Add(this.dgvEstoque);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Estoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.ComboBox cbxEstoque;
        private System.Windows.Forms.TextBox txtQTDE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quantidade;
        private System.Windows.Forms.Button BTNCAdastrar;
    }
}