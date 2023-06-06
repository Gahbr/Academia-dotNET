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
        public int ID {get;set;}
        public string Nome { get;set;}

        public Cliente(int id, string nome){
            Nome = nome;
            ID = id;
        }
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

        public bool EditarCliente(int id, string nome)
        {
            Database bd = new();
            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = cn.CreateCommand();
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE CLIENTES SET NOME = @Nome WHERE ID = @Id;";

            command.Parameters.AddWithValue("@Nome", nome);
            command.Parameters.AddWithValue("@Id", id.ToString());

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

        public bool DeletarPessoa(int id)
        {
            Database bd = new();
            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = cn.CreateCommand();
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM PESSOAS WHERE ID = @Id;";
            command.Parameters.AddWithValue("@Id", id.ToString());

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
