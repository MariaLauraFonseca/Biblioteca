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
    public partial class FrmCadastroFuncionario : Form
    {
        Funcionario func;
        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btnVoltarFuncionario_Click(object sender, EventArgs e)
        {
            Form FrmCadastro = new FrmCadastro();
            FrmCadastro.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txt_NomeFun.Text == "") return;

            func = new Funcionario()
            {
                nome_funcionario = txt_NomeFun.Text,
                funcao_funcionario = txt_FuncaoFun.Text,
                senha_funcionario = txt_FuncaoFun.Text,

            };

            func.Salvar(func.nome_funcionario, func.senha_funcionario, func.funcao_funcionario);

            limpaControles();
        }

        public void limpaControles()
        {
            txt_NomeFun.Clear();
            txt_FuncaoFun.Clear();
            txt_SenhaFun.Clear();
            chk_Fun.Checked = false;
        }
    }
}
