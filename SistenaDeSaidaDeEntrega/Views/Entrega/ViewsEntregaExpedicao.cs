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
using SistenaDeSaidaDeEntrega.Data.Sql;
using SistenaDeSaidaDeEntrega.Data;

namespace SistenaDeSaidaDeEntrega.Views.Entrega
{
    public partial class ViewsEntregaExpedicao : Form
    {
        ClassConexao conexao = new ClassConexao();

        public ViewsEntregaExpedicao()
        {
            InitializeComponent();
        }

        private void ViewsEntregaExpedicao_Load(object sender, EventArgs e)
        {
            ClassCarregaMotorista.CarregaMotorista(cbMotorista);
            DesativarTxbPesqusia();
            cbPesquisa.SelectedIndex = 0;

            // Configurando o datagridview 
            dgvSaida.ColumnCount = 9;

            dgvSaida.Columns[0].Name = "Data";
            dgvSaida.Columns[1].Name = "Saida";
            dgvSaida.Columns[2].Name = "Pedido";
            dgvSaida.Columns[3].Name = "Cliente";
            dgvSaida.Columns[4].Name = "Receber";
            dgvSaida.Columns[5].Name = "Forma";
            dgvSaida.Columns[6].Name = "Valor";
            dgvSaida.Columns[7].Name = "Pago";
            dgvSaida.Columns[8].Name = "Motorista";

            dgvSaida.Columns[0].Width = 70;
            dgvSaida.Columns[1].Width = 65;
            dgvSaida.Columns[2].Width = 70;
            dgvSaida.Columns[3].Width = 231;
            dgvSaida.Columns[4].Width = 55;
            dgvSaida.Columns[5].Width = 60;
            dgvSaida.Columns[6].Width = 80;
            dgvSaida.Columns[7].Width = 40;
            dgvSaida.Columns[8].Width = 100;

            CarregaDgv("");

        }

        // Carrega os dados e faz o inserte na tabela
        private void CarregaDgv(string Cmd)
        {
            if (Cmd == "" || Cmd == null)
            {
                DateTime thisDay = DateTime.Today;
                string data = thisDay.ToString("d");
                Cmd = "select Convert(varchar(10), s.data,103) as [data], s.cod_saida, s.cod_pedido, s.cliente, s.receber_local, s.forma_pg, s.valor, s.pg, m.nome from saida as s join motorista as m on (s.cod_motorista = m.cod_motorista) WHERE s.data = '" + data + "'";
            }

            // limpando a Tabela
            dgvSaida.Rows.Clear();

            try
            {
                SqlDataReader Dados;
                Dados = conexao.ConsultaDb(Cmd);

                while (Dados.Read())
                {
                    // Criando uma linha
                    DataGridViewRow item = new DataGridViewRow();
                    item.CreateCells(dgvSaida);
                    string receber = Dados["receber_local"].ToString();
                    string pg = Dados["pg"].ToString();
                    string FormaPg = Dados["forma_pg"].ToString();
                    string valor = Dados["valor"].ToString();

                    if (valor != "")
                    {
                        valor = "R$" + Dados["valor"].ToString();
                    } 


                    if (ckbAtivarCor.Checked)
                    {
                        if (pg == "0")
                        {
                            item.DefaultCellStyle.BackColor = Color.Yellow;
                        }
                    }

                    // Tratamento das informações
                    if (receber == "0") { receber = "Não"; }
                    else if (receber == "1"){ receber = "Sim"; }

                    if (pg == "0") { pg = "Não"; }
                    else if (pg == "1") { pg = "Sim"; }

                    if (FormaPg == "0")      { FormaPg = "Cartão"; }
                    else if (FormaPg == "1") { FormaPg = "Dinheiro"; }
                    else if (FormaPg == "2") { FormaPg = "Cheque";}

                    // Inserindo os valores
                    item.Cells[0].Value = Dados["data"].ToString(); ;
                    item.Cells[1].Value = Dados["cod_saida"].ToString();
                    item.Cells[2].Value = Dados["cod_pedido"].ToString();
                    item.Cells[3].Value = Dados["cliente"].ToString();
                    item.Cells[4].Value = receber;
                    item.Cells[5].Value = FormaPg;
                    item.Cells[6].Value = valor;
                    item.Cells[7].Value = pg;
                    item.Cells[8].Value = Dados["nome"].ToString();

                    //Adiciona na Grid
                    dgvSaida.Rows.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no select = " + ex.Message, "Erro");
                return;
            }
        }

        // >>>>>> Botão / ComboBox <<<<<<

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Form form = new ViewsSaidaDados();
            form.Show();
        }

        //Desativa a textBox de Pesquisa
        private void DesativarTxbPesqusia()
        {
            txbPedido.Enabled = false;
            txbCliente.Enabled = false;
            cbMotorista.Enabled = false;
            dtpData.Enabled = false;
            dtpDataInicial.Enabled = false;
        }

