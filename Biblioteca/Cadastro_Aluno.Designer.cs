namespace Biblioteca
{
    partial class Cadastro_Aluno
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
            this.chk_Aluno = new System.Windows.Forms.CheckBox();
            this.txt_RmAluno = new System.Windows.Forms.TextBox();
            this.txt_NomeAluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SenhaAluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_Aluno
            // 
            this.chk_Aluno.AutoSize = true;
            this.chk_Aluno.Location = new System.Drawing.Point(86, 173);
            this.chk_Aluno.Name = "chk_Aluno";
            this.chk_Aluno.Size = new System.Drawing.Size(129, 17);
            this.chk_Aluno.TabIndex = 18;
            this.chk_Aluno.Text = "É estudante da ETEC";
            this.chk_Aluno.UseVisualStyleBackColor = true;
            // 
            // txt_RmAluno
            // 
            this.txt_RmAluno.Location = new System.Drawing.Point(153, 87);
            this.txt_RmAluno.Name = "txt_RmAluno";
            this.txt_RmAluno.Size = new System.Drawing.Size(100, 20);
            this.txt_RmAluno.TabIndex = 17;
            // 
            // txt_NomeAluno
            // 
            this.txt_NomeAluno.Location = new System.Drawing.Point(153, 43);
            this.txt_NomeAluno.Name = "txt_NomeAluno";
            this.txt_NomeAluno.Size = new System.Drawing.Size(100, 20);
            this.txt_NomeAluno.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "RM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome:";
            // 
            // txt_SenhaAluno
            // 
            this.txt_SenhaAluno.Location = new System.Drawing.Point(153, 134);
            this.txt_SenhaAluno.Name = "txt_SenhaAluno";
            this.txt_SenhaAluno.PasswordChar = '*';
            this.txt_SenhaAluno.Size = new System.Drawing.Size(100, 20);
            this.txt_SenhaAluno.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 19;
            // 
            // Cadastro_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_SenhaAluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chk_Aluno);
            this.Controls.Add(this.txt_RmAluno);
            this.Controls.Add(this.txt_NomeAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro_Aluno";
            this.Text = "Cadastro Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Aluno;
        private System.Windows.Forms.TextBox txt_RmAluno;
        private System.Windows.Forms.TextBox txt_NomeAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SenhaAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}