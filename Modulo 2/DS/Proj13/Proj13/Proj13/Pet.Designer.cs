namespace Proj13
{
    partial class Pet
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
            this.txtCpfTutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.rdbMacho = new System.Windows.Forms.RadioButton();
            this.rdbFemea = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.ptbPet = new System.Windows.Forms.PictureBox();
            this.Incluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFoto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomePet = new System.Windows.Forms.TextBox();
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesqRapP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDPet = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF Tutor:";
            // 
            // txtCpfTutor
            // 
            this.txtCpfTutor.Location = new System.Drawing.Point(368, 46);
            this.txtCpfTutor.Name = "txtCpfTutor";
            this.txtCpfTutor.Size = new System.Drawing.Size(100, 20);
            this.txtCpfTutor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nascimento:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Location = new System.Drawing.Point(368, 86);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(200, 20);
            this.dtpNascimento.TabIndex = 3;
            // 
            // rdbMacho
            // 
            this.rdbMacho.AutoSize = true;
            this.rdbMacho.Location = new System.Drawing.Point(8, 19);
            this.rdbMacho.Name = "rdbMacho";
            this.rdbMacho.Size = new System.Drawing.Size(58, 17);
            this.rdbMacho.TabIndex = 5;
            this.rdbMacho.TabStop = true;
            this.rdbMacho.Text = "Macho";
            this.rdbMacho.UseVisualStyleBackColor = true;
            // 
            // rdbFemea
            // 
            this.rdbFemea.AutoSize = true;
            this.rdbFemea.Location = new System.Drawing.Point(72, 19);
            this.rdbFemea.Name = "rdbFemea";
            this.rdbFemea.Size = new System.Drawing.Size(57, 17);
            this.rdbFemea.TabIndex = 6;
            this.rdbFemea.TabStop = true;
            this.rdbFemea.Text = "Fêmea";
            this.rdbFemea.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMacho);
            this.groupBox1.Controls.Add(this.rdbFemea);
            this.groupBox1.Location = new System.Drawing.Point(299, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 55);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gênero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Raça:";
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(368, 199);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(100, 20);
            this.txtRaca.TabIndex = 9;
            // 
            // ptbPet
            // 
            this.ptbPet.Location = new System.Drawing.Point(564, 163);
            this.ptbPet.Name = "ptbPet";
            this.ptbPet.Size = new System.Drawing.Size(113, 113);
            this.ptbPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPet.TabIndex = 10;
            this.ptbPet.TabStop = false;
            // 
            // Incluir
            // 
            this.Incluir.Location = new System.Drawing.Point(307, 335);
            this.Incluir.Name = "Incluir";
            this.Incluir.Size = new System.Drawing.Size(75, 23);
            this.Incluir.TabIndex = 11;
            this.Incluir.Text = "Incluir";
            this.Incluir.UseVisualStyleBackColor = true;
            this.Incluir.Click += new System.EventHandler(this.Incluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(393, 335);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(353, 364);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(586, 296);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 23);
            this.btnFoto.TabIndex = 15;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nome Pet:";
            // 
            // txtNomePet
            // 
            this.txtNomePet.Location = new System.Drawing.Point(368, 241);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.Size = new System.Drawing.Size(100, 20);
            this.txtNomePet.TabIndex = 17;
            // 
            // cboEspecie
            // 
            this.cboEspecie.FormattingEnabled = true;
            this.cboEspecie.Items.AddRange(new object[] {
            "Gato",
            "Cachorro"});
            this.cboEspecie.Location = new System.Drawing.Point(368, 279);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(100, 21);
            this.cboEspecie.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Espécie:";
            // 
            // btnPesqRapP
            // 
            this.btnPesqRapP.Location = new System.Drawing.Point(29, 137);
            this.btnPesqRapP.Name = "btnPesqRapP";
            this.btnPesqRapP.Size = new System.Drawing.Size(98, 23);
            this.btnPesqRapP.TabIndex = 20;
            this.btnPesqRapP.Text = "Pesquisa Rápida";
            this.btnPesqRapP.UseVisualStyleBackColor = true;
            this.btnPesqRapP.Click += new System.EventHandler(this.btnPesqRapP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "ID do Pet:";
            // 
            // txtIDPet
            // 
            this.txtIDPet.Location = new System.Drawing.Point(74, 59);
            this.txtIDPet.Name = "txtIDPet";
            this.txtIDPet.Size = new System.Drawing.Size(100, 20);
            this.txtIDPet.TabIndex = 22;
            // 
            // Pet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIDPet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPesqRapP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboEspecie);
            this.Controls.Add(this.txtNomePet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.Incluir);
            this.Controls.Add(this.ptbPet);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCpfTutor);
            this.Controls.Add(this.label1);
            this.Name = "Pet";
            this.Text = "Pet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCpfTutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.RadioButton rdbMacho;
        private System.Windows.Forms.RadioButton rdbFemea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.PictureBox ptbPet;
        private System.Windows.Forms.Button Incluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomePet;
        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesqRapP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDPet;
    }
}