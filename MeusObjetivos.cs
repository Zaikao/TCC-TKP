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
    public partial class MeusObjetivos : Form
    {
        public MeusObjetivos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Objetivos obj = new Objetivos();
            this.Hide();
            obj.ShowDialog();
        }

        private void MeusObjetivos_Load(object sender, EventArgs e)
        {

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var con = "server=localhost;database=tkpoff;uid=root;senha=";
            var connection = new MySqlConnection(con);
            var command = connection.CreateCommand();

            

            try
            {
                connection.Open();
                String query = "select nomeObjetivo, valor, periodo from objetivos where idUsuario = " + LoginInfo.id;
                command.CommandText = query;
                MySqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    listView1.Items.Add(reader[0] + " -" + reader[1] + " reais" + " -" + reader[2] + " meses" );



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
    }
}
