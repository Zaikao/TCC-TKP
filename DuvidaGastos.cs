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
    public partial class DuvidaGastos : Form
    {
        public DuvidaGastos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Gastos gastos = new Gastos();
            this.Hide();
            gastos.ShowDialog();

        }
    }
}
