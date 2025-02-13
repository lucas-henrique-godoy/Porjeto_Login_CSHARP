using ProjetoLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo
{
    public class Controle // Controla a comunicação entre as classes e se comunica com a classe LoginDaoComandos
    {
        public Boolean tem;
        public String mensagem = "";
        public Boolean Acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if(!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String Cadastrar(String email, String senha, String confSenha)
        {
            return mensagem;
        }
    }
}
