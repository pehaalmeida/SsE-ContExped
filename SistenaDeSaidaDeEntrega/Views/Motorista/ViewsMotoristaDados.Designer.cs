namespace SistenaDeSaidaDeEntrega.Views.Motorista
{
    partial class ViewsMotoristaDados
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
            this.btnConfirmarEdit = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txbMotorista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnConfirmarEdit
            // 
            this.btnConfirmarEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarEdit.FlatAppearance.BorderSize = 0;
            this.btnConfirmarEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarEdit.Image = global::ContExped.Properties.Resources.ImgConfirmar;
            this.btnConfirmarEdit.Location = new System.Drawing.Point(12, 57);
            this.btnConfirmarEdit.Name = "btnConfirmarEdit";
            this.btnConfirmarEdit.Size = new System.Drawing.Size(113, 41);
            this.btnConfirmarEdit.TabIndex = 18;
            this.btnConfirmarEdit.Text = "  Confirmar Edição";
            this.btnConfirmarEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmarEdit.UseVisualStyleBackColor = false;
            this.btnConfirmarEdit.Visible = false;
            this.btnConfirmarEdit.Click += new System.EventHandler(this.btnConfirmarEdit_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Image = global::ContExped.Properties.Resources.ImgCancelar;
            this.btnCancelar.Location = new System.Drawing.Point(131, 57);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 41);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "  Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Image = global::ContExped.Properties.Resources.ImgConfirmar;
            this.btnConfirmar.Location = new System.Drawing.Point(12, 57);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(113, 41);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.Text = "  Confirmar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbMotorista
            // 
            this.txbMotorista.Location = new System.Drawing.Point(12, 25);
            this.txbMotorista.Name = "txbMotorista";
            this.txbMotorista.Size = new System.Drawing.Size(198, 20);
            this.txbMotorista.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome do Motorista";
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Location = new System.Drawing.Point(216, 28);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(50, 17);
            this.cbAtivo.TabIndex = 21;
            this.cbAtivo.Text = "Ativo";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // ViewsMotoristaDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(271, 107);
            this.Controls.Add(this.cbAtivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMotorista);
            this.Controls.Add(this.btnConfirmarEdit);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewsMotoristaDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Motorista";
            this.Load += new System.EventHandler(this.ViewsMotoristaDados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmarEdit;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txbMotorista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbAtivo;
    }
}