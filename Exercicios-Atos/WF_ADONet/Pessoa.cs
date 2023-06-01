using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_ADONet
{
    internal class Pessoa
    {
        public int id;
        public string nome;
        public string profissao;

        public bool GravarPessoa()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = cn.CreateCommand();
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO PESSOAS" + " VALUES(@NOME, @PROFISSAO);";

            command.Parameters.Add("@NOME", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@PROFISSAO", System.Data.SqlDbType.VarChar);

            command.Parameters[0].Value = nome;
            command.Parameters[1].Value = profissao;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            } catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.FecharConexao();
            }
        }

        public bool EditarPessoa(string nome, string profissao, int id)
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = cn.CreateCommand();
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE PESSOAS SET NOME = @Nome, PROFISSAO = @Profissao WHERE ID = @Id;";

            command.Parameters.AddWithValue("@Nome", nome);
            command.Parameters.AddWithValue("@Profissao", profissao);
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
            Banco bd = new Banco();
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
