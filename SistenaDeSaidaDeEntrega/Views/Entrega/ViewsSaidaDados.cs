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
using SistenaDeSaidaDeEntrega.Data;
using SistenaDeSaidaDeEntrega.Data.Sql;

namespace SistenaDeSaidaDeEntrega.Views.Entrega
{
    public partial class ViewsSaidaDados : Form
    {
        ClassConexao conexao = new ClassConexao();

        public ViewsSaidaDados()
        {
            InitializeComponent();
        }

        private void ViewsSaidaDados_Load(object sender, EventArgs e)
        {
           
           ClassCarregaMotorista.CarregaMotorista(cbMotorista);
           cbFormaPg.SelectedIndex = 0;

            if (ClassGlobal.Editar == true) 
            {
                consultaEdicao();
                btnConfirmar.Visible = false;
                btnConfirmarEdit.Visible = true;
            }

        }

        private void cbReceberLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (chReceberLocal.Checked)
            {
                txbValor.Enabled = true;
                cbFormaPg.Enabled = true;
                chPago.Enabled = true;
            }else
            {
                txbValor.Enabled = false;
                cbFormaPg.Enabled = false;
                chPago.Enabled = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {


                DateTime thisDay = DateTime.Today;
                SqlDataReader Dados;

                    if (TestaCampos() == true)
                    {

                        string CodPedido = txbPedido.Text;
                        string NomeCliente = txbCliente.Text;
                        string Motorista = "";
                        Dados = conexao.ConsultaDb("select cod_motorista from motorista WHERE nome LIKE '%" + cbMotorista.Text + "%'");
                        while (Dados.Read()) { Motorista = Dados["cod_motorista"].ToString(); };
                        string data = thisDay.ToString("dd-MM-yyyy");
                        string ReceberLocal = "";
                        string valor = "";
                        string formaPg = "null";
                        string pg = "null";
                        string obs = txbObs.Text;
                        if (chReceberLocal.Checked)
                        {
                            ReceberLocal = "1";
                            valor = txbValor.Text;
                            switch (cbFormaPg.SelectedIndex)
                            {
                                case 0:
                                    formaPg = "0";
                                    break;
                                case 1:
                                    formaPg = "1";
                                    break;
                                case 2:
                                    formaPg = "2";
                                    break;
                            }
                            if (chPago.Checked) { pg = "1"; } else { pg = "0"; };
                        }
                        else { ReceberLocal = "0"; }

                        conexao.ComandoDb("INSERT INTO saida (cod_pedido, cliente, data, cod_motorista, receber_local, valor, forma_pg, pg, obs) VALUES (" + CodPedido + ", '" + NomeCliente + "', '" + data + "', " + Motorista + ", " + ReceberLocal + ", '" + valor + "', " + formaPg + ", " + pg + ",'" + obs + "')", false, "");
                        
                        

                        ClassGlobal.RestarteTabela = true;

                    MessageBox.Show("Saida cadastrada com sucesso!","Aviso SsE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpaCampo();

                    }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Sistema = " + ex.Message, "");
                throw;
            }
            
        }

        private void LimpaCampo()
        {
            txbPedido.Text = "";
            txbCliente.Text = "";
            cbMotorista.SelectedIndex = 0;
            chReceberLocal.Checked = false;
            txbValor.Text = "";
            cbFormaPg.SelectedIndex = 0;
            chPago.Checked = false;
            txbObs.Text = "";
        }

        private bool TestaCampos()
        {
            ClassTestes Testa = new ClassTestes();

            if (Testa.Testacampos(txbPedido.Text, "Pedido ") == false) { return false; };
            if (Testa.Testacampos(txbCliente.Text, "Nome de Cliente ") == false) { return false; };
            if(Testa.TestaComboBox(cbMotorista, "Motorista ") == false) { return false; };
            if (chReceberLocal.Checked)
            {
                if (Testa.Testacampos(txbValor.Text, "Valor ") == false) { return false; };
                if (Testa.TestaComboBox(cbFormaPg, "Um Tipo de Pagamento ") == false) { return false; };
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }

        private void btnConfirmarEdit_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Deseja realmente salvar ?", "SsE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                try
                {
                    DateTime thisDay = DateTime.Today;
                    SqlDataReader Dados;

                    if (TestaCampos() == true)
                    {

                        string CodNum = txbCodSaida.Text;
                        string CodPedido = txbPedido.Text;
                        string NomeCliente = txbCliente.Text;
                        string Motorista = "";
                        Dados = conexao.ConsultaDb("select cod_motorista from motorista WHERE nome LIKE '%" + cbMotorista.Text + "%'");
                        while (Dados.Read()) { Motorista = Dados["cod_motorista"].ToString(); };
                        string data = thisDay.ToString("dd-MM-yyyy");
                        string ReceberLocal = "null";
                        string valor = "0";
                        string formaPg = "null";
                        string pg = "null";
                        string obs = txbObs.Text;


                        if (chReceberLocal.Checked)
                        {
                            ReceberLocal = "1";
                            valor = txbValor.Text;
                            switch (cbFormaPg.SelectedIndex)
                            {
                                case 0:
                                    formaPg = "0";
                                    break;
                                case 1:
                                    formaPg = "1";
                                    break;
                                case 2:
                                    formaPg = "2";
                                    break;
                            }
                            if (chPago.Checked) { pg = "1"; } else { pg = "0"; };
                        }
                        else 
                        {
                            ReceberLocal = "0";
                            valor = "0";
                            switch (cbFormaPg.SelectedIndex)
                            {
                                case 0:
                                    formaPg = "0";
                                    break;
                                case 1:
                                    formaPg = "1";
                                    break;
                                case 2:
                                    formaPg = "2";
                                    break;
                            }
                            if (chPago.Checked) { pg = "1"; } else { pg = "0"; };
                        }

                        conexao.ComandoDb("UPDATE saida SET cod_pedido = " + CodPedido + ", cliente = '" + NomeCliente + "', data = '" + data + "', cod_motorista = " + Motorista + ", receber_local = " + ReceberLocal + ", valor = '" + valor + "', forma_pg = " + formaPg + ", pg = " + pg + ", obs = '" + obs + "' WHERE cod_saida = " + CodNum, false, "");

                        ClassGlobal.RestarteTabela = true;

                        MessageBox.Show("Alteração Feita com sucesso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no Sistema = " + ex.Message, "");
                    throw;
                }

            }
            else
            {
                this.Close();
            }
        }

        private void consultaEdicao()
        {
            SqlDataReader Dados;
            Dados = conexao.ConsultaDb("select Convert(varchar(10), s.data,103) as [data], s.cod_saida, s.cod_pedido, s.cliente, s.receber_local, s.forma_pg, s.valor, s.pg, obs, m.nome from saida as s join motorista as m on (s.cod_motorista = m.cod_motorista) WHERE s.cod_saida = " + ClassGlobal.LinhaAtual );

            while (Dados.Read())
            {
                txbCodSaida.Text = Dados["cod_saida"].ToString();
                txbPedido.Text = Dados["cod_pedido"].ToString();
                txbCliente.Text = Dados["cliente"].ToString();
                cbMotorista.Text = Dados["nome"].ToString();
                if (Dados["receber_local"].ToString() == "0") { chReceberLocal.Checked = false; } else { chReceberLocal.Checked = true; }
                txbValor.Text = Dados["valor"].ToString();
                if (Dados["forma_pg"].ToString() == "0") { cbFormaPg.SelectedIndex = 0; }else if (Dados["forma_pg"].ToString() == "1") { cbFormaPg.SelectedIndex = 1; } else if (Dados["forma_pg"].ToString() == "2") { cbFormaPg.SelectedIndex = 2; }
                if (Dados["pg"].ToString() == "0") { chPago.Checked = false; } else { chPago.Checked = true; }
                txbObs.Text = Dados["obs"].ToString();
            }

            ClassGlobal.Editar = false;
        }

        private void txbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassTestes.ApNumeroComVirgula(sender, e, ',');

        }

        private void txbValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassTestes.ApenasNumero(e);
        }
    }
}
