namespace Proj8
{
    partial class frmNotas
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
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbManha = new System.Windows.Forms.RadioButton();
            this.rdbTarde = new System.Windows.Forms.RadioButton();
            this.rdbNoite = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btnBoletim = new System.Windows.Forms.Button();
            this.lblBoletim = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(84, 13);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(369, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Items.AddRange(new object[] {
            "Ds",
            "Adm",
            "Logística",
            "Química",
            "Macatrônica"});
            this.cboCurso.Location = new System.Drawing.Point(84, 76);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(100, 21);
            this.cboCurso.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Curso";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNoite);
            this.groupBox1.Controls.Add(this.rdbTarde);
            this.groupBox1.Controls.Add(this.rdbManha);
            this.groupBox1.Location = new System.Drawing.Point(36, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período";
            // 
            // rdbManha
            // 
            this.rdbManha.AutoSize = true;
            this.rdbManha.Location = new System.Drawing.Point(10, 43);
            this.rdbManha.Name = "rdbManha";
            this.rdbManha.Size = new System.Drawing.Size(34, 17);
            this.rdbManha.TabIndex = 0;
            this.rdbManha.TabStop = true;
            this.rdbManha.Text = "M";
            this.rdbManha.UseVisualStyleBackColor = true;
            // 
            // rdbTarde
            // 
            this.rdbTarde.AutoSize = true;
            this.rdbTarde.Location = new System.Drawing.Point(108, 43);
            this.rdbTarde.Name = "rdbTarde";
            this.rdbTarde.Size = new System.Drawing.Size(32, 17);
            this.rdbTarde.TabIndex = 1;
            this.rdbTarde.TabStop = true;
            this.rdbTarde.Text = "T";
            this.rdbTarde.UseVisualStyleBackColor = true;
            // 
            // rdbNoite
            // 
            this.rdbNoite.AutoSize = true;
            this.rdbNoite.Location = new System.Drawing.Point(215, 43);
            this.rdbNoite.Name = "rdbNoite";
            this.rdbNoite.Size = new System.Drawing.Size(33, 17);
            this.rdbNoite.TabIndex = 2;
            this.rdbNoite.TabStop = true;
            this.rdbNoite.Text = "N";
            this.rdbNoite.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(36, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bimestre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "1°";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(49, 47);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(36, 20);
            this.txt1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "2°";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(146, 47);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(35, 20);
            this.txt2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "3°";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(225, 48);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(37, 20);
            this.txt3.TabIndex = 5;
            // 
            // btnBoletim
            // 
            this.btnBoletim.Location = new System.Drawing.Point(197, 415);
            this.btnBoletim.Name = "btnBoletim";
            this.btnBoletim.Size = new System.Drawing.Size(75, 23);
            this.btnBoletim.TabIndex = 8;
            this.btnBoletim.Text = "Boletim";
            this.btnBoletim.UseVisualStyleBackColor = true;
            this.btnBoletim.Click += new System.EventHandler(this.btnBoletim_Click);
            // 
            // lblBoletim
            // 
            this.lblBoletim.AutoSize = true;
            this.lblBoletim.Location = new System.Drawing.Point(539, 145);
            this.lblBoletim.Name = "lblBoletim";
            this.lblBoletim.Size = new System.Drawing.Size(16, 13);
            this.lblBoletim.TabIndex = 9;
            this.lblBoletim.Text = "...";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(539, 232);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 10;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblBoletim);
            this.Controls.Add(this.btnBoletim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label1);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNoite;
        private System.Windows.Forms.RadioButton rdbTarde;
        private System.Windows.Forms.RadioButton rdbManha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnBoletim;
        private System.Windows.Forms.Label lblBoletim;
        private System.Windows.Forms.Label lblResultado;
    }
}