namespace Proj13
{
    partial class Consulta
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
            this.txtCodigoPet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrescricao = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesqRapC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDConsulta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Pet:";
            // 
            // txtCodigoPet
            // 
            this.txtCodigoPet.Location = new System.Drawing.Point(350, 37);
            this.txtCodigoPet.Name = "txtCodigoPet";
            this.txtCodigoPet.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPet.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data:";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(323, 70);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prescrição:";
            // 
            // txtPrescricao
            // 
            this.txtPrescricao.Location = new System.Drawing.Point(350, 109);
            this.txtPrescricao.Name = "txtPrescricao";
            this.txtPrescricao.Size = new System.Drawing.Size(100, 20);
            this.txtPrescricao.TabIndex = 5;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(287, 150);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(375, 150);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(335, 179);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesqRapC
            // 
            this.btnPesqRapC.Location = new System.Drawing.Point(634, 128);
            this.btnPesqRapC.Name = "btnPesqRapC";
            this.btnPesqRapC.Size = new System.Drawing.Size(106, 23);
            this.btnPesqRapC.TabIndex = 9;
            this.btnPesqRapC.Text = "Pesquisa Rápida";
            this.btnPesqRapC.UseVisualStyleBackColor = true;
            this.btnPesqRapC.Click += new System.EventHandler(this.btnPesqRapC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID da Consulta:";
            // 
            // txtIDConsulta
            // 
            this.txtIDConsulta.Location = new System.Drawing.Point(640, 40);
            this.txtIDConsulta.Name = "txtIDConsulta";
            this.txtIDConsulta.Size = new System.Drawing.Size(100, 20);
            this.txtIDConsulta.TabIndex = 11;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIDConsulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPesqRapC);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtPrescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoPet);
            this.Controls.Add(this.label1);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoPet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrescricao;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesqRapC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDConsulta;
    }
}