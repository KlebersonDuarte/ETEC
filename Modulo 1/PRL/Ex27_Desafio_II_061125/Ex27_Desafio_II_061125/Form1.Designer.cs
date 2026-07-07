namespace Ex27_Desafio_II_061125
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnEnquanto = new System.Windows.Forms.Button();
            this.BtnLImpar = new System.Windows.Forms.Button();
            this.BtnPara = new System.Windows.Forms.Button();
            this.ListaPar = new System.Windows.Forms.ListBox();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.ListaImpar = new System.Windows.Forms.ListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEnquanto
            // 
            this.BtnEnquanto.Location = new System.Drawing.Point(12, 331);
            this.BtnEnquanto.Name = "BtnEnquanto";
            this.BtnEnquanto.Size = new System.Drawing.Size(75, 23);
            this.BtnEnquanto.TabIndex = 2;
            this.BtnEnquanto.Text = "Enquanto";
            this.BtnEnquanto.UseVisualStyleBackColor = true;
            this.BtnEnquanto.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnLImpar
            // 
            this.BtnLImpar.Location = new System.Drawing.Point(143, 331);
            this.BtnLImpar.Name = "BtnLImpar";
            this.BtnLImpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLImpar.TabIndex = 3;
            this.BtnLImpar.Text = "Limpar";
            this.BtnLImpar.UseVisualStyleBackColor = true;
            this.BtnLImpar.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnPara
            // 
            this.BtnPara.Location = new System.Drawing.Point(277, 331);
            this.BtnPara.Name = "BtnPara";
            this.BtnPara.Size = new System.Drawing.Size(75, 23);
            this.BtnPara.TabIndex = 4;
            this.BtnPara.Text = "Para";
            this.BtnPara.UseVisualStyleBackColor = true;
            this.BtnPara.Click += new System.EventHandler(this.BtnPara_Click);
            // 
            // ListaPar
            // 
            this.ListaPar.FormattingEnabled = true;
            this.ListaPar.Location = new System.Drawing.Point(12, 61);
            this.ListaPar.Name = "ListaPar";
            this.ListaPar.Size = new System.Drawing.Size(150, 264);
            this.ListaPar.TabIndex = 5;
            this.ListaPar.SelectedIndexChanged += new System.EventHandler(this.ListaPar_SelectedIndexChanged);
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(127, 360);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(113, 20);
            this.txtTamanho.TabIndex = 6;
            this.txtTamanho.TextChanged += new System.EventHandler(this.txtTamanho_TextChanged);
            // 
            // ListaImpar
            // 
            this.ListaImpar.FormattingEnabled = true;
            this.ListaImpar.Location = new System.Drawing.Point(202, 61);
            this.ListaImpar.Name = "ListaImpar";
            this.ListaImpar.Size = new System.Drawing.Size(150, 264);
            this.ListaImpar.TabIndex = 7;
            this.ListaImpar.SelectedIndexChanged += new System.EventHandler(this.ListaImpar_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(26, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Par:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Impar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ListaImpar);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.ListaPar);
            this.Controls.Add(this.BtnPara);
            this.Controls.Add(this.BtnLImpar);
            this.Controls.Add(this.BtnEnquanto);
            this.Name = "Form1";
            this.Text = "Ex27 Contador Par Impar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnEnquanto;
        private System.Windows.Forms.Button BtnLImpar;
        private System.Windows.Forms.Button BtnPara;
        private System.Windows.Forms.ListBox ListaPar;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.ListBox ListaImpar;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
    }
}

