﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginscreen
{
    class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-DEK8RB1\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        }
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }            
        }
    }
}
