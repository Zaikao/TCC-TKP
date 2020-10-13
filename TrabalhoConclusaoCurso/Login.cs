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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem - Vindo!");
            menu menu = new menu();
            this.Hide();
            menu.ShowDialog();
            
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtemail.Text = string.Empty;
            txtsenha.Text = string.Empty;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
