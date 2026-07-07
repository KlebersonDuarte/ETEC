namespace Proj13
{
    partial class Servicos
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
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoPet = new System.Windows.Forms.TextBox();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesqRapS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDServico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Banho",
            "Tosa"});
            this.cboTipo.Location = new System.Drawing.Point(332, 44);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data:";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(332, 81);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(332, 112);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Código Pet:";
            // 
            // txtCodigoPet
            // 
            this.txtCodigoPet.Location = new System.Drawing.Point(332, 143);
            this.txtCodigoPet.Name = "txtCodigoPet";
            this.txtCodigoPet.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPet.TabIndex = 7;
            // 
            // btnMarcar
            // 
            this.btnMarcar.Location = new System.Drawing.Point(285, 191);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(75, 23);
            this.btnMarcar.TabIndex = 8;
            this.btnMarcar.Text = "Marcar";
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.Location = new System.Drawing.Point(378, 191);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(75, 23);
            this.btnDesmarcar.TabIndex = 9;
            this.btnDesmarcar.Text = "Desmarcar";
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(332, 220);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesqRapS
            // 
            this.btnPesqRapS.Location = new System.Drawing.Point(332, 288);
            this.btnPesqRapS.Name = "btnPesqRapS";
            this.btnPesqRapS.Size = new System.Drawing.Size(100, 23);
            this.btnPesqRapS.TabIndex = 11;
            this.btnPesqRapS.Text = "Pesquisa Rápida";
            this.btnPesqRapS.UseVisualStyleBackColor = true;
            this.btnPesqRapS.Click += new System.EventHandler(this.btnPesqRapS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID do Serviço:";
            // 
            // txtIDServico
            // 
            this.txtIDServico.Location = new System.Drawing.Point(668, 44);
            this.txtIDServico.Name = "txtIDServico";
            this.txtIDServico.Size = new System.Drawing.Size(100, 20);
            this.txtIDServico.TabIndex = 13;
            // 
            // Servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIDServico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPesqRapS);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.txtCodigoPet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label1);
            this.Name = "Servicos";
            this.Text = "Servicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoPet;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesqRapS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDServico;
    }
}