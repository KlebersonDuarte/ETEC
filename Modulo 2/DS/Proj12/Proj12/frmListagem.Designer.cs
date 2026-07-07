namespace Proj12
{
    partial class frmListagem
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
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnNiver = new System.Windows.Forms.Button();
            this.btnPg = new System.Windows.Forms.Button();
            this.btnDesc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(58, 171);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(663, 235);
            this.dgvResultado.TabIndex = 0;
            // 
            // btnAlunos
            // 
            this.btnAlunos.Location = new System.Drawing.Point(164, 24);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnAlunos.TabIndex = 1;
            this.btnAlunos.Text = "Pesquisar";
            this.btnAlunos.UseVisualStyleBackColor = true;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // btnNiver
            // 
            this.btnNiver.Location = new System.Drawing.Point(164, 75);
            this.btnNiver.Name = "btnNiver";
            this.btnNiver.Size = new System.Drawing.Size(75, 23);
            this.btnNiver.TabIndex = 2;
            this.btnNiver.Text = "Pesquisar";
            this.btnNiver.UseVisualStyleBackColor = true;
            this.btnNiver.Click += new System.EventHandler(this.btnNiver_Click);
            // 
            // btnPg
            // 
            this.btnPg.Location = new System.Drawing.Point(517, 19);
            this.btnPg.Name = "btnPg";
            this.btnPg.Size = new System.Drawing.Size(75, 23);
            this.btnPg.TabIndex = 3;
            this.btnPg.Text = "Pesquisar";
            this.btnPg.UseVisualStyleBackColor = true;
            this.btnPg.Click += new System.EventHandler(this.btnPg_Click);
            // 
            // btnDesc
            // 
            this.btnDesc.Location = new System.Drawing.Point(517, 70);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(75, 23);
            this.btnDesc.TabIndex = 4;
            this.btnDesc.Text = "Pesquisar";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alunos (Ordem de nome)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aniversáriantes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pagamentos efetudados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descontos liberados por mês";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mês da pesquisa:";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(139, 125);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 10;
            // 
            // frmListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.btnPg);
            this.Controls.Add(this.btnNiver);
            this.Controls.Add(this.btnAlunos);
            this.Controls.Add(this.dgvResultado);
            this.Name = "frmListagem";
            this.Text = "frmListagem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnNiver;
        private System.Windows.Forms.Button btnPg;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMes;
    }
}