        private void cbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbPesquisa.SelectedIndex)
            {
                case 0:
                    DesativarTxbPesqusia();
                    break;

                case 1:
                    DesativarTxbPesqusia();
                    txbPedido.Enabled = true;
                    break;

                case 2:
                    DesativarTxbPesqusia();
                    txbCliente.Enabled = true;
                    break;

                case 3:
                    DesativarTxbPesqusia();
                    cbMotorista.Enabled = true;
                    break;

                case 4:
                    DesativarTxbPesqusia();
                    dtpData.Enabled = true;
                    dtpDataInicial.Enabled = true;
                    break;
                case 5:
                    DesativarTxbPesqusia();
                    break;
            }
        }

        // Marca como pago/nao pago

        private void ViewsEntregaExpedicao_KeyDown(object sender, KeyEventArgs e)
        {
            int LinhaSelecionada = 0;

            if (dgvSaida.SelectedRows.Count == 0)
            {
                return;
            }else
            {
                DataGridViewRow linhaAtual = dgvSaida.CurrentRow;
                LinhaSelecionada = linhaAtual.Index;
            }

            string Pg = "";
            switch (e.KeyCode)
            {
                case Keys.F5 :
                    Pg = dgvSaida.Rows[LinhaSelecionada].Cells[7].Value.ToString();
                    if (Pg == "Não")
                    {
                            if (MessageBox.Show("Deseja confirma o pagamento ?", "SsE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                 string cod_saida = dgvSaida.Rows[LinhaSelecionada].Cells[1].Value.ToString();

                                 conexao.ComandoDb("UPDATE saida SET pg = 1 WHERE cod_saida = " + cod_saida, false, "");

                                CarregaDgv("");
                                }
                    }
                    break;

                case Keys.F6:
                    Pg = dgvSaida.Rows[LinhaSelecionada].Cells[7].Value.ToString();
                    if (Pg == "Sim")
                    {
                        if (MessageBox.Show("Deseja remover o pagamento ?", "SsE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string cod_saida = dgvSaida.Rows[LinhaSelecionada].Cells[1].Value.ToString();

                            conexao.ComandoDb("UPDATE saida SET pg = 0 WHERE cod_saida = " + cod_saida, false, "");

                            CarregaDgv("");
                        }
                    }
                    break;
                case Keys.Enter:
                    Filtrar();
                    break;
                case Keys.Delete:
                        DeletarLinha();
                    break;
            }
        }

        private void ckbAtivarCor_CheckedChanged(object sender, EventArgs e)
        {
            CarregaDgv("");
        }

        // Filtro de pesquisa

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void Filtrar()
        {
            string cmdSql = "";
            bool Filtrar = false;

            switch (cbPesquisa.SelectedIndex)
            {
                case 0:
                    
                    break;

                case 1:

                    if (txbPedido.Text != "" || txbPedido.Text != null)
                    {
                        string texto = txbPedido.Text;
                        if (txbPedido.Text == "" || txbPedido.Text == null) { texto = "0"; }
                        Filtrar = true;
                        cmdSql = "WHERE s.cod_pedido = " + texto;

                    }
                    break;

                case 2:

                    if (txbCliente.Text != "" || txbCliente.Text != null)
                    {
                        string texto = txbCliente.Text;
                        Filtrar = true;
                        cmdSql = "WHERE s.cliente LIKE '%" + texto + "%' ";

                    }
                    break;

                case 3:

                    if (cbMotorista.Text != "" || cbMotorista.Text != null)
                    {
                        string texto = cbMotorista.Text;
                        if (cbMotorista.SelectedIndex == 0)
                        {
                            texto = "";
                        }
                        Filtrar = true;
                        cmdSql = "WHERE m.nome LIKE '%" + texto + "%' ";

                    }
                    break;

                case 4:

                    if (dtpData.Text != "" || dtpData.Text != null)
                    {
                        string texto = dtpData.Text;
                        Filtrar = true;
                        cmdSql = "WHERE s.data = '" + texto + "'";

                    }
                    break;
                case 5:

                    Filtrar = true;
                    cmdSql = "where data between '"+ dtpDataInicial.Text +"' and '" + dtpData.Text + "';";

                    break;
                case 6:

                    Filtrar = true;
                    cmdSql = "";

                    break;
            }

            if (Filtrar == true)
            {
                CarregaDgv("select Convert(varchar(10), s.data,103) as [data], s.cod_saida, s.cod_pedido, s.cliente, s.receber_local, s.forma_pg, s.valor, s.pg, m.nome from saida as s join motorista as m on (s.cod_motorista = m.cod_motorista)" + cmdSql);
            }
        }

        private void txbPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassTestes.ApenasNumero(e);
        }

        private void timerCmd_Tick(object sender, EventArgs e)
        {
            if (ClassGlobal.RestarteTabela == true)
            {
                CarregaDgv("");
                ClassGlobal.RestarteTabela = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
       
                DeletarLinha();
   
              
        }

        private void DeletarLinha() 
        {
            int LinhaSelecionada = 0;

            if (dgvSaida.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                DataGridViewRow linhaAtual = dgvSaida.CurrentRow;
                LinhaSelecionada = linhaAtual.Index;
            }

            if (MessageBox.Show("Deseja realmente excluir ?", "SsE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string numeroPedido = dgvSaida.Rows[LinhaSelecionada].Cells[1].Value.ToString();
                conexao.ComandoDb("DELETE FROM saida WHERE cod_saida = " + numeroPedido, false, "");

                CarregaDgv("");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = 0;

            if (dgvSaida.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                DataGridViewRow linhaAtual = dgvSaida.CurrentRow;
                LinhaSelecionada = linhaAtual.Index;
            }

            ClassGlobal.LinhaAtual = dgvSaida.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            ClassGlobal.Editar = true;
            Form form = new ViewsSaidaDados();
            form.Show();

        }

        private void txbPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSaida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
