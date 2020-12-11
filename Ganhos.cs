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
    public partial class Ganhos : Form
    {
        public Ganhos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaPrincipal tp = new TelaPrincipal();
            this.Hide();
            tp.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSalario.Text = string.Empty;
            txtRendaExtra.Text = string.Empty;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if(!validate())
            {
                MessageBox.Show("É necessário preencher todos os campos, mesmo que para inserir o valor 0 em um deles, para que seu dinheiro seja salvo!");
                return;
            }

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
                saldo += Double.Parse(txtSalario.Text) + Double.Parse(txtRendaExtra.Text);

                connection.Close();
                connection.Open();

                command.CommandText = "insert into contas (saldo, dataCadastro, tipoConta, idUsuario) values (" + saldo + ", now(), 'GANHOS', " + LoginInfo.id + ")";
                command.ExecuteNonQuery();
                MessageBox.Show("Seu dinheiro foi inserido com sucesso!");
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
        private Boolean validate()
        {
            if(txtSalario.Text != "")
            {
                if(txtRendaExtra.Text != "")
                {
                    MessageBox.Show("Cadastro feito com sucesso!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
                return false;
            }
        }
        private void Ganhos_Load(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }
    }    
}


