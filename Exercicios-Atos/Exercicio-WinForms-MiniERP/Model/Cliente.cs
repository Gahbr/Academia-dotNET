using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_WinForms_MiniERP.Model
{
    internal class Cliente
    {
        private int ID {get;set;}
        private string Nome { get;set;}

        public Cliente(){}
        public Cliente(string nome)
        {
            Nome = nome;
        }

        public bool GravarCliente()
        {
            Database bd = new Database();
            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = cn.CreateCommand();
                       command.Transaction = tran;
                       command.CommandType = CommandType.Text;
                       command.CommandText = "INSERT INTO CLIENTES" + " VALUES(@NOME);";
                       command.Parameters.Add("@NOME", SqlDbType.VarChar);
                       command.Parameters[0].Value = Nome;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.FecharConexao();
            }
        }
    }
}
