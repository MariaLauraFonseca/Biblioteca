namespace Biblioteca
{
    partial class FrmCadastroFuncionario
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
            this.chk_Fun = new System.Windows.Forms.CheckBox();
            this.txt_FuncaoFun = new System.Windows.Forms.TextBox();
            this.txt_NomeFun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SenhaFun = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltarFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chk_Fun
            // 
            this.chk_Fun.AutoSize = true;
            this.chk_Fun.Location = new System.Drawing.Point(77, 183);
            this.chk_Fun.Name = "chk_Fun";
            this.chk_Fun.Size = new System.Drawing.Size(114, 17);
            this.chk_Fun.TabIndex = 17;
            this.chk_Fun.Text = "Trabalha na ETEC";
            this.chk_Fun.UseVisualStyleBackColor = true;
            // 
            // txt_FuncaoFun
            // 
            this.txt_FuncaoFun.Location = new System.Drawing.Point(144, 89);
            this.txt_FuncaoFun.Name = "txt_FuncaoFun";
            this.txt_FuncaoFun.Size = new System.Drawing.Size(100, 20);
            this.txt_FuncaoFun.TabIndex = 16;
            // 
            // txt_NomeFun
            // 
            this.txt_NomeFun.Location = new System.Drawing.Point(144, 45);
            this.txt_NomeFun.Name = "txt_NomeFun";
            this.txt_NomeFun.Size = new System.Drawing.Size(100, 20);
            this.txt_NomeFun.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Função:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome:";
            // 
            // txt_SenhaFun
            // 
            this.txt_SenhaFun.Location = new System.Drawing.Point(144, 135);
            this.txt_SenhaFun.Name = "txt_SenhaFun";
            this.txt_SenhaFun.PasswordChar = '*';
            this.txt_SenhaFun.Size = new System.Drawing.Size(100, 20);
            this.txt_SenhaFun.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 18;
            // 
            // btnVoltarFuncionario
            // 
            this.btnVoltarFuncionario.Location = new System.Drawing.Point(22, 406);
            this.btnVoltarFuncionario.Name = "btnVoltarFuncionario";
            this.btnVoltarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarFuncionario.TabIndex = 21;
            this.btnVoltarFuncionario.Text = "Voltar";
            this.btnVoltarFuncionario.UseVisualStyleBackColor = true;
            this.btnVoltarFuncionario.Click += new System.EventHandler(this.btnVoltarFuncionario_Click);
            // 
            // FrmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltarFuncionario);
            this.Controls.Add(this.txt_SenhaFun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chk_Fun);
            this.Controls.Add(this.txt_FuncaoFun);
            this.Controls.Add(this.txt_NomeFun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastroFuncionario";
            this.Text = "Cadastro_Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Fun;
        private System.Windows.Forms.TextBox txt_FuncaoFun;
        private System.Windows.Forms.TextBox txt_NomeFun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SenhaFun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltarFuncionario;
    }
}