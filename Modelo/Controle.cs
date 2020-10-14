using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoConclusaoCurso.DAO;

namespace TrabalhoConclusaoCurso.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar (String login, String senha)
        {
            LoginDao loginComando = new LoginDao();
            tem = loginComando.verificarLogin(login, senha);
            if (!loginComando.mensagem.Equals(""))
            {
                this.mensagem = loginComando.mensagem;
            }
            return tem;
        }
        public String cadastrar (String email, String senha, String nome, String idade, String confimarSenha)
        {
            return mensagem;
        }
    }
}
