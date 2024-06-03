using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmCadastroAluno : Form
    {
        Aluno al;

        public FrmCadastroAluno()
        {
            InitializeComponent();
    
        }

        private void btnVoltarAluno_Click(object sender, EventArgs e)
        {
            Form FrmCadastro = new FrmCadastro();
            FrmCadastro.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txt_NomeAluno.Text == "") return;

            al = new Aluno()
            {
                nome_aluno = txt_NomeAluno.Text,
                rm = txt_RmAluno.Text,
                senha_aluno = txt_SenhaAluno.Text
            };

            al.Salvar(al.nome_aluno, al.senha_aluno, al.rm);

            limpaControles();
          
        }

        public void limpaControles()
        {
            txt_NomeAluno.Clear();
            txt_RmAluno.Clear();
            txt_SenhaAluno.Clear();
            chk_Aluno.Checked = false;
        }

        private void FrmCadastroAluno_Load(object sender, EventArgs e)
        {

        }
    }
}
