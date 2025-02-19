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

namespace SistenaDeSaidaDeEntrega.Views.Motorista
{
    public partial class ViewsMotorista : Form
    {

        ClassConexao conexao = new ClassConexao();

        bool StatusAtivo = true;

        public ViewsMotorista()
        {
            InitializeComponent();
        }

        private void ViewsMotorista_Load(object sender, EventArgs e)
        {
            dgvMotorista.ColumnCount = 2;

            dgvMotorista.Columns[0].Name = "Codigo";
            dgvMotorista.Columns[1].Name = "Nome";

            dgvMotorista.Columns[0].Width = 70;
            dgvMotorista.Columns[1].Width = 250;

            CarregaDgvMotorista("");

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Form form = new ViewsMotoristaDados();
            form.Show();
        }

        public void CarregaDgvMotorista(string Cmd)
        {
            if (Cmd == "" || Cmd == null)
            {
                Cmd = "select * from motorista WHERE ativo = 1";
            }

            // limpando a Tabela
            dgvMotorista.Rows.Clear();

            try
            {
                SqlDataReader Dados;
                Dados = conexao.ConsultaDb(Cmd);
                while (Dados.Read())
                {
                    // Criando uma linha
                    DataGridViewRow item = new DataGridViewRow();
                    item.CreateCells(dgvMotorista);

                    // Inserindo os valores
                    item.Cells[0].Value = Dados["cod_motorista"].ToString(); ;
                    item.Cells[1].Value = Dados["nome"].ToString(); ;

                    //Adiciona na Grid
                    dgvMotorista.Rows.Add(item);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Filtrar()
        {
            string cmdSql = "";
            

            if (txbNomePesquisa.Text != "" || txbNomePesquisa.Text != null)
            {
               

                string texto = txbNomePesquisa.Text;
                cmdSql = "WHERE nome LIKE '%" + texto + "%' ";

                if (cbAtivo.Checked)
                {
                    cmdSql = cmdSql + "AND ativo = 1";
                }else
                {
                    cmdSql = cmdSql + "AND ativo = 0";
                }
                CarregaDgvMotorista("select * From motorista " + cmdSql);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void timeCmdDgV_Tick(object sender, EventArgs e)
        {
            if (ClassGlobal.RestarteTabelaMotorista == true)
            {
                CarregaDgvMotorista("");
                ClassGlobal.RestarteTabelaMotorista = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = 0;

            if (dgvMotorista.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                DataGridViewRow linhaAtual = dgvMotorista.CurrentRow;
                LinhaSelecionada = linhaAtual.Index;
            }

            ClassGlobal.LinhaAtual = dgvMotorista.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            ClassGlobal.EditarMotorista = true;
            Form form = new ViewsMotoristaDados();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AlteraStatus();
        }

        private void AlteraStatus()
        {

            string status = "";
            string msgPergunta = "";
            string msgFinal = "";

            if (StatusAtivo == true) 
            {
                status = "0";
                msgPergunta = "Deseja realmente desabilitar ?";
                msgFinal = "Motorista desabilitado com sucesso!";

            }
            else if (StatusAtivo == false)
            {
                status = "1";
                msgPergunta = "Deseja realmente desabilitar ?";
                msgFinal = "Motorista desabilitado com sucesso!";
            }

            int LinhaSelecionada = 0;

            if (dgvMotorista.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                DataGridViewRow linhaAtual = dgvMotorista.CurrentRow;
                LinhaSelecionada = linhaAtual.Index;
            }

            if (MessageBox.Show(msgPergunta, "SsE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string numeroPedido = dgvMotorista.Rows[LinhaSelecionada].Cells[0].Value.ToString();
                conexao.ComandoDb("UPDATE motorista SET ativo = " + status + " WHERE cod_motorista = " + numeroPedido, false, "");

                cbAtivo.Checked = true;

                CarregaDgvMotorista("");

                MessageBox.Show(msgFinal, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void cbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();

            if (cbAtivo.Checked)
            {

                btnDesativar.Visible = true;
                btnHabilitar.Visible = false;
                StatusAtivo = true;



            }
            else
            {

                btnDesativar.Visible = false;
                btnHabilitar.Visible = true;
                StatusAtivo = false;

            }


        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            AlteraStatus();
        }
    }
}
