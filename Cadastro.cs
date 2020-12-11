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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void lbllogin_Click(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click_1(object sender, EventArgs e)
        {
            txtnome.Text = string.Empty;
            txtidade.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtsenha.Text = string.Empty;
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (!validate())
            {
                
                return;
            }

            var con = "server=localhost;database=tkpoff;uid=root;senha=";
            var connection = new MySqlConnection(con);
            var command = connection.CreateCommand();


            try
            {
                connection.Open();
                command.CommandText = "insert into usuario (nome, dataNascimento, email, senha) values ('" + txtnome.Text + "', '" + txtidade.Text + "', '" + txtemail.Text + "', '" + txtsenha.Text + "'); ";
                command.ExecuteNonQuery();
                
                

                
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
            if (txtemail.Text != "")
            {
                if (txtidade.Text != "")
                {
                    if (txtnome.Text != "")
                    {
                        if (txtsenha.Text != "")
                        {
                            MessageBox.Show("Cadastro feito com sucesso!");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Preencha todos os campos.");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos.");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Preencha todos os campos.");
                return false;
            }
        }
    }
}
