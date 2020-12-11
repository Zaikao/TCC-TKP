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
    public partial class Objetivos : Form
    {
        public Objetivos()
        {
            InitializeComponent();
        }

        private void btnObjetivos_Click(object sender, EventArgs e)
        {
            InserçãoObjetivo io = new InserçãoObjetivo();
            this.Hide();
            io.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaPrincipal tp = new TelaPrincipal();
            this.Hide();
            tp.ShowDialog();
        }

        private void btnMyObjetivos_Click(object sender, EventArgs e)
        {
            MeusObjetivos myObj = new MeusObjetivos();
            this.Hide();
            myObj.ShowDialog();
        }
    }
}
