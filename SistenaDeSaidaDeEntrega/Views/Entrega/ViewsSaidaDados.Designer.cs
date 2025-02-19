namespace SistenaDeSaidaDeEntrega.Views.Entrega
{
    partial class ViewsSaidaDados
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
            this.txbCodSaida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMotorista = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chPago = new System.Windows.Forms.CheckBox();
            this.cbFormaPg = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.chReceberLocal = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbObs = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmarEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbCodSaida
            // 
            this.txbCodSaida.Enabled = false;
            this.txbCodSaida.Location = new System.Drawing.Point(12, 28);
            this.txbCodSaida.Name = "txbCodSaida";
            this.txbCodSaida.Size = new System.Drawing.Size(112, 20);
            this.txbCodSaida.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de saida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número Pedido";
            // 
            // txbPedido
            // 
            this.txbPedido.Location = new System.Drawing.Point(130, 28);
            this.txbPedido.Name = "txbPedido";
            this.txbPedido.Size = new System.Drawing.Size(112, 20);
            this.txbPedido.TabIndex = 2;
            this.txbPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPedido_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome Cliente";
            // 
            // txbCliente
            // 
            this.txbCliente.Location = new System.Drawing.Point(248, 28);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(370, 20);
            this.txbCliente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Motorista";
            // 
            // cbMotorista
            // 
            this.cbMotorista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotorista.FormattingEnabled = true;
            this.cbMotorista.Location = new System.Drawing.Point(624, 28);
            this.cbMotorista.Name = "cbMotorista";
            this.cbMotorista.Size = new System.Drawing.Size(155, 21);
            this.cbMotorista.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chPago);
            this.groupBox1.Controls.Add(this.cbFormaPg);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbValor);
            this.groupBox1.Controls.Add(this.chReceberLocal);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 94);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receber";
            // 
            // chPago
            // 
            this.chPago.AutoSize = true;
            this.chPago.Enabled = false;
            this.chPago.Location = new System.Drawing.Point(225, 56);
            this.chPago.Name = "chPago";
            this.chPago.Size = new System.Drawing.Size(51, 17);
            this.chPago.TabIndex = 13;
            this.chPago.Text = "Pago";
            this.chPago.UseVisualStyleBackColor = true;
            // 
            // cbFormaPg
            // 
            this.cbFormaPg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPg.Enabled = false;
            this.cbFormaPg.FormattingEnabled = true;
            this.cbFormaPg.Items.AddRange(new object[] {
            "Dinheiro",
            "Credito",
            "Cheque"});
            this.cbFormaPg.Location = new System.Drawing.Point(86, 54);
            this.cbFormaPg.Name = "cbFormaPg";
            this.cbFormaPg.Size = new System.Drawing.Size(133, 21);
            this.cbFormaPg.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Forma de Pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor";
            // 
            // txbValor
            // 
            this.txbValor.Enabled = false;
            this.txbValor.Location = new System.Drawing.Point(9, 55);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(71, 20);
            this.txbValor.TabIndex = 9;
            this.txbValor.TextChanged += new System.EventHandler(this.txbValor_TextChanged);
            this.txbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbValor_KeyPress);
            // 
            // chReceberLocal
            // 
            this.chReceberLocal.AutoSize = true;
            this.chReceberLocal.Location = new System.Drawing.Point(6, 19);
            this.chReceberLocal.Name = "chReceberLocal";
            this.chReceberLocal.Size = new System.Drawing.Size(96, 17);
            this.chReceberLocal.TabIndex = 0;
            this.chReceberLocal.Text = "Receber Local";
            this.chReceberLocal.UseVisualStyleBackColor = true;
            this.chReceberLocal.CheckedChanged += new System.EventHandler(this.cbReceberLocal_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Observação";
            // 
            // txbObs
            // 
            this.txbObs.Location = new System.Drawing.Point(307, 80);
            this.txbObs.Multiline = true;
            this.txbObs.Name = "txbObs";
            this.txbObs.Size = new System.Drawing.Size(472, 66);
            this.txbObs.TabIndex = 10;
            this.txbObs.Text = " ";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Image = global::ContExped.Properties.Resources.ImgConfirmar;
            this.btnConfirmar.Location = new System.Drawing.Point(549, 175);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(111, 41);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "  Confirmar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Image = global::ContExped.Properties.Resources.ImgCancelar;
            this.btnCancelar.Location = new System.Drawing.Point(666, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 41);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "  Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmarEdit
            // 
            this.btnConfirmarEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarEdit.FlatAppearance.BorderSize = 0;
            this.btnConfirmarEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarEdit.Image = global::ContExped.Properties.Resources.ImgConfirmar;
            this.btnConfirmarEdit.Location = new System.Drawing.Point(549, 175);
            this.btnConfirmarEdit.Name = "btnConfirmarEdit";
            this.btnConfirmarEdit.Size = new System.Drawing.Size(111, 41);
            this.btnConfirmarEdit.TabIndex = 15;
            this.btnConfirmarEdit.Text = "  Confirmar Edição";
            this.btnConfirmarEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmarEdit.UseVisualStyleBackColor = false;
            this.btnConfirmarEdit.Visible = false;
            this.btnConfirmarEdit.Click += new System.EventHandler(this.btnConfirmarEdit_Click);
            // 
            // ViewsSaidaDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(789, 228);
            this.Controls.Add(this.btnConfirmarEdit);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txbObs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbMotorista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCodSaida);
            this.Name = "ViewsSaidaDados";
            this.Text = "SsE - Nova Saida";
            this.Load += new System.EventHandler(this.ViewsSaidaDados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCodSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMotorista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chPago;
        private System.Windows.Forms.ComboBox cbFormaPg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.CheckBox chReceberLocal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmarEdit;
        private System.Windows.Forms.TextBox txbObs;
    }
}