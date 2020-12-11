using MySql.Data.MySqlClient;
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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            LoginInfo.id = 0;

            menu menu = new menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnGanhos_Click(object sender, EventArgs e)
        {
            Ganhos ganhos = new Ganhos();
            this.Hide();
            ganhos.ShowDialog();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            Gastos gastos = new Gastos();
            this.Hide();
            gastos.ShowDialog();

        }

        private void tnSaldo_Click(object sender, EventArgs e)
        
            {
                

                var con = "server=localhost;database=tkpoff;uid=root;senha=";
                var connection = new MySqlConnection(con);
                var command = connection.CreateCommand();

                try
                {
                    connection.Open();
                    String query = "select saldo from contas where idUsuario = " + LoginInfo.id + " and tipoConta = 'GANHOS' order by id desc limit 1; ";
                    command.CommandText = query;
                    MySqlDataReader reader = command.ExecuteReader();
                    double saldo = 0;
                    while (reader.Read())
                    {
                        saldo = (double)reader[0];

                    }

                MessageBox.Show("Seu gasto atual é de: R$ " + saldo);
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar");

                }
                finally
                {

                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            
           
        }

        private void btnObjetivos_Click(object sender, EventArgs e)
        {
            Objetivos obj = new Objetivos();
            this.Hide();
            obj.ShowDialog();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
