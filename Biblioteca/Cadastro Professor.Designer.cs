namespace Biblioteca
{
    partial class Cadastro_Professor
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
            this.txt_MateriaProf = new System.Windows.Forms.TextBox();
            this.txt_NomeProf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_Prof = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SenhaProf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_MateriaProf
            // 
            this.txt_MateriaProf.Location = new System.Drawing.Point(161, 73);
            this.txt_MateriaProf.Name = "txt_MateriaProf";
            this.txt_MateriaProf.Size = new System.Drawing.Size(100, 20);
            this.txt_MateriaProf.TabIndex = 11;
            // 
            // txt_NomeProf
            // 
            this.txt_NomeProf.Location = new System.Drawing.Point(161, 29);
            this.txt_NomeProf.Name = "txt_NomeProf";
            this.txt_NomeProf.Size = new System.Drawing.Size(100, 20);
            this.txt_NomeProf.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Matéria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // chk_Prof
            // 
            this.chk_Prof.AutoSize = true;
            this.chk_Prof.Location = new System.Drawing.Point(94, 166);
            this.chk_Prof.Name = "chk_Prof";
            this.chk_Prof.Size = new System.Drawing.Size(125, 17);
            this.chk_Prof.TabIndex = 12;
            this.chk_Prof.Text = "É professor da ETEC";
            this.chk_Prof.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Senha:";
            // 
            // txt_SenhaProf
            // 
            this.txt_SenhaProf.Location = new System.Drawing.Point(161, 120);
            this.txt_SenhaProf.Name = "txt_SenhaProf";
            this.txt_SenhaProf.PasswordChar = '*';
            this.txt_SenhaProf.Size = new System.Drawing.Size(100, 20);
            this.txt_SenhaProf.TabIndex = 14;
            // 
            // Cadastro_Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_SenhaProf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chk_Prof);
            this.Controls.Add(this.txt_MateriaProf);
            this.Controls.Add(this.txt_NomeProf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro_Professor";
            this.Text = "Cadastro_Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MateriaProf;
        private System.Windows.Forms.TextBox txt_NomeProf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_Prof;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SenhaProf;
    }
}