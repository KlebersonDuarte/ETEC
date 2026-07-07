namespace EX33_PRL_261125
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbFigura = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha a opção de imagem";
            // 
            // cbFigura
            // 
            this.cbFigura.FormattingEnabled = true;
            this.cbFigura.Items.AddRange(new object[] {
            "Círculo",
            "Quadrado",
            "Elipse",
            "Pizza",
            "Retângulo",
            "Círculo Cheio",
            "Quadrado Cheio",
            "Elipse Cheio",
            "Pizza Cheia",
            "Retângulo Chieo"});
            this.cbFigura.Location = new System.Drawing.Point(159, 1);
            this.cbFigura.Name = "cbFigura";
            this.cbFigura.Size = new System.Drawing.Size(129, 21);
            this.cbFigura.TabIndex = 1;
            this.cbFigura.SelectedIndexChanged += new System.EventHandler(this.cbFigura_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.cbFigura);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EX33_PRL_261125";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFigura;
    }
}

