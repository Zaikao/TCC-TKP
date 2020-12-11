using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            var con = "server=localhost;database=tkpoff;uid=root;senha=";
            var connection = new MySqlConnection(con);
            var command = connection.CreateCommand();

            try
            {
             //   connection.Open();
             //   command.CommandText = "insert into usuario (nome, dataNascimento, email, senha) values ('Joao', '1997-10-231', 'joaoluis@uol.com.br', 'curry30'); ";
            //    command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);


            }


            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            menu menu = new menu();
            this.Hide();
            menu.ShowDialog();

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
