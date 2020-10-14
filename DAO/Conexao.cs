using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoConclusaoCurso.DAO
{
    public class Conexao
    {
        SqlConnection Con = new SqlConnection();
        public Conexao()
        {
            Con.ConnectionString = @"";
        }
        public SqlConnection Conectar()
        {
            if(Con.State == System.Data.ConnectionState.Closed)
            {
                Con.Open();
            }

        }
        public void desconectar()
        {
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
            }
        }
    }
}
