using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistenaDeSaidaDeEntrega.Views
{
    public partial class ViewsLogin : Form
    {
        public ViewsLogin()
        {
            InitializeComponent();
        }

        private void ViewsLogin_Load(object sender, EventArgs e)
        {
            int w = this.Width / 2;
            int h = this.Height / 2;

            int wp = plLogin.Size.Width / 2;
            int hp = plLogin.Size.Height / 2;

            plLogin.Location = new Point(w - wp, h - hp);

        }

        private void ViewsLogin_SizeChanged(object sender, EventArgs e)
        {
            int w = this.Width / 2;
            int h = this.Height / 2;

            int wp = plLogin.Size.Width / 2;
            int hp = plLogin.Size.Height / 2;

            plLogin.Location = new Point(w - wp, h - hp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbLogin.Text = "";
            txbSenha.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form form = new ViewsHome();
            form.Show();

            
        }


    }
}
