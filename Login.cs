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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtemail.Text = string.Empty;
            txtsenha.Text = string.Empty;
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var con = "server=localhost;database=tkpoff;uid=root;senha=";
            var connection = new MySqlConnection(con);
            var command = connection.CreateCommand();



            try
            {
                connection.Open();
                String query = "select id, email, senha from usuario where email = '" + txtemail.Text + "' and senha = '" + txtsenha.Text + "';";
                command.CommandText = query;
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    LoginInfo.id = (int)reader[0];
                    LoginInfo.email = (string)reader[1];
                }  
                if(LoginInfo.id > 0)
                {

                    btnlimpar_Click(sender, e);
                     

                    TelaPrincipal tp = new TelaPrincipal();
                    this.Hide();
                    tp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login ou senha errados.");
                }
            }
            finally
            {
                
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }   
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblAqui_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            this.Hide();
            cadastro.ShowDialog();
        }
    }
}
