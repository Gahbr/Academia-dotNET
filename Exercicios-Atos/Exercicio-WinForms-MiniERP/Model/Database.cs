using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Exercicio_WinForms_MiniERP.Model
{
    internal class Database
    {
        public string stringConexao = "Data Source=localhost;" + "Initial Catalog=MINIERP;User ID=atos;password=senha123;language=Portuguese;";

        private SqlConnection cn;
        private void Conexao()
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection AbrirConexao()
        {
            try
            {
                Conexao();
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void FecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExecutarConsultaGenerica(string sql)
        {
            try
            {
                AbrirConexao();
                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery(); //executa o comando
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();// Tabela em memória
                adapter.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
