namespace Biblioteca
{
    partial class FrmCadastro
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
            this.btn_Aluno = new System.Windows.Forms.Button();
            this.btn_Professor = new System.Windows.Forms.Button();
            this.btn_Funcionario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Aluno
            // 
            this.btn_Aluno.Location = new System.Drawing.Point(116, 138);
            this.btn_Aluno.Name = "btn_Aluno";
            this.btn_Aluno.Size = new System.Drawing.Size(75, 23);
            this.btn_Aluno.TabIndex = 0;
            this.btn_Aluno.Text = "Aluno";
            this.btn_Aluno.UseVisualStyleBackColor = true;
            this.btn_Aluno.Click += new System.EventHandler(this.btn_Aluno_Click);
            // 
            // btn_Professor
            // 
            this.btn_Professor.Location = new System.Drawing.Point(259, 138);
            this.btn_Professor.Name = "btn_Professor";
            this.btn_Professor.Size = new System.Drawing.Size(75, 23);
            this.btn_Professor.TabIndex = 1;
            this.btn_Professor.Text = "Professor";
            this.btn_Professor.UseVisualStyleBackColor = true;
            this.btn_Professor.Click += new System.EventHandler(this.btn_Professor_Click);
            // 
            // btn_Funcionario
            // 
            this.btn_Funcionario.Location = new System.Drawing.Point(410, 138);
            this.btn_Funcionario.Name = "btn_Funcionario";
            this.btn_Funcionario.Size = new System.Drawing.Size(75, 23);
            this.btn_Funcionario.TabIndex = 2;
            this.btn_Funcionario.Text = "Funcionário";
            this.btn_Funcionario.UseVisualStyleBackColor = true;
            this.btn_Funcionario.Click += new System.EventHandler(this.btn_Funcionario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Em qual categoria você se encaixa?";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(30, 405);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Livro";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Funcionario);
            this.Controls.Add(this.btn_Professor);
            this.Controls.Add(this.btn_Aluno);
            this.Name = "FrmCadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Aluno;
        private System.Windows.Forms.Button btn_Professor;
        private System.Windows.Forms.Button btn_Funcionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button button1;
    }
}