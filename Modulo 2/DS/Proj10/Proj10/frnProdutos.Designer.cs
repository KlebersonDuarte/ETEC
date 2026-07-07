namespace Proj10
{
    partial class frnProdutos
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
            this.lblproduto = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCredito = new System.Windows.Forms.ComboBox();
            this.lblcredito = new System.Windows.Forms.Label();
            this.rdbPix = new System.Windows.Forms.RadioButton();
            this.lblqtde = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtQntd = new System.Windows.Forms.TextBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblResposta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblproduto
            // 
            this.lblproduto.AutoSize = true;
            this.lblproduto.Location = new System.Drawing.Point(22, 24);
            this.lblproduto.Name = "lblproduto";
            this.lblproduto.Size = new System.Drawing.Size(49, 13);
            this.lblproduto.TabIndex = 0;
            this.lblproduto.Text = "Produtos";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(169, 370);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCredito);
            this.groupBox1.Controls.Add(this.lblcredito);
            this.groupBox1.Controls.Add(this.rdbPix);
            this.groupBox1.Location = new System.Drawing.Point(44, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FORMA DE PAGAMENTO";
            // 
            // cboCredito
            // 
            this.cboCredito.FormattingEnabled = true;
            this.cboCredito.Items.AddRange(new object[] {
            "5x",
            "10x"});
            this.cboCredito.Location = new System.Drawing.Point(152, 31);
            this.cboCredito.Name = "cboCredito";
            this.cboCredito.Size = new System.Drawing.Size(115, 21);
            this.cboCredito.TabIndex = 2;
            this.cboCredito.SelectedIndexChanged += new System.EventHandler(this.cboCredito_SelectedIndexChanged);
            // 
            // lblcredito
            // 
            this.lblcredito.AutoSize = true;
            this.lblcredito.Location = new System.Drawing.Point(112, 34);
            this.lblcredito.Name = "lblcredito";
            this.lblcredito.Size = new System.Drawing.Size(40, 13);
            this.lblcredito.TabIndex = 1;
            this.lblcredito.Text = "Crédito";
            // 
            // rdbPix
            // 
            this.rdbPix.AutoSize = true;
            this.rdbPix.Location = new System.Drawing.Point(7, 32);
            this.rdbPix.Name = "rdbPix";
            this.rdbPix.Size = new System.Drawing.Size(39, 17);
            this.rdbPix.TabIndex = 0;
            this.rdbPix.TabStop = true;
            this.rdbPix.Text = "Pix";
            this.rdbPix.UseVisualStyleBackColor = true;
            this.rdbPix.Click += new System.EventHandler(this.rdbPix_Click);
            // 
            // lblqtde
            // 
            this.lblqtde.AutoSize = true;
            this.lblqtde.Location = new System.Drawing.Point(22, 78);
            this.lblqtde.Name = "lblqtde";
            this.lblqtde.Size = new System.Drawing.Size(30, 13);
            this.lblqtde.TabIndex = 3;
            this.lblqtde.Text = "Qtde";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(73, 24);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(100, 20);
            this.txtProduto.TabIndex = 4;
            // 
            // txtQntd
            // 
            this.txtQntd.Location = new System.Drawing.Point(73, 78);
            this.txtQntd.Name = "txtQntd";
            this.txtQntd.Size = new System.Drawing.Size(100, 20);
            this.txtQntd.TabIndex = 5;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(209, 78);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(37, 13);
            this.lblvalor.TabIndex = 6;
            this.lblvalor.Text = "VL R$";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(259, 78);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(261, 130);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 8;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(404, 130);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(16, 13);
            this.lblResposta.TabIndex = 9;
            this.lblResposta.Text = "...";
            // 
            // frnProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.txtQntd);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lblqtde);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblproduto);
            this.Name = "frnProdutos";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblproduto;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblcredito;
        private System.Windows.Forms.RadioButton rdbPix;
        private System.Windows.Forms.Label lblqtde;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtQntd;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cboCredito;
        private System.Windows.Forms.Label lblResposta;
    }
}