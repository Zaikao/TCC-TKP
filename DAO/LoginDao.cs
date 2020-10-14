using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoConclusaoCurso.DAO
{
    class LoginDao
    {
        public bool tem = false;
        public String mensagem = "";
        SqlDataReader dr;
        Conexao Con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public bool verificarLogin (String Login, String senha)
        {
            cmd.CommandText = "select * from cadastro where email = @Login and senha = @senha";
            cmd.Parameters.AddWithValue("@Login", Login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = Con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com banco de dados";
                
            }
            return tem;
        }
        public String cadastrar (String email, String senha, String nome, String idade, String confimarSenha)
        {
            return mensagem;
        }
    }
}
