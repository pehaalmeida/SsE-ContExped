using ContExped.Properties;
using SistenaDeSaidaDeEntrega.Data.Sql;
using SistenaDeSaidaDeEntrega.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContExped.Views
{
    public partial class ViewsSetup : Form
    {

        ClassConexao conexao = new ClassConexao();

        public ViewsSetup()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txbFazerConexao_Click(object sender, EventArgs e)
        {
            
            
            Settings.Default["ipServidorDB"] = txbIPServidor.Text;
            Settings.Default["LoginDB"] = txbLoginDB.Text;
            Settings.Default["SenhaDB"] = txbSenhaDB.Text;

            Settings.Default.Save();

            string Cmd = "select * from motorista WHERE ativo = 1";
            SqlDataReader Dados;
            Dados = conexao.ConsultaDb(Cmd);
            while (Dados.Read())
            {
              
                if (Dados["cod_motorista"].ToString() != "")
                {
                    lblStatusBanco.Text = "Online";

                    
                }

                 

               
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string Cmd = "select * from motorista WHERE ativo = 1";
            SqlDataReader Dados;
            Dados = conexao.ConsultaDb(Cmd);
            while (Dados.Read())

            if (Dados["cod_motorista"].ToString() != "")
            {
                Form form = new ViewsLogin();
                form.Show();
                this.Close();

            }else
            {
                    MessageBox.Show("Erro ao se conectar com o BANCO DE DADOS 'IP' ou 'Usuario incorreto'", "SsE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void ViewsSetup_Load(object sender, EventArgs e)
        {
            txbIPServidor.Text = Settings.Default["ipServidorDB"].ToString();
            txbLoginDB.Text = Settings.Default["LoginDB"].ToString();
            txbSenhaDB.Text = Settings.Default["SenhaDB"].ToString();
        }
    }
}
