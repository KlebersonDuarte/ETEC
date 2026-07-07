namespace Proj1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnEnviar = new Button();
            btnCalcular = new Button();
            txtMatricula = new TextBox();
            txtNome = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(23, 106);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Matrícula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Fuchsia;
            label2.Location = new Point(23, 154);
            label2.Name = "label2";
            label2.Size = new Size(39, 13);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(36, 217);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(117, 217);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(92, 104);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(91, 154);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Fuchsia;
            label3.Location = new Point(69, 38);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 6;
            label3.Text = "Cadastro Aluno";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(236, 304);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(txtMatricula);
            Controls.Add(btnCalcular);
            Controls.Add(btnEnviar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnEnviar;
        private Button btnCalcular;
        private TextBox txtMatricula;
        private TextBox txtNome;
        private Label label3;
    }
}
