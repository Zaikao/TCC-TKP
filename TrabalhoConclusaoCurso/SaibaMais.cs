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
    public partial class SaibaMais : Form
    {
        public SaibaMais()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SaibaMais_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
