namespace EX26_REPETIDORES_VISUAL_061125
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
            this.BtnPara = new System.Windows.Forms.Button();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.Lista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnEnquanto
            // 
            this.BtnEnquanto.Location = new System.Drawing.Point(12, 12);
            this.BtnEnquanto.Name = "BtnEnquanto";
            this.BtnEnquanto.Size = new System.Drawing.Size(75, 23);
            this.BtnEnquanto.TabIndex = 0;
            this.BtnEnquanto.Text = "Enquanto";
            this.BtnEnquanto.UseVisualStyleBackColor = true;
            this.BtnEnquanto.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnPara
            // 
            this.BtnPara.Location = new System.Drawing.Point(713, 12);
            this.BtnPara.Name = "BtnPara";
            this.BtnPara.Size = new System.Drawing.Size(75, 23);
            this.BtnPara.TabIndex = 1;
            this.BtnPara.Text = "Para";
            this.BtnPara.UseVisualStyleBackColor = true;
            this.BtnPara.Click += new System.EventHandler(this.BtnPara_Click);
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(347, 12);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(100, 20);
            this.txtTamanho.TabIndex = 2;
            this.txtTamanho.TextChanged += new System.EventHandler(this.txtTamanho_TextChanged);
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(146, 121);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(476, 251);
            this.Lista.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.BtnPara);
            this.Controls.Add(this.BtnEnquanto);
            this.Name = "Form1";
            this.Text = "Ex26 Repetidores Visual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEnquanto;
        private System.Windows.Forms.Button BtnPara;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.ListBox Lista;
    }
}

