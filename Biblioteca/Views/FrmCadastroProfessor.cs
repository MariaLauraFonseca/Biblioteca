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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Biblioteca
{
    public partial class FrmCadastroProfessor : Form
    {
        Professor prof;
        public FrmCadastroProfessor()
        {
            InitializeComponent();
        }

        private void btnVoltarProfessor_Click(object sender, EventArgs e)
        {
            Form FrmCadastro = new FrmCadastro();
            FrmCadastro.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txt_NomeProf.Text == "") return;

            prof = new Professor()
            {
                nome_professor = txt_NomeProf.Text,
                materia = txt_MateriaProf.Text,
                senha_professor = txt_SenhaProf.Text,
            };

            prof.Salvar(prof.nome_professor, prof.senha_professor, prof.materia);

            limpaControles();

        }

        public void limpaControles()
        {
            txt_NomeProf.Clear();
            txt_MateriaProf.Clear();
            txt_SenhaProf.Clear();
            chk_Prof.Checked = false;
        }
    }
}
