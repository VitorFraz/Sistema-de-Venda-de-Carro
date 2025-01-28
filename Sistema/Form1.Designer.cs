namespace Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonl_limpar = new System.Windows.Forms.Button();
            this.button_mostrarSenha = new System.Windows.Forms.Button();
            this.button_entrar = new System.Windows.Forms.Button();
            this.textBox_Senha = new System.Windows.Forms.TextBox();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMenssagem = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.labelMenssagem);
            this.groupBox1.Controls.Add(this.buttonl_limpar);
            this.groupBox1.Controls.Add(this.button_mostrarSenha);
            this.groupBox1.Controls.Add(this.button_entrar);
            this.groupBox1.Controls.Add(this.textBox_Senha);
            this.groupBox1.Controls.Add(this.textBox_usuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(641, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acesso ao Sistema";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonl_limpar
            // 
            this.buttonl_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonl_limpar.Location = new System.Drawing.Point(255, 84);
            this.buttonl_limpar.Name = "buttonl_limpar";
            this.buttonl_limpar.Size = new System.Drawing.Size(109, 29);
            this.buttonl_limpar.TabIndex = 6;
            this.buttonl_limpar.Text = "Limpar Campos";
            this.buttonl_limpar.UseVisualStyleBackColor = true;
            this.buttonl_limpar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_mostrarSenha
            // 
            this.button_mostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mostrarSenha.Location = new System.Drawing.Point(255, 145);
            this.button_mostrarSenha.Name = "button_mostrarSenha";
            this.button_mostrarSenha.Size = new System.Drawing.Size(109, 31);
            this.button_mostrarSenha.TabIndex = 5;
            this.button_mostrarSenha.Text = "Mostrar Senha";
            this.button_mostrarSenha.UseVisualStyleBackColor = true;
            this.button_mostrarSenha.Click += new System.EventHandler(this.button_mostrarSenha_Click);
            // 
            // button_entrar
            // 
            this.button_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_entrar.Location = new System.Drawing.Point(167, 201);
            this.button_entrar.Name = "button_entrar";
            this.button_entrar.Size = new System.Drawing.Size(82, 31);
            this.button_entrar.TabIndex = 4;
            this.button_entrar.Text = "Entrar";
            this.button_entrar.UseVisualStyleBackColor = true;
            this.button_entrar.Click += new System.EventHandler(this.button_entrar_Click);
            // 
            // textBox_Senha
            // 
            this.textBox_Senha.Location = new System.Drawing.Point(39, 152);
            this.textBox_Senha.Name = "textBox_Senha";
            this.textBox_Senha.PasswordChar = '*';
            this.textBox_Senha.Size = new System.Drawing.Size(210, 20);
            this.textBox_Senha.TabIndex = 3;
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Location = new System.Drawing.Point(39, 89);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(210, 20);
            this.textBox_usuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(406, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 232);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelMenssagem
            // 
            this.labelMenssagem.AutoSize = true;
            this.labelMenssagem.Location = new System.Drawing.Point(164, 184);
            this.labelMenssagem.Name = "labelMenssagem";
            this.labelMenssagem.Size = new System.Drawing.Size(0, 13);
            this.labelMenssagem.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1155, 588);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cadastro de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_mostrarSenha;
        private System.Windows.Forms.Button button_entrar;
        private System.Windows.Forms.TextBox textBox_Senha;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.Button buttonl_limpar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMenssagem;
    }
}

