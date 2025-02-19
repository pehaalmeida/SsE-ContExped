using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistenaDeSaidaDeEntrega.Data.Sql
{
    class ClassConexao
    {

        private SqlConnection ConectSql()
        {
            SqlConnection sqlCon = new SqlConnection(ClassCredencialDB.DadosConexao());
            sqlCon.Open();

            return sqlCon;
        }

        public SqlDataReader ConsultaDb(string Commands)
        {
            try
            {
                SqlDataReader dtDados;
                SqlConnection Conect = ConectSql();

                SqlCommand comando = new SqlCommand(Commands, Conect);

                dtDados = comando.ExecuteReader();


                
                return dtDados;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Sql: " + ex.Message, "Erro | " + ClassCredencialDB.NomeProjeto);
                throw;
            }

        }

        public void ComandoDb(String Commands, bool MessStatus, string Message)
        {
            try
            {
                SqlConnection Conect = ConectSql();
                SqlCommand insert = new SqlCommand(Commands, Conect);
                insert.ExecuteNonQuery();

                if (MessStatus == true)
                {
                    MessageBox.Show(Message, "Mensagem | " + ClassCredencialDB.NomeProjeto);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Sql: " + ex.Message, "Erro | " + ClassCredencialDB.NomeProjeto);
            }

        }

    }
}
