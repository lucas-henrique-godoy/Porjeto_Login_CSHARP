using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.DAL
{
    class LoginDaoComandos
    {
        public Boolean tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
       
        public Boolean verificarLogin(String login, String senha)
        {
            //Procurar no banco esse login e senha
            cmd.CommandText = "select * from nomeDaTabela where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com Banco de Dados!";
            }
            return tem;
        }

        public String Cadastrar(String email, String senha, String confSenha)
        {
            //comandos para inserir
            return mensagem;
        }
    }
}
