namespace Proj7
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboMoveis = new System.Windows.Forms.ComboBox();
            this.cboOpcao1 = new System.Windows.Forms.ComboBox();
            this.cboOpcao2 = new System.Windows.Forms.ComboBox();
            this.cboParcelas = new System.Windows.Forms.ComboBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPix = new System.Windows.Forms.RadioButton();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.lblValorParcela = new System.Windows.Forms.Label();
            this.lblValorDesconto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboMoveis
            // 
            this.cboMoveis.FormattingEnabled = true;
            this.cboMoveis.Location = new System.Drawing.Point(336, 94);
            this.cboMoveis.Name = "cboMoveis";
            this.cboMoveis.Size = new System.Drawing.Size(121, 21);
            this.cboMoveis.TabIndex = 0;
            this.cboMoveis.SelectedIndexChanged += new System.EventHandler(this.cboMoveis_SelectedIndexChanged);
            // 
            // cboOpcao1
            // 
            this.cboOpcao1.FormattingEnabled = true;
            this.cboOpcao1.Location = new System.Drawing.Point(336, 143);
            this.cboOpcao1.Name = "cboOpcao1";
            this.cboOpcao1.Size = new System.Drawing.Size(121, 21);
            this.cboOpcao1.TabIndex = 1;
            this.cboOpcao1.SelectedIndexChanged += new System.EventHandler(this.cboOpcao1_SelectedIndexChanged);
            // 
            // cboOpcao2
            // 
            this.cboOpcao2.FormattingEnabled = true;
            this.cboOpcao2.Location = new System.Drawing.Point(336, 200);
            this.cboOpcao2.Name = "cboOpcao2";
            this.cboOpcao2.Size = new System.Drawing.Size(121, 21);
            this.cboOpcao2.TabIndex = 2;
            this.cboOpcao2.SelectedIndexChanged += new System.EventHandler(this.cboOpcao2_SelectedIndexChanged);
            // 
            // cboParcelas
            // 
            this.cboParcelas.FormattingEnabled = true;
            this.cboParcelas.Location = new System.Drawing.Point(336, 392);
            this.cboParcelas.Name = "cboParcelas";
            this.cboParcelas.Size = new System.Drawing.Size(121, 21);
            this.cboParcelas.TabIndex = 3;
            this.cboParcelas.Visible = false;
            this.cboParcelas.SelectedIndexChanged += new System.EventHandler(this.cboParcelas_SelectedIndexChanged);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(659, 243);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(16, 13);
            this.lblResposta.TabIndex = 4;
            this.lblResposta.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPix);
            this.groupBox1.Controls.Add(this.rdbCredito);
            this.groupBox1.Location = new System.Drawing.Point(336, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagamento";
            // 
            // rdbPix
            // 
            this.rdbPix.AutoSize = true;
            this.rdbPix.Location = new System.Drawing.Point(7, 36);
            this.rdbPix.Name = "rdbPix";
            this.rdbPix.Size = new System.Drawing.Size(39, 17);
            this.rdbPix.TabIndex = 1;
            this.rdbPix.TabStop = true;
            this.rdbPix.Text = "Pix";
            this.rdbPix.UseVisualStyleBackColor = true;
            this.rdbPix.CheckedChanged += new System.EventHandler(this.rdbPix_CheckedChanged);
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.Location = new System.Drawing.Point(7, 59);
            this.rdbCredito.Name = "rdbCredito";
            this.rdbCredito.Size = new System.Drawing.Size(58, 17);
            this.rdbCredito.TabIndex = 0;
            this.rdbCredito.TabStop = true;
            this.rdbCredito.Text = "Crédito";
            this.rdbCredito.UseVisualStyleBackColor = true;
            this.rdbCredito.CheckedChanged += new System.EventHandler(this.rdbCredito_CheckedChanged);
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Location = new System.Drawing.Point(552, 243);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(106, 13);
            this.lblMoeda.TabIndex = 6;
            this.lblMoeda.Text = "Valor do Produto: R$";
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.AutoSize = true;
            this.lblValorParcela.Location = new System.Drawing.Point(552, 297);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(0, 13);
            this.lblValorParcela.TabIndex = 7;
            // 
            // lblValorDesconto
            // 
            this.lblValorDesconto.AutoSize = true;
            this.lblValorDesconto.Location = new System.Drawing.Point(659, 257);
            this.lblValorDesconto.Name = "lblValorDesconto";
            this.lblValorDesconto.Size = new System.Drawing.Size(0, 13);
            this.lblValorDesconto.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Valor Final: R$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValorDesconto);
            this.Controls.Add(this.lblValorParcela);
            this.Controls.Add(this.lblMoeda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.cboParcelas);
            this.Controls.Add(this.cboOpcao2);
            this.Controls.Add(this.cboOpcao1);
            this.Controls.Add(this.cboMoveis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMoveis;
        private System.Windows.Forms.ComboBox cboOpcao1;
        private System.Windows.Forms.ComboBox cboOpcao2;
        private System.Windows.Forms.ComboBox cboParcelas;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbPix;
        private System.Windows.Forms.RadioButton rdbCredito;
        private System.Windows.Forms.Label lblMoeda;
        private System.Windows.Forms.Label lblValorParcela;
        private System.Windows.Forms.Label lblValorDesconto;
        private System.Windows.Forms.Label label1;
    }
}

