namespace Proj12
{
    partial class frmMensalidade
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnMensal = new System.Windows.Forms.Button();
            this.txtIDMatricula = new System.Windows.Forms.TextBox();
            this.dtpPagamento = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnLimparMens = new System.Windows.Forms.Button();
            this.btnAlterarMens = new System.Windows.Forms.Button();
            this.btnExcluirMens = new System.Windows.Forms.Button();
            this.dgvMens = new System.Windows.Forms.DataGridView();
            this.btnConsGeralMens = new System.Windows.Forms.Button();
            this.btnConsIndiMens = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMens)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Pagamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor a pagar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // btnMensal
            // 
            this.btnMensal.Location = new System.Drawing.Point(673, 35);
            this.btnMensal.Name = "btnMensal";
            this.btnMensal.Size = new System.Drawing.Size(75, 23);
            this.btnMensal.TabIndex = 5;
            this.btnMensal.Text = "Incluir";
            this.btnMensal.UseVisualStyleBackColor = true;
            this.btnMensal.Click += new System.EventHandler(this.btnMensal_Click);
            // 
            // txtIDMatricula
            // 
            this.txtIDMatricula.Location = new System.Drawing.Point(338, 45);
            this.txtIDMatricula.Name = "txtIDMatricula";
            this.txtIDMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtIDMatricula.TabIndex = 6;
            // 
            // dtpPagamento
            // 
            this.dtpPagamento.Location = new System.Drawing.Point(374, 73);
            this.dtpPagamento.Name = "dtpPagamento";
            this.dtpPagamento.Size = new System.Drawing.Size(200, 20);
            this.dtpPagamento.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(357, 105);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 8;
            // 
            // btnLimparMens
            // 
            this.btnLimparMens.Location = new System.Drawing.Point(673, 154);
            this.btnLimparMens.Name = "btnLimparMens";
            this.btnLimparMens.Size = new System.Drawing.Size(75, 23);
            this.btnLimparMens.TabIndex = 11;
            this.btnLimparMens.Text = "Limpar";
            this.btnLimparMens.UseVisualStyleBackColor = true;
            this.btnLimparMens.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterarMens
            // 
            this.btnAlterarMens.Location = new System.Drawing.Point(673, 74);
            this.btnAlterarMens.Name = "btnAlterarMens";
            this.btnAlterarMens.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarMens.TabIndex = 12;
            this.btnAlterarMens.Text = "Alterar";
            this.btnAlterarMens.UseVisualStyleBackColor = true;
            this.btnAlterarMens.Click += new System.EventHandler(this.btnAlterarMens_Click);
            // 
            // btnExcluirMens
            // 
            this.btnExcluirMens.Location = new System.Drawing.Point(673, 115);
            this.btnExcluirMens.Name = "btnExcluirMens";
            this.btnExcluirMens.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirMens.TabIndex = 13;
            this.btnExcluirMens.Text = "Excluir";
            this.btnExcluirMens.UseVisualStyleBackColor = true;
            this.btnExcluirMens.Click += new System.EventHandler(this.btnExcluirMens_Click);
            // 
            // dgvMens
            // 
            this.dgvMens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMens.Location = new System.Drawing.Point(280, 164);
            this.dgvMens.Name = "dgvMens";
            this.dgvMens.Size = new System.Drawing.Size(255, 89);
            this.dgvMens.TabIndex = 14;
            this.dgvMens.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMens_MouseClick);
            // 
            // btnConsGeralMens
            // 
            this.btnConsGeralMens.Location = new System.Drawing.Point(673, 201);
            this.btnConsGeralMens.Name = "btnConsGeralMens";
            this.btnConsGeralMens.Size = new System.Drawing.Size(75, 23);
            this.btnConsGeralMens.TabIndex = 15;
            this.btnConsGeralMens.Text = "ConsGeral";
            this.btnConsGeralMens.UseVisualStyleBackColor = true;
            this.btnConsGeralMens.Click += new System.EventHandler(this.btnConsGeralMens_Click);
            // 
            // btnConsIndiMens
            // 
            this.btnConsIndiMens.Location = new System.Drawing.Point(673, 245);
            this.btnConsIndiMens.Name = "btnConsIndiMens";
            this.btnConsIndiMens.Size = new System.Drawing.Size(75, 23);
            this.btnConsIndiMens.TabIndex = 16;
            this.btnConsIndiMens.Text = "ConsIndi";
            this.btnConsIndiMens.UseVisualStyleBackColor = true;
            this.btnConsIndiMens.Click += new System.EventHandler(this.btnConsIndiMens_Click);
            // 
            // frmMensalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsIndiMens);
            this.Controls.Add(this.btnConsGeralMens);
            this.Controls.Add(this.dgvMens);
            this.Controls.Add(this.btnExcluirMens);
            this.Controls.Add(this.btnAlterarMens);
            this.Controls.Add(this.btnLimparMens);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.dtpPagamento);
            this.Controls.Add(this.txtIDMatricula);
            this.Controls.Add(this.btnMensal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMensalidade";
            this.Text = "frmMensalidade";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMensal;
        private System.Windows.Forms.TextBox txtIDMatricula;
        private System.Windows.Forms.DateTimePicker dtpPagamento;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnLimparMens;
        private System.Windows.Forms.Button btnAlterarMens;
        private System.Windows.Forms.Button btnExcluirMens;
        private System.Windows.Forms.DataGridView dgvMens;
        private System.Windows.Forms.Button btnConsGeralMens;
        private System.Windows.Forms.Button btnConsIndiMens;
    }
}