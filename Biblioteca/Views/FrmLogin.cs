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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_EntrarLogin_Click(object sender, EventArgs e)
        {
            if(txt_NomeLogin.Text == "Clara" && txt_SenhaLogin.Text == "123")
            {
                MessageBox.Show("Bem vindo ao sistema!");
                Form FrmLivros = new FrmPrincipal();
                FrmLivros.ShowDialog();

            }
            else
            {
                MessageBox.Show("Login ou Senha inválidos!");
            }
          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form FrmPrincipal = new FrmPrincipal();
            FrmPrincipal.ShowDialog();
        }
    }
}
