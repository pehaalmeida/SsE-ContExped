namespace SistenaDeSaidaDeEntrega.Views
{
    partial class ViewsHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbAvisosDiarios = new System.Windows.Forms.TextBox();
            this.MsHome = new System.Windows.Forms.MenuStrip();
            this.MsHomeNaRua = new System.Windows.Forms.ToolStripMenuItem();
            this.MsHomeNovaEntrega = new System.Windows.Forms.ToolStripMenuItem();
            this.MsHomeCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MsHomeCadastroMotorista = new System.Windows.Forms.ToolStripMenuItem();
            this.MsHomeCadastroUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MsHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(581, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Avisos diarios";
            // 
            // txbAvisosDiarios
            // 
            this.txbAvisosDiarios.BackColor = System.Drawing.Color.Gainsboro;
            this.txbAvisosDiarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbAvisosDiarios.Enabled = false;
            this.txbAvisosDiarios.Location = new System.Drawing.Point(473, 297);
            this.txbAvisosDiarios.Multiline = true;
            this.txbAvisosDiarios.Name = "txbAvisosDiarios";
            this.txbAvisosDiarios.Size = new System.Drawing.Size(310, 162);
            this.txbAvisosDiarios.TabIndex = 7;
            this.txbAvisosDiarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MsHome
            // 
            this.MsHome.BackColor = System.Drawing.SystemColors.Control;
            this.MsHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.MsHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsHomeNaRua,
            this.MsHomeNovaEntrega,
            this.MsHomeCadastro,
            this.configuraçãoToolStripMenuItem});
            this.MsHome.Location = new System.Drawing.Point(0, 0);
            this.MsHome.Name = "MsHome";
            this.MsHome.Size = new System.Drawing.Size(126, 481);
            this.MsHome.TabIndex = 8;
            this.MsHome.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MsHome_ItemClicked);
            // 
            // MsHomeNaRua
            // 
            this.MsHomeNaRua.Image = global::ContExped.Properties.Resources.ImgSaida96x;
            this.MsHomeNaRua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MsHomeNaRua.Name = "MsHomeNaRua";
            this.MsHomeNaRua.Size = new System.Drawing.Size(113, 115);
            this.MsHomeNaRua.Text = "Entrega Na Rua";
            this.MsHomeNaRua.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.MsHomeNaRua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MsHomeNaRua.Click += new System.EventHandler(this.MsHomeNaRua_Click);
            // 
            // MsHomeNovaEntrega
            // 
            this.MsHomeNovaEntrega.Image = global::ContExped.Properties.Resources.ImgNovaSaida96x;
            this.MsHomeNovaEntrega.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MsHomeNovaEntrega.Name = "MsHomeNovaEntrega";
            this.MsHomeNovaEntrega.Size = new System.Drawing.Size(113, 115);
            this.MsHomeNovaEntrega.Text = "Nova Entrega";
            this.MsHomeNovaEntrega.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MsHomeNovaEntrega.Click += new System.EventHandler(this.MsHomeNovaEntrega_Click_1);
            // 
            // MsHomeCadastro
            // 
            this.MsHomeCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsHomeCadastroMotorista,
            this.MsHomeCadastroUsuario});
            this.MsHomeCadastro.Image = global::ContExped.Properties.Resources.ImgCadastro;
            this.MsHomeCadastro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MsHomeCadastro.Name = "MsHomeCadastro";
            this.MsHomeCadastro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MsHomeCadastro.Size = new System.Drawing.Size(113, 115);
            this.MsHomeCadastro.Text = "Cadastro";
            this.MsHomeCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MsHomeCadastroMotorista
            // 
            this.MsHomeCadastroMotorista.Name = "MsHomeCadastroMotorista";
            this.MsHomeCadastroMotorista.Size = new System.Drawing.Size(157, 22);
            this.MsHomeCadastroMotorista.Text = "Novo Motorista";
            this.MsHomeCadastroMotorista.Click += new System.EventHandler(this.MsHomeCadastroMotorista_Click);
            // 
            // MsHomeCadastroUsuario
            // 
            this.MsHomeCadastroUsuario.Name = "MsHomeCadastroUsuario";
            this.MsHomeCadastroUsuario.Size = new System.Drawing.Size(157, 22);
            this.MsHomeCadastroUsuario.Text = "Novo Usuário";
            this.MsHomeCadastroUsuario.Click += new System.EventHandler(this.MsHomeCadastroUsuario_Click);
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.Image = global::ContExped.Properties.Resources.ImgConfig;
            this.configuraçãoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(113, 83);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            this.configuraçãoToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.configuraçãoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.configuraçãoToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoToolStripMenuItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox3.Location = new System.Drawing.Point(461, 263);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(334, 26);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Location = new System.Drawing.Point(461, 289);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(334, 180);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContExped.Properties.Resources.ImgLogoSse;
            this.pictureBox1.Location = new System.Drawing.Point(520, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ViewsHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(807, 481);
            this.Controls.Add(this.txbAvisosDiarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MsHome);
            this.MaximizeBox = false;
            this.Name = "ViewsHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SsE - Sistema de Saida de Entrega";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewsHome_FormClosing);
            this.Load += new System.EventHandler(this.ViewsHome_Load);
            this.MsHome.ResumeLayout(false);
            this.MsHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAvisosDiarios;
        private System.Windows.Forms.MenuStrip MsHome;
        private System.Windows.Forms.ToolStripMenuItem MsHomeNaRua;
        private System.Windows.Forms.ToolStripMenuItem MsHomeCadastro;
        private System.Windows.Forms.ToolStripMenuItem MsHomeCadastroMotorista;
        private System.Windows.Forms.ToolStripMenuItem MsHomeCadastroUsuario;
        private System.Windows.Forms.ToolStripMenuItem MsHomeNovaEntrega;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
    }
}