namespace Presentacion
{
    partial class Examenes_Medicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Examenes_Medicos));
            this.BT_borrar = new System.Windows.Forms.Button();
            this.BT_cambiar = new System.Windows.Forms.Button();
            this.BT_ingresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TXT_lesiones = new System.Windows.Forms.TextBox();
            this.TXT_alergia = new System.Windows.Forms.TextBox();
            this.TXT_medicamentos = new System.Windows.Forms.TextBox();
            this.TXT_cirugia = new System.Windows.Forms.TextBox();
            this.TXT_cronica = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_borrar
            // 
            this.BT_borrar.BackColor = System.Drawing.Color.Black;
            this.BT_borrar.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BT_borrar.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_borrar.Location = new System.Drawing.Point(756, 336);
            this.BT_borrar.Name = "BT_borrar";
            this.BT_borrar.Size = new System.Drawing.Size(128, 42);
            this.BT_borrar.TabIndex = 35;
            this.BT_borrar.Text = "Borrar";
            this.BT_borrar.UseVisualStyleBackColor = false;
            this.BT_borrar.Click += new System.EventHandler(this.BT_borrar_Click);
            // 
            // BT_cambiar
            // 
            this.BT_cambiar.BackColor = System.Drawing.Color.Black;
            this.BT_cambiar.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BT_cambiar.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_cambiar.Location = new System.Drawing.Point(674, 399);
            this.BT_cambiar.Name = "BT_cambiar";
            this.BT_cambiar.Size = new System.Drawing.Size(165, 39);
            this.BT_cambiar.TabIndex = 34;
            this.BT_cambiar.Text = "Modificar";
            this.BT_cambiar.UseVisualStyleBackColor = false;
            this.BT_cambiar.Click += new System.EventHandler(this.BT_cambiar_Click);
            // 
            // BT_ingresar
            // 
            this.BT_ingresar.BackColor = System.Drawing.Color.Black;
            this.BT_ingresar.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BT_ingresar.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_ingresar.Location = new System.Drawing.Point(622, 336);
            this.BT_ingresar.Name = "BT_ingresar";
            this.BT_ingresar.Size = new System.Drawing.Size(128, 42);
            this.BT_ingresar.TabIndex = 33;
            this.BT_ingresar.Text = "Añadir";
            this.BT_ingresar.UseVisualStyleBackColor = false;
            this.BT_ingresar.Click += new System.EventHandler(this.BT_ingresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 177);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TXT_lesiones
            // 
            this.TXT_lesiones.Location = new System.Drawing.Point(737, 266);
            this.TXT_lesiones.Name = "TXT_lesiones";
            this.TXT_lesiones.Size = new System.Drawing.Size(207, 22);
            this.TXT_lesiones.TabIndex = 31;
            // 
            // TXT_alergia
            // 
            this.TXT_alergia.Location = new System.Drawing.Point(737, 228);
            this.TXT_alergia.Name = "TXT_alergia";
            this.TXT_alergia.Size = new System.Drawing.Size(207, 22);
            this.TXT_alergia.TabIndex = 30;
            // 
            // TXT_medicamentos
            // 
            this.TXT_medicamentos.Location = new System.Drawing.Point(737, 188);
            this.TXT_medicamentos.Name = "TXT_medicamentos";
            this.TXT_medicamentos.Size = new System.Drawing.Size(207, 22);
            this.TXT_medicamentos.TabIndex = 29;
            // 
            // TXT_cirugia
            // 
            this.TXT_cirugia.Location = new System.Drawing.Point(737, 151);
            this.TXT_cirugia.Name = "TXT_cirugia";
            this.TXT_cirugia.Size = new System.Drawing.Size(207, 22);
            this.TXT_cirugia.TabIndex = 28;
            // 
            // TXT_cronica
            // 
            this.TXT_cronica.Location = new System.Drawing.Point(737, 113);
            this.TXT_cronica.Name = "TXT_cronica";
            this.TXT_cronica.Size = new System.Drawing.Size(207, 22);
            this.TXT_cronica.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(400, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "¿Ha tenido lesiones graves?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "¿Es alergico ha algun medicamento?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "¿Estas tomando medicamentos?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "¿Ha tenido alguna cirugia?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "¿Padece de una enfermedad cronica?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 46);
            this.label1.TabIndex = 21;
            this.label1.Text = "Examenes Medicos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 527);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 261);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // Examenes_Medicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 525);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BT_borrar);
            this.Controls.Add(this.BT_cambiar);
            this.Controls.Add(this.BT_ingresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TXT_lesiones);
            this.Controls.Add(this.TXT_alergia);
            this.Controls.Add(this.TXT_medicamentos);
            this.Controls.Add(this.TXT_cirugia);
            this.Controls.Add(this.TXT_cronica);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Examenes_Medicos";
            this.Text = "Examenes_Medicos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_borrar;
        private System.Windows.Forms.Button BT_cambiar;
        private System.Windows.Forms.Button BT_ingresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TXT_lesiones;
        private System.Windows.Forms.TextBox TXT_alergia;
        private System.Windows.Forms.TextBox TXT_medicamentos;
        private System.Windows.Forms.TextBox TXT_cirugia;
        private System.Windows.Forms.TextBox TXT_cronica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}