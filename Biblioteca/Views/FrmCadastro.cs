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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btn_Aluno_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Realize seu cadastro!");
                Form FrmCadastroAluno = new FrmCadastroAluno();
                FrmCadastroAluno.ShowDialog();
        }

        private void btn_Professor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realize seu cadastro!");
            Form FrmCadastroProfessor = new FrmCadastroProfessor();
            FrmCadastroProfessor.ShowDialog();
        }

        private void btn_Funcionario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realize seu cadastro!");
            Form FrmCadastroFuncionario = new FrmCadastroFuncionario();
            FrmCadastroFuncionario.ShowDialog();
        }
    }
}
