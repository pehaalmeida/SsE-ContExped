using SistenaDeSaidaDeEntrega.Data;
using SistenaDeSaidaDeEntrega.Data.Sql;
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

namespace SistenaDeSaidaDeEntrega.Views.Motorista
{
    public partial class ViewsMotoristaDados : Form
    {

        ClassConexao conexao = new ClassConexao();
        ClassTestes Testa = new ClassTestes();

        public ViewsMotoristaDados()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            if (Testa.Testacampos(txbMotorista.Text, "Nome Do Motorista ") != false) 
            {

                string NomeMotorista = txbMotorista.Text;
                int StatusAtivo = 0;
                if (cbAtivo.Checked)
                {
                    StatusAtivo = 1;
                }

                conexao.ComandoDb("INSERT INTO motorista (nome, ativo) VALUES ('" + NomeMotorista + "', " + StatusAtivo + ")", false, "");

                MessageBox.Show("Motorista Cadastrado com sucesso!", "SsE | Cadastro Motorista", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClassGlobal.RestarteTabelaMotorista = true;

            };
        }

        private void ViewsMotoristaDados_Load(object sender, EventArgs e)
        {
            if (ClassGlobal.EditarMotorista == true)
            {
                consultaEdicao();
                btnConfirmar.Visible = false;
                btnConfirmarEdit.Visible = true;
            }


        }

        private void consultaEdicao()
        {
            SqlDataReader Dados;
           Dados = conexao.ConsultaDb("select * from motorista where cod_motorista = " + ClassGlobal.LinhaAtual);

           while (Dados.Read())
           {
             txbMotorista.Text = Dados["nome"].ToString();
             if (Dados["ativo"].ToString() == "1")
              {
                cbAtivo.Checked = true;
              }
                
           }

          

            ClassGlobal.EditarMotorista = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarEdit_Click(object sender, EventArgs e)
        {

            if (Testa.Testacampos(txbMotorista.Text, "Nome Do Motorista ") != false)
            {

                string NomeMotorista = txbMotorista.Text;
                int StatusAtivo = 0;
                if (cbAtivo.Checked)
                {
                    StatusAtivo = 1;
                }

                conexao.ComandoDb("UPDATE motorista SET nome = '" + NomeMotorista + "', ativo cod_motorista = " + StatusAtivo + "Where cod_motorista = " + ClassGlobal.LinhaAtual, false, "");

                MessageBox.Show("Cadastrado editado com sucesso!", "SsE | Cadastro Motorista", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClassGlobal.RestarteTabelaMotorista = true;

            };

        }
    }
}
