using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginscreen
{
    public class Cadastrar
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public Cadastrar(String nome, String senha, String email)
        {
            cmd.CommandText = "insert into Users (nome, senha, email) VALUES (@nome, @senha, @email)";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@email", email);

            try
            {
                cmd.Connection = conexao.conectar();

                cmd.ExecuteNonQuery();

                conexao.desconectar();

                this.mensagem = "Cadastrado com sucesso!";
            } catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados";
            }
        }

    }
}
