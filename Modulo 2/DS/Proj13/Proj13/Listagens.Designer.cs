namespace Proj13
{
    partial class Listagens
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
            this.dgvListagens = new System.Windows.Forms.DataGridView();
            this.btnTutor = new System.Windows.Forms.Button();
            this.btnPetNasc = new System.Windows.Forms.Button();
            this.btnPetSem = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.cboTipoServ = new System.Windows.Forms.ComboBox();
            this.dtpDataServ = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPetFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagens)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListagens
            // 
            this.dgvListagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListagens.Location = new System.Drawing.Point(332, 224);
            this.dgvListagens.Name = "dgvListagens";
            this.dgvListagens.Size = new System.Drawing.Size(420, 189);
            this.dgvListagens.TabIndex = 0;
            // 
            // btnTutor
            // 
            this.btnTutor.Location = new System.Drawing.Point(104, 23);
            this.btnTutor.Name = "btnTutor";
            this.btnTutor.Size = new System.Drawing.Size(75, 23);
            this.btnTutor.TabIndex = 1;
            this.btnTutor.Text = "Buscar";
            this.btnTutor.UseVisualStyleBackColor = true;
            this.btnTutor.Click += new System.EventHandler(this.btnTutor_Click);
            // 
            // btnPetNasc
            // 
            this.btnPetNasc.Location = new System.Drawing.Point(135, 102);
            this.btnPetNasc.Name = "btnPetNasc";
            this.btnPetNasc.Size = new System.Drawing.Size(75, 23);
            this.btnPetNasc.TabIndex = 2;
            this.btnPetNasc.Text = "Buscar";
            this.btnPetNasc.UseVisualStyleBackColor = true;
            this.btnPetNasc.Click += new System.EventHandler(this.btnPetNasc_Click);
            // 
            // btnPetSem
            // 
            this.btnPetSem.Location = new System.Drawing.Point(135, 157);
            this.btnPetSem.Name = "btnPetSem";
            this.btnPetSem.Size = new System.Drawing.Size(75, 23);
            this.btnPetSem.TabIndex = 3;
            this.btnPetSem.Text = "Buscar";
            this.btnPetSem.UseVisualStyleBackColor = true;
            this.btnPetSem.Click += new System.EventHandler(this.btnPetSem_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.Location = new System.Drawing.Point(403, 16);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(75, 23);
            this.btnServicos.TabIndex = 4;
            this.btnServicos.Text = "Buscar";
            this.btnServicos.UseVisualStyleBackColor = true;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tutor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pet ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sem foto e espécie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Serviços";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Consulta";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(403, 91);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 12;
            this.btnConsulta.Text = "Buscar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // cboEspecie
            // 
            this.cboEspecie.FormattingEnabled = true;
            this.cboEspecie.Items.AddRange(new object[] {
            "Gato",
            "Cachorro"});
            this.cboEspecie.Location = new System.Drawing.Point(649, 12);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(121, 21);
            this.cboEspecie.TabIndex = 14;
            // 
            // cboTipoServ
            // 
            this.cboTipoServ.FormattingEnabled = true;
            this.cboTipoServ.Items.AddRange(new object[] {
            "Banho",
            "Tosa"});
            this.cboTipoServ.Location = new System.Drawing.Point(649, 72);
            this.cboTipoServ.Name = "cboTipoServ";
            this.cboTipoServ.Size = new System.Drawing.Size(121, 21);
            this.cboTipoServ.TabIndex = 15;
            // 
            // dtpDataServ
            // 
            this.dtpDataServ.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataServ.Location = new System.Drawing.Point(688, 138);
            this.dtpDataServ.Name = "dtpDataServ";
            this.dtpDataServ.Size = new System.Drawing.Size(82, 20);
            this.dtpDataServ.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Espécie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(563, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tipo de serviço";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(568, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Data do serviço";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ordem de Nasc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Filtro espécie";
            // 
            // btnPetFiltro
            // 
            this.btnPetFiltro.Location = new System.Drawing.Point(135, 213);
            this.btnPetFiltro.Name = "btnPetFiltro";
            this.btnPetFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnPetFiltro.TabIndex = 22;
            this.btnPetFiltro.Text = "Buscar";
            this.btnPetFiltro.UseVisualStyleBackColor = true;
            this.btnPetFiltro.Click += new System.EventHandler(this.btnPetFiltro_Click);
            // 
            // Listagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPetFiltro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDataServ);
            this.Controls.Add(this.cboTipoServ);
            this.Controls.Add(this.cboEspecie);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnServicos);
            this.Controls.Add(this.btnPetSem);
            this.Controls.Add(this.btnPetNasc);
            this.Controls.Add(this.btnTutor);
            this.Controls.Add(this.dgvListagens);
            this.Name = "Listagens";
            this.Text = "Listagens";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListagens;
        private System.Windows.Forms.Button btnTutor;
        private System.Windows.Forms.Button btnPetNasc;
        private System.Windows.Forms.Button btnPetSem;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.ComboBox cboTipoServ;
        private System.Windows.Forms.DateTimePicker dtpDataServ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPetFiltro;
    }
}