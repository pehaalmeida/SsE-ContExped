namespace SistenaDeSaidaDeEntrega.Views.Entrega
{
    partial class ViewsEntregaExpedicao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbPesquisa = new System.Windows.Forms.ComboBox();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMotorista = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dgvSaida = new System.Windows.Forms.DataGridView();
            this.ckbAtivarCor = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txbPedido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timerCmd = new System.Windows.Forms.Timer(this.components);
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPesquisa
            // 
            this.cbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbPesquisa.FormattingEnabled = true;
            this.cbPesquisa.Items.AddRange(new object[] {
            "Todos do Dia",
            "Pedido",
            "Nome Cliente",
            "Motorista",
            "Período",
            "Todos Cadastros"});
            this.cbPesquisa.Location = new System.Drawing.Point(15, 25);
            this.cbPesquisa.Name = "cbPesquisa";
            this.cbPesquisa.Size = new System.Drawing.Size(115, 21);
            this.cbPesquisa.TabIndex = 0;
            this.cbPesquisa.SelectedIndexChanged += new System.EventHandler(this.cbPesquisa_SelectedIndexChanged);
            // 
            // txbCliente
            // 
            this.txbCliente.Location = new System.Drawing.Point(136, 74);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(320, 20);
            this.txbCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pesquisar por";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número Pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Motorista";
            // 
            // cbMotorista
            // 
            this.cbMotorista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotorista.FormattingEnabled = true;
            this.cbMotorista.Items.AddRange(new object[] {
            "Todos"});
            this.cbMotorista.Location = new System.Drawing.Point(462, 73);
            this.cbMotorista.Name = "cbMotorista";
            this.cbMotorista.Size = new System.Drawing.Size(134, 21);
            this.cbMotorista.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(716, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data Final";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(719, 74);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(111, 20);
            this.dtpData.TabIndex = 0;
            // 
            // dgvSaida
            // 
            this.dgvSaida.AllowUserToAddRows = false;
            this.dgvSaida.AllowUserToDeleteRows = false;
            this.dgvSaida.AllowUserToResizeColumns = false;
            this.dgvSaida.AllowUserToResizeRows = false;
            this.dgvSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaida.Location = new System.Drawing.Point(15, 105);
            this.dgvSaida.MultiSelect = false;
            this.dgvSaida.Name = "dgvSaida";
            this.dgvSaida.ReadOnly = true;
            this.dgvSaida.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSaida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaida.Size = new System.Drawing.Size(815, 400);
            this.dgvSaida.TabIndex = 15;
            this.dgvSaida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaida_CellContentClick);
            // 
            // ckbAtivarCor
            // 
            this.ckbAtivarCor.AutoSize = true;
            this.ckbAtivarCor.Checked = true;
            this.ckbAtivarCor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAtivarCor.Location = new System.Drawing.Point(666, 511);
            this.ckbAtivarCor.Name = "ckbAtivarCor";
            this.ckbAtivarCor.Size = new System.Drawing.Size(75, 17);
            this.ckbAtivarCor.TabIndex = 16;
            this.ckbAtivarCor.Text = "Ativar Cor.";
            this.ckbAtivarCor.UseVisualStyleBackColor = true;
            this.ckbAtivarCor.CheckedChanged += new System.EventHandler(this.ckbAtivarCor_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(771, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "- Não Pago";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(748, 511);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 17);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::ContExped.Properties.Resources.ImgDeletarItem16x;
            this.btnExcluir.Location = new System.Drawing.Point(719, 9);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(111, 41);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "  Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Image = global::ContExped.Properties.Resources.ImgEditor32x;
            this.btnAlterar.Location = new System.Drawing.Point(602, 9);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(111, 41);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "  Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.Control;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Image = global::ContExped.Properties.Resources.ImgNovo32x;
            this.btnInserir.Location = new System.Drawing.Point(485, 9);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(111, 41);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "  Inserir";
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Image = global::ContExped.Properties.Resources.ImgConsulta;
            this.btnFiltrar.Location = new System.Drawing.Point(368, 9);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(111, 41);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "  Filtrar";
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txbPedido
            // 
            this.txbPedido.Location = new System.Drawing.Point(15, 74);
            this.txbPedido.Name = "txbPedido";
            this.txbPedido.Size = new System.Drawing.Size(115, 20);
            this.txbPedido.TabIndex = 0;
            this.txbPedido.TextChanged += new System.EventHandler(this.txbPedido_TextChanged);
            this.txbPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPedido_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(407, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Aperte \"F5\" Para Marcar Como Pago         Aperte \"F6\" Para Marcar Como Não Pago";
            // 
            // timerCmd
            // 
            this.timerCmd.Enabled = true;
            this.timerCmd.Interval = 1000;
            this.timerCmd.Tick += new System.EventHandler(this.timerCmd_Tick);
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Enabled = false;
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(602, 74);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(113, 20);
            this.dtpDataInicial.TabIndex = 37;
            this.dtpDataInicial.Value = new System.DateTime(2022, 1, 1, 19, 56, 35, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(599, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Data Inicial";
            // 
            // ViewsEntregaExpedicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(842, 537);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbPedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ckbAtivarCor);
            this.Controls.Add(this.dgvSaida);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMotorista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCliente);
            this.Controls.Add(this.cbPesquisa);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ViewsEntregaExpedicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SsE | Expedição";
            this.Load += new System.EventHandler(this.ViewsEntregaExpedicao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewsEntregaExpedicao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPesquisa;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMotorista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvSaida;
        private System.Windows.Forms.CheckBox ckbAtivarCor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbPedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timerCmd;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label label8;
    }
}