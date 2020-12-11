using System;
using System.Windows.Forms;

namespace TrabalhoConclusaoCurso
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }


        private void btnsaibamais_Click(object sender, EventArgs e)
        {
            SaibaMais saibamais = new SaibaMais();
            this.Hide();
            saibamais.ShowDialog();
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            this.Hide();
            cadastro.ShowDialog();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void btndesejo_Click(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
