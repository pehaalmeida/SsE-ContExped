using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistenaDeSaidaDeEntrega.Views.Usuário
{
    public partial class ViewsUsuario : Form
    {
        public ViewsUsuario()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Form form = new ViewsUsuarioDados();
            form.Show();
        }
    }
}
