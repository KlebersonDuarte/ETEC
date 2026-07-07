namespace Proj12
{
    partial class frmAlunos
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
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnLimparAlunos = new System.Windows.Forms.Button();
            this.btnAlterarAlunos = new System.Windows.Forms.Button();
            this.btnExcluirAlunos = new System.Windows.Forms.Button();
            this.btnConsGeralAlunos = new System.Windows.Forms.Button();
            this.btnConsIndiAlunos = new System.Windows.Forms.Button();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Location = new System.Drawing.Point(340, 129);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(200, 20);
            this.dtpNascimento.TabIndex = 5;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(340, 21);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(329, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(329, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(311, 157);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 9;
            // 
            // btnAlunos
            // 
            this.btnAlunos.Location = new System.Drawing.Point(628, 24);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnAlunos.TabIndex = 10;
            this.btnAlunos.Text = "Incluir";
            this.btnAlunos.UseVisualStyleBackColor = true;
            this.btnAlunos.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnLimparAlunos
            // 
            this.btnLimparAlunos.Location = new System.Drawing.Point(628, 135);
            this.btnLimparAlunos.Name = "btnLimparAlunos";
            this.btnLimparAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnLimparAlunos.TabIndex = 11;
            this.btnLimparAlunos.Text = "Limpar";
            this.btnLimparAlunos.UseVisualStyleBackColor = true;
            this.btnLimparAlunos.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterarAlunos
            // 
            this.btnAlterarAlunos.Location = new System.Drawing.Point(628, 97);
            this.btnAlterarAlunos.Name = "btnAlterarAlunos";
            this.btnAlterarAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarAlunos.TabIndex = 12;
            this.btnAlterarAlunos.Text = "Alterar";
            this.btnAlterarAlunos.UseVisualStyleBackColor = true;
            this.btnAlterarAlunos.Click += new System.EventHandler(this.btnAlterarAlunos_Click);
            // 
            // btnExcluirAlunos
            // 
            this.btnExcluirAlunos.Location = new System.Drawing.Point(628, 62);
            this.btnExcluirAlunos.Name = "btnExcluirAlunos";
            this.btnExcluirAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirAlunos.TabIndex = 13;
            this.btnExcluirAlunos.Text = "Excluir";
            this.btnExcluirAlunos.UseVisualStyleBackColor = true;
            this.btnExcluirAlunos.Click += new System.EventHandler(this.btnExcluirAlunos_Click);
            // 
            // btnConsGeralAlunos
            // 
            this.btnConsGeralAlunos.Location = new System.Drawing.Point(628, 173);
            this.btnConsGeralAlunos.Name = "btnConsGeralAlunos";
            this.btnConsGeralAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnConsGeralAlunos.TabIndex = 14;
            this.btnConsGeralAlunos.Text = "ConsGeral";
            this.btnConsGeralAlunos.UseVisualStyleBackColor = true;
            this.btnConsGeralAlunos.Click += new System.EventHandler(this.btnConsGeral_Click);
            // 
            // btnConsIndiAlunos
            // 
            this.btnConsIndiAlunos.Location = new System.Drawing.Point(628, 211);
            this.btnConsIndiAlunos.Name = "btnConsIndiAlunos";
            this.btnConsIndiAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnConsIndiAlunos.TabIndex = 15;
            this.btnConsIndiAlunos.Text = "ConsIndi";
            this.btnConsIndiAlunos.UseVisualStyleBackColor = true;
            this.btnConsIndiAlunos.Click += new System.EventHandler(this.btnConsIndi_Click);
            // 
            // ptbFoto
            // 
            this.ptbFoto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ptbFoto.Location = new System.Drawing.Point(618, 261);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(104, 87);
            this.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFoto.TabIndex = 16;
            this.ptbFoto.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(628, 379);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 23);
            this.btnFoto.TabIndex = 17;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(241, 211);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(246, 86);
            this.dgvAlunos.TabIndex = 18;
            this.dgvAlunos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAlunos_MouseClick);
            // 
            // frmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.ptbFoto);
            this.Controls.Add(this.btnConsIndiAlunos);
            this.Controls.Add(this.btnConsGeralAlunos);
            this.Controls.Add(this.btnExcluirAlunos);
            this.Controls.Add(this.btnAlterarAlunos);
            this.Controls.Add(this.btnLimparAlunos);
            this.Controls.Add(this.btnAlunos);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAlunos";
            this.Text = "frmAlunos";
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnLimparAlunos;
        private System.Windows.Forms.Button btnAlterarAlunos;
        private System.Windows.Forms.Button btnExcluirAlunos;
        private System.Windows.Forms.Button btnConsGeralAlunos;
        private System.Windows.Forms.Button btnConsIndiAlunos;
        private System.Windows.Forms.PictureBox ptbFoto;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.DataGridView dgvAlunos;
    }
}