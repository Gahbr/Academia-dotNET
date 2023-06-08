using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_WinForms_MiniERP.Model
{
    internal class Fornecedor
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public Fornecedor(int id, string nome)
        {
            Nome = nome;
            ID = id;
        }
        public Fornecedor(string nome)
        {
            Nome = nome;
        }
        public Fornecedor() { }

        public bool GravarFornecedor()
        {
            Database bd = new Database();
            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = cn.CreateCommand();
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO FORNECEDORES" + " VALUES(@NOME);";
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

        public bool EditarFornecedor(int id, string nome)
        {
            Database bd = new();
            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = cn.CreateCommand();
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE FORNECEDORES SET NOME = @Nome WHERE ID = @Id;";

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
            command.CommandText = "DELETE FROM FORNECEDORES WHERE ID = @Id;";
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
