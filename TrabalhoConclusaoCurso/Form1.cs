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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
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
