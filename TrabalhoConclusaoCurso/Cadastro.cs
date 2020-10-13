using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoConclusaoCurso
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void lbllogin_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Text = string.Empty;
            txtidade.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtsenha.Text = string.Empty;
            txtcsenha.Text = string.Empty;
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você foi cadastrado!");
            
        }
    }
}
