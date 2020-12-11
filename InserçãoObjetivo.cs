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
    public partial class InserçãoObjetivo : Form
    {
        public InserçãoObjetivo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Objetivos obj = new Objetivos();
            this.Hide();
            obj.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtnomeO.Text = string.Empty;
            txtPeriodoO.Text = string.Empty;
            txtValorO.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
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
                command.CommandText = "insert into objetivos (idUsuario, nomeObjetivo, valor, periodo, dataCadastro) values (" + LoginInfo.id + ", '" + txtnomeO.Text + "', " + Double.Parse(txtValorO.Text) + "," + int.Parse(txtPeriodoO.Text) + ", now());";
                
                command.ExecuteNonQuery();


                MessageBox.Show("Cadastro feito com sucesso!");
                
                btnLimpar_Click(sender, e);
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
            MessageBox.Show("Novo objetivo foi salvo com sucesso!");
        }
        private Boolean validate ()
        {
            if(txtnomeO.Text != "")
            {
                if(txtnomeO.Text != "")
                {
                    if(txtPeriodoO.Text != "")
                    {
                        
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

        private void InserçãoObjetivo_Load(object sender, EventArgs e)
        {

        }

        private void txtnomeO_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
