namespace Adocao
{
    partial class frmAdotarcs
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 24);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 106);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 2;
            label2.Text = "Nome do Pet";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 163);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 4;
            label3.Text = "Espécie";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(85, 155);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 33);
            comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 218);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 6;
            label4.Text = "Variantes";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(98, 218);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(150, 33);
            comboBox2.TabIndex = 7;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(16, 42);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(78, 29);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masc";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(174, 42);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(44, 29);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "-";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(12, 273);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 106);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gênero";
            // 
            // button1
            // 
            button1.Location = new Point(503, 39);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(665, 43);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 12;
            button2.Text = "Deletar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(600, 85);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 13;
            button3.Text = "Pesquisar";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(428, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 24);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 15;
            label5.Text = "CPF";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(305, 21);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 16;
            // 
            // frmAdotarcs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "frmAdotarcs";
            Text = "frmAdotarcs";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBox3;
    }
}