namespace Proj3
{
    partial class Form1
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
            this.btnBoletim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtBim1 = new System.Windows.Forms.TextBox();
            this.txtBim2 = new System.Windows.Forms.TextBox();
            this.txtBim3 = new System.Windows.Forms.TextBox();
            this.cbbCurso = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbN = new System.Windows.Forms.RadioButton();
            this.rdbT = new System.Windows.Forms.RadioButton();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.lblBoletim = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBoletim
            // 
            this.btnBoletim.Location = new System.Drawing.Point(220, 501);
            this.btnBoletim.Name = "btnBoletim";
            this.btnBoletim.Size = new System.Drawing.Size(75, 23);
            this.btnBoletim.TabIndex = 0;
            this.btnBoletim.Text = "Boletim";
            this.btnBoletim.UseVisualStyleBackColor = true;
            this.btnBoletim.Click += new System.EventHandler(this.btnBoletim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bim1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bim2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bim3";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(54, 27);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(54, 123);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtBim1
            // 
            this.txtBim1.Location = new System.Drawing.Point(54, 402);
            this.txtBim1.Name = "txtBim1";
            this.txtBim1.Size = new System.Drawing.Size(100, 20);
            this.txtBim1.TabIndex = 10;
            // 
            // txtBim2
            // 
            this.txtBim2.Location = new System.Drawing.Point(261, 402);
            this.txtBim2.Name = "txtBim2";
            this.txtBim2.Size = new System.Drawing.Size(100, 20);
            this.txtBim2.TabIndex = 11;
            // 
            // txtBim3
            // 
            this.txtBim3.Location = new System.Drawing.Point(483, 402);
            this.txtBim3.Name = "txtBim3";
            this.txtBim3.Size = new System.Drawing.Size(100, 20);
            this.txtBim3.TabIndex = 12;
            // 
            // cbbCurso
            // 
            this.cbbCurso.FormattingEnabled = true;
            this.cbbCurso.Items.AddRange(new object[] {
            "Química",
            "Ds",
            "Adm"});
            this.cbbCurso.Location = new System.Drawing.Point(54, 222);
            this.cbbCurso.Name = "cbbCurso";
            this.cbbCurso.Size = new System.Drawing.Size(121, 21);
            this.cbbCurso.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbN);
            this.groupBox1.Controls.Add(this.rdbT);
            this.groupBox1.Controls.Add(this.rdbM);
            this.groupBox1.Location = new System.Drawing.Point(29, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período";
            // 
            // rdbN
            // 
            this.rdbN.AutoSize = true;
            this.rdbN.Location = new System.Drawing.Point(0, 68);
            this.rdbN.Name = "rdbN";
            this.rdbN.Size = new System.Drawing.Size(33, 17);
            this.rdbN.TabIndex = 2;
            this.rdbN.TabStop = true;
            this.rdbN.Text = "N";
            this.rdbN.UseVisualStyleBackColor = true;
            // 
            // rdbT
            // 
            this.rdbT.AutoSize = true;
            this.rdbT.Location = new System.Drawing.Point(0, 45);
            this.rdbT.Name = "rdbT";
            this.rdbT.Size = new System.Drawing.Size(32, 17);
            this.rdbT.TabIndex = 1;
            this.rdbT.TabStop = true;
            this.rdbT.Text = "T";
            this.rdbT.UseVisualStyleBackColor = true;
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(0, 21);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(34, 17);
            this.rdbM.TabIndex = 0;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "M";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // lblBoletim
            // 
            this.lblBoletim.AutoSize = true;
            this.lblBoletim.Location = new System.Drawing.Point(371, 72);
            this.lblBoletim.Name = "lblBoletim";
            this.lblBoletim.Size = new System.Drawing.Size(16, 13);
            this.lblBoletim.TabIndex = 16;
            this.lblBoletim.Text = "...";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultado.Location = new System.Drawing.Point(419, 190);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 17;
            this.lblResultado.Text = "Resultado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Murilo Gomes Cordeiro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(370, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kleberson Duarte Santos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(374, 519);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Enzo Feitosa Gaeta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 541);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblBoletim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbCurso);
            this.Controls.Add(this.txtBim3);
            this.Controls.Add(this.txtBim2);
            this.Controls.Add(this.txtBim1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBoletim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoletim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtBim1;
        private System.Windows.Forms.TextBox txtBim2;
        private System.Windows.Forms.TextBox txtBim3;
        private System.Windows.Forms.ComboBox cbbCurso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbN;
        private System.Windows.Forms.RadioButton rdbT;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.Label lblBoletim;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

