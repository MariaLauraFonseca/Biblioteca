namespace Biblioteca
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NomeLogin = new System.Windows.Forms.TextBox();
            this.txt_SenhaLogin = new System.Windows.Forms.TextBox();
            this.btn_EntrarLogin = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // txt_NomeLogin
            // 
            this.txt_NomeLogin.Location = new System.Drawing.Point(328, 83);
            this.txt_NomeLogin.Name = "txt_NomeLogin";
            this.txt_NomeLogin.Size = new System.Drawing.Size(100, 20);
            this.txt_NomeLogin.TabIndex = 2;
            // 
            // txt_SenhaLogin
            // 
            this.txt_SenhaLogin.Location = new System.Drawing.Point(328, 131);
            this.txt_SenhaLogin.Name = "txt_SenhaLogin";
            this.txt_SenhaLogin.PasswordChar = '*';
            this.txt_SenhaLogin.Size = new System.Drawing.Size(100, 20);
            this.txt_SenhaLogin.TabIndex = 3;
            // 
            // btn_EntrarLogin
            // 
            this.btn_EntrarLogin.Location = new System.Drawing.Point(227, 180);
            this.btn_EntrarLogin.Name = "btn_EntrarLogin";
            this.btn_EntrarLogin.Size = new System.Drawing.Size(75, 23);
            this.btn_EntrarLogin.TabIndex = 4;
            this.btn_EntrarLogin.Text = "Entrar";
            this.btn_EntrarLogin.UseVisualStyleBackColor = true;
            this.btn_EntrarLogin.Click += new System.EventHandler(this.btn_EntrarLogin_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(402, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btn_EntrarLogin);
            this.Controls.Add(this.txt_SenhaLogin);
            this.Controls.Add(this.txt_NomeLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Text = "Sistema_Biblioteca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NomeLogin;
        private System.Windows.Forms.TextBox txt_SenhaLogin;
        private System.Windows.Forms.Button btn_EntrarLogin;
        private System.Windows.Forms.Button btnCancelar;
    }
}

