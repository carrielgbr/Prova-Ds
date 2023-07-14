namespace cabeleleiro
{
    partial class Logar
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
            this.Usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNentrar = new System.Windows.Forms.Button();
            this.BTNvoltar = new System.Windows.Forms.Button();
            this.TXTUsuario = new System.Windows.Forms.TextBox();
            this.TXTsenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(77, 124);
            this.Usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(54, 16);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // BTNentrar
            // 
            this.BTNentrar.Location = new System.Drawing.Point(495, 270);
            this.BTNentrar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNentrar.Name = "BTNentrar";
            this.BTNentrar.Size = new System.Drawing.Size(100, 28);
            this.BTNentrar.TabIndex = 2;
            this.BTNentrar.Text = "Entrar";
            this.BTNentrar.UseVisualStyleBackColor = true;
            this.BTNentrar.Click += new System.EventHandler(this.BTNentrar_Click);
            // 
            // BTNvoltar
            // 
            this.BTNvoltar.Location = new System.Drawing.Point(175, 270);
            this.BTNvoltar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNvoltar.Name = "BTNvoltar";
            this.BTNvoltar.Size = new System.Drawing.Size(100, 28);
            this.BTNvoltar.TabIndex = 3;
            this.BTNvoltar.Text = "Voltar";
            this.BTNvoltar.UseVisualStyleBackColor = true;
            this.BTNvoltar.Click += new System.EventHandler(this.BTNvoltar_Click);
            // 
            // TXTUsuario
            // 
            this.TXTUsuario.Location = new System.Drawing.Point(204, 121);
            this.TXTUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TXTUsuario.Name = "TXTUsuario";
            this.TXTUsuario.Size = new System.Drawing.Size(411, 22);
            this.TXTUsuario.TabIndex = 4;
            // 
            // TXTsenha
            // 
            this.TXTsenha.Location = new System.Drawing.Point(204, 191);
            this.TXTsenha.Margin = new System.Windows.Forms.Padding(4);
            this.TXTsenha.Name = "TXTsenha";
            this.TXTsenha.PasswordChar = '*';
            this.TXTsenha.Size = new System.Drawing.Size(411, 22);
            this.TXTsenha.TabIndex = 5;
            this.TXTsenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "TELA DE LOGIN";
            // 
            // Logar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTsenha);
            this.Controls.Add(this.TXTUsuario);
            this.Controls.Add(this.BTNvoltar);
            this.Controls.Add(this.BTNentrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Usuario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Logar";
            this.Text = "Logar";
            this.Load += new System.EventHandler(this.Logar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNentrar;
        private System.Windows.Forms.Button BTNvoltar;
        private System.Windows.Forms.TextBox TXTUsuario;
        private System.Windows.Forms.TextBox TXTsenha;
        private System.Windows.Forms.Label label1;
    }
}