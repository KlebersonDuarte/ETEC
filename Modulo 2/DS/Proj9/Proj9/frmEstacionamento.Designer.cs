namespace Proj9
{
    partial class frmEstacionamento
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboConvenio = new System.Windows.Forms.ComboBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saída";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Entrada";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(538, 174);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(52, 13);
            this.lblResposta.TabIndex = 5;
            this.lblResposta.Text = "Resposta";
            // 
            // btnPagamento
            // 
            this.btnPagamento.Location = new System.Drawing.Point(84, 402);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(75, 23);
            this.btnPagamento.TabIndex = 6;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Items.AddRange(new object[] {
            "Honda",
            "Toyota",
            "Ford"});
            this.cboMarca.Location = new System.Drawing.Point(124, 98);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 7;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // cboModelo
            // 
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(402, 98);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(121, 21);
            this.cboModelo.TabIndex = 8;
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntrada.Location = new System.Drawing.Point(131, 174);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(200, 20);
            this.dtpEntrada.TabIndex = 9;
            // 
            // dtpSaida
            // 
            this.dtpSaida.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaida.Location = new System.Drawing.Point(131, 242);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(200, 20);
            this.dtpSaida.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboConvenio);
            this.groupBox1.Location = new System.Drawing.Point(84, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 57);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convenio";
            // 
            // cboConvenio
            // 
            this.cboConvenio.FormattingEnabled = true;
            this.cboConvenio.Items.AddRange(new object[] {
            "5%",
            "2,5%",
            "R$5"});
            this.cboConvenio.Location = new System.Drawing.Point(40, 19);
            this.cboConvenio.Name = "cboConvenio";
            this.cboConvenio.Size = new System.Drawing.Size(121, 21);
            this.cboConvenio.TabIndex = 0;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(131, 39);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 12;
            // 
            // frmEstacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpSaida);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.cboModelo);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEstacionamento";
            this.Text = "frmEstacionamento";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.DateTimePicker dtpSaida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboConvenio;
        private System.Windows.Forms.TextBox txtPlaca;
    }
}