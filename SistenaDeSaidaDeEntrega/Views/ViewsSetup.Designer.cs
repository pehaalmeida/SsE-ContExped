namespace ContExped.Views
{
    partial class ViewsSetup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbFazerConexao = new System.Windows.Forms.Button();
            this.lblStatusBanco = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSenhaDB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbLoginDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIPServidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStatusAtivacao = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbFazerConexao);
            this.groupBox1.Controls.Add(this.lblStatusBanco);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbSenhaDB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbLoginDB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbIPServidor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMAÇÃO DO BANCO DE DADOS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txbFazerConexao
            // 
            this.txbFazerConexao.Location = new System.Drawing.Point(268, 114);
            this.txbFazerConexao.Name = "txbFazerConexao";
            this.txbFazerConexao.Size = new System.Drawing.Size(101, 34);
            this.txbFazerConexao.TabIndex = 4;
            this.txbFazerConexao.Text = "Fazer Conexão";
            this.txbFazerConexao.UseVisualStyleBackColor = true;
            this.txbFazerConexao.Click += new System.EventHandler(this.txbFazerConexao_Click);
            // 
            // lblStatusBanco
            // 
            this.lblStatusBanco.AutoSize = true;
            this.lblStatusBanco.Location = new System.Drawing.Point(252, 44);
            this.lblStatusBanco.Name = "lblStatusBanco";
            this.lblStatusBanco.Size = new System.Drawing.Size(54, 13);
            this.lblStatusBanco.TabIndex = 7;
            this.lblStatusBanco.Text = "OFFILINE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "STATUS:";
            // 
            // txbSenhaDB
            // 
            this.txbSenhaDB.Location = new System.Drawing.Point(204, 89);
            this.txbSenhaDB.Name = "txbSenhaDB";
            this.txbSenhaDB.Size = new System.Drawing.Size(165, 20);
            this.txbSenhaDB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SENHA";
            // 
            // txbLoginDB
            // 
            this.txbLoginDB.Location = new System.Drawing.Point(13, 89);
            this.txbLoginDB.Name = "txbLoginDB";
            this.txbLoginDB.Size = new System.Drawing.Size(185, 20);
            this.txbLoginDB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "LOGIN";
            // 
            // txbIPServidor
            // 
            this.txbIPServidor.Location = new System.Drawing.Point(13, 41);
            this.txbIPServidor.Name = "txbIPServidor";
            this.txbIPServidor.Size = new System.Drawing.Size(185, 20);
            this.txbIPServidor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP SERVIDOR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lblStatusAtivacao);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DADOS SISTEMA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Fazer Validação";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblStatusAtivacao
            // 
            this.lblStatusAtivacao.AutoSize = true;
            this.lblStatusAtivacao.Location = new System.Drawing.Point(134, 112);
            this.lblStatusAtivacao.Name = "lblStatusAtivacao";
            this.lblStatusAtivacao.Size = new System.Drawing.Size(54, 13);
            this.lblStatusAtivacao.TabIndex = 9;
            this.lblStatusAtivacao.Text = "OFFILINE";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(204, 80);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(165, 20);
            this.textBox6.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "STATUS DE ATIVAÇÃO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "VALIDADE";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(14, 80);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(184, 20);
            this.textBox5.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "SERIE";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(13, 39);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(356, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "CHAVE DE ATIVAÇÃO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(286, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 34);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(179, 342);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(101, 34);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // ViewsSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 388);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewsSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup BigTechByte ";
            this.Load += new System.EventHandler(this.ViewsSetup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txbFazerConexao;
        private System.Windows.Forms.Label lblStatusBanco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSenhaDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbLoginDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbIPServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStatusAtivacao;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button button1;
    }
}