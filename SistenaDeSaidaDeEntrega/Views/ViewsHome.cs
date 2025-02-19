using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContExped.Views;
using SistenaDeSaidaDeEntrega.Views.Entrega;
using SistenaDeSaidaDeEntrega.Views.Motorista;
using SistenaDeSaidaDeEntrega.Views.Usuário;

namespace SistenaDeSaidaDeEntrega.Views
{
    public partial class ViewsHome : Form
    {
        public ViewsHome()
        {
            InitializeComponent();
        } 
        
        private void ViewsHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MsHomeNaRua_Click(object sender, EventArgs e)
        {
            Form form = new ViewsSaidaEntrega();
            form.Show();


        }

        private void MsHomeNovaEntrega_Click(object sender, EventArgs e)
        {
           
        }

        private void MsHomeCadastroMotorista_Click(object sender, EventArgs e)
        {
            Form form = new ViewsMotorista();
            form.Show();
        }

        private void MsHomeCadastroUsuario_Click(object sender, EventArgs e)
        {
            Form form = new ViewsUsuario();
            form.Show();
        }

        private void ViewsHome_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MsHomeNovaEntrega_Click_1(object sender, EventArgs e)
        {
            Form form = new ViewsEntregaExpedicao();
            form.Show();

           
        }

        private void MsHome_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
 
        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new ViewsSetup();
            form.Show();
        }

  
    }
}
