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
    public partial class ViewsLoad : Form
    {

        ClassConexao conexao = new ClassConexao();
        public ViewsLoad()
        {
            InitializeComponent();
            ProgressBar.Maximum = 1000;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void ViewsLoad_Load(object sender, EventArgs e)
        {


           

            for (int i = 0; i <= 1000; i++)
            {
                ProgressBar.Value = i;
                
            }

            if (ProgressBar.Value == 1000)
            {
                btnStart.Visible = true;

            }

            


            

        }

        private void Inicio()
        {
            string IPSERVIDOR = Settings.Default["ipServidorDB"].ToString();


            if (IPSERVIDOR == "" || IPSERVIDOR == null)
            {

                if (MessageBox.Show("Algumas configuração não foi feita, Faça as configurração para iniciar o Sistema", "SsE", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Form form = new ViewsSetup();
                    form.Show();
                    this.Hide();
                }

               


            }
            else
            {
                
                    if (MessageBox.Show("Pronto, Sistema Carregado Com sucesso, Seja bem vindo novamente", "SsE", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Form form = new ViewsLogin();
                        form.Show();
                        this.Hide();
                    }

                


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Inicio();
        }
    }
}
