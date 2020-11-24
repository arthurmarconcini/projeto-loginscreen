using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace loginscreen
{
    public class Comparar
    {
        public bool tem = false;        
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";        
        SqlDataReader dr;
        

        public bool verificarLogin(string nome, string senha)
        {
            cmd.CommandText = "select * from Users where nome = @nome and senha = @senha";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }

            } catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }

            return tem;
        }



    }
}
