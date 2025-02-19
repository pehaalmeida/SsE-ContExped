namespace SistenaDeSaidaDeEntrega.Views.Motorista
{
    partial class ViewsMotorista
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
            this.txbNomePesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dgvMotorista = new System.Windows.Forms.DataGridView();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.timeCmdDgV = new System.Windows.Forms.Timer(this.components);
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotorista)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNomePesquisa
            // 
            this.txbNomePesquisa.Location = new System.Drawing.Point(12, 29);
            this.txbNomePesquisa.Name = "txbNomePesquisa";
            this.txbNomePesquisa.Size = new System.Drawing.Size(178, 20);
            this.txbNomePesquisa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Motorista";
            // 
            // btnDesativar
            // 
            this.btnDesativar.BackColor = System.Drawing.SystemColors.Control;
            this.btnDesativar.FlatAppearance.BorderSize = 0;
            this.btnDesativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesativar.Image = global::ContExped.Properties.Resources.ImgDeletarItem16x;
            this.btnDesativar.Location = new System.Drawing.Point(244, 55);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(111, 41);
            this.btnDesativar.TabIndex = 34;
            this.btnDesativar.Text = "  Desativar";
            this.btnDesativar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDesativar.UseVisualStyleBackColor = false;
            this.btnDesativar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::ContExped.Properties.Resources.ImgEditor32x;
            this.btnEditar.Location = new System.Drawing.Point(127, 55);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(111, 41);
            this.btnEditar.TabIndex = 33;
            this.btnEditar.Text = "  Alterar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.Control;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Image = global::ContExped.Properties.Resources.ImgNovo32x;
            this.btnInserir.Location = new System.Drawing.Point(12, 55);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(111, 41);
            this.btnInserir.TabIndex = 32;
            this.btnInserir.Text = "  Inserir";
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dgvMotorista
            // 
            this.dgvMotorista.AllowUserToAddRows = false;
            this.dgvMotorista.AllowUserToDeleteRows = false;
            this.dgvMotorista.AllowUserToResizeColumns = false;
            this.dgvMotorista.AllowUserToResizeRows = false;
            this.dgvMotorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotorista.Location = new System.Drawing.Point(12, 102);
            this.dgvMotorista.MultiSelect = false;
            this.dgvMotorista.Name = "dgvMotorista";
            this.dgvMotorista.ReadOnly = true;
            this.dgvMotorista.RowHeadersWidth = 21;
            this.dgvMotorista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMotorista.Size = new System.Drawing.Size(343, 360);
            this.dgvMotorista.TabIndex = 35;
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Checked = true;
            this.cbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivo.Location = new System.Drawing.Point(199, 29);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(55, 17);
            this.cbAtivo.TabIndex = 36;
            this.cbAtivo.Text = "Ativos";
            this.cbAtivo.UseVisualStyleBackColor = true;
            this.cbAtivo.CheckedChanged += new System.EventHandler(this.cbAtivo_CheckedChanged);
            // 
            // timeCmdDgV
            // 
            this.timeCmdDgV.Enabled = true;
            this.timeCmdDgV.Interval = 1000;
            this.timeCmdDgV.Tick += new System.EventHandler(this.timeCmdDgV_Tick);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.BackColor = System.Drawing.SystemColors.Control;
            this.btnHabilitar.FlatAppearance.BorderSize = 0;
            this.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitar.Image = global::ContExped.Properties.Resources.ImgNovo32x;
            this.btnHabilitar.Location = new System.Drawing.Point(244, 55);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(111, 41);
            this.btnHabilitar.TabIndex = 37;
            this.btnHabilitar.Text = "  Habilitar";
            this.btnHabilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHabilitar.UseVisualStyleBackColor = false;
            this.btnHabilitar.Visible = false;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Image = global::ContExped.Properties.Resources.ImgConsulta;
            this.btnFiltrar.Location = new System.Drawing.Point(257, 8);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 41);
            this.btnFiltrar.TabIndex = 31;
            this.btnFiltrar.Text = "  Filtrar";
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewsMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(367, 472);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.cbAtivo);
            this.Controls.Add(this.dgvMotorista);
            this.Controls.Add(this.btnDesativar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNomePesquisa);
            this.Name = "ViewsMotorista";
            this.Text = "Motorista";
            this.Load += new System.EventHandler(this.ViewsMotorista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotorista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNomePesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView dgvMotorista;
        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.Timer timeCmdDgV;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnFiltrar;
    }
}