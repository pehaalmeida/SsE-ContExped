using SistenaDeSaidaDeEntrega.Data.Sql;
using SistenaDeSaidaDeEntrega.Views.Entrega;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistenaDeSaidaDeEntrega.Data
{
    class ClassCarregaMotorista
    {
        
        public static void CarregaMotorista(ComboBox cbmotorista)
        {
            ClassConexao conexao = new ClassConexao();

            SqlDataReader Dados;
            Dados = conexao.ConsultaDb("select * from motorista WHERE ativo = 1");

            while (Dados.Read())
            {
                cbmotorista.Items.Add(Dados["nome"].ToString());
            }
            cbmotorista.SelectedIndex = 0;

        }
    }
}
