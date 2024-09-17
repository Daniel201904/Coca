namespace Presentacion
{
    partial class Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BT_borrar = new System.Windows.Forms.Button();
            this.BT_cambiar = new System.Windows.Forms.Button();
            this.BT_ingresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CB_estado = new System.Windows.Forms.ComboBox();
            this.TXT_final = new System.Windows.Forms.TextBox();
            this.TXT_inicio = new System.Windows.Forms.TextBox();
            this.CB_nivel = new System.Windows.Forms.ComboBox();
            this.TXT_estudio = new System.Windows.Forms.TextBox();
            this.TXT_centro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_nivel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(652, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(311, 279);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // BT_borrar
            // 
            this.BT_borrar.BackColor = System.Drawing.Color.Black;
            this.BT_borrar.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BT_borrar.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_borrar.Location = new System.Drawing.Point(480, 221);
            this.BT_borrar.Name = "BT_borrar";
            this.BT_borrar.Size = new System.Drawing.Size(128, 40);
            this.BT_borrar.TabIndex = 55;
            this.BT_borrar.Text = "Borrar";
            this.BT_borrar.UseVisualStyleBackColor = false;
            this.BT_borrar.Click += new System.EventHandler(this.BT_borrar_Click);
            // 
            // BT_cambiar
            // 
            this.BT_cambiar.BackColor = System.Drawing.Color.Black;
            this.BT_cambiar.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BT_cambiar.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_cambiar.Location = new System.Drawing.Point(463, 170);
            this.BT_cambiar.Name = "BT_cambiar";
            this.BT_cambiar.Size = new System.Drawing.Size(165, 39);
            this.BT_cambiar.TabIndex = 54;
            this.BT_cambiar.Text = "Modificar";
            this.BT_cambiar.UseVisualStyleBackColor = false;
            this.BT_cambiar.Click += new System.EventHandler(this.BT_cambiar_Click);
            // 
            // BT_ingresar
            // 
            this.BT_ingresar.BackColor = System.Drawing.Color.Black;
            this.BT_ingresar.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BT_ingresar.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_ingresar.Location = new System.Drawing.Point(480, 118);
            this.BT_ingresar.Name = "BT_ingresar";
            this.BT_ingresar.Size = new System.Drawing.Size(128, 42);
            this.BT_ingresar.TabIndex = 53;
            this.BT_ingresar.Text = "Añadir";
            this.BT_ingresar.UseVisualStyleBackColor = false;
            this.BT_ingresar.Click += new System.EventHandler(this.BT_ingresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(935, 185);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CB_estado
            // 
            this.CB_estado.FormattingEnabled = true;
            this.CB_estado.Items.AddRange(new object[] {
            "Culminado",
            "Curzando",
            "Aplazado "});
            this.CB_estado.Location = new System.Drawing.Point(232, 235);
            this.CB_estado.Name = "CB_estado";
            this.CB_estado.Size = new System.Drawing.Size(207, 24);
            this.CB_estado.TabIndex = 51;
            // 
            // TXT_final
            // 
            this.TXT_final.Location = new System.Drawing.Point(232, 269);
            this.TXT_final.Name = "TXT_final";
            this.TXT_final.Size = new System.Drawing.Size(207, 22);
            this.TXT_final.TabIndex = 50;
            // 
            // TXT_inicio
            // 
            this.TXT_inicio.Location = new System.Drawing.Point(232, 204);
            this.TXT_inicio.Name = "TXT_inicio";
            this.TXT_inicio.Size = new System.Drawing.Size(207, 22);
            this.TXT_inicio.TabIndex = 49;
            // 
            // CB_nivel
            // 
            this.CB_nivel.FormattingEnabled = true;
            this.CB_nivel.Items.AddRange(new object[] {
            "Preescolar",
            "Basica primaria (1°- 5°)",
            "Basica secundaria (6°- 9°)",
            "Media (10° - 11°)",
            "Tecnico laboral",
            "Tecnico profesional",
            "Tecnologia ",
            "Universitaria",
            "Especializacion",
            "Maestria ",
            "Doctorado"});
            this.CB_nivel.Location = new System.Drawing.Point(232, 164);
            this.CB_nivel.Name = "CB_nivel";
            this.CB_nivel.Size = new System.Drawing.Size(207, 24);
            this.CB_nivel.TabIndex = 48;
            // 
            // TXT_estudio
            // 
            this.TXT_estudio.Location = new System.Drawing.Point(232, 130);
            this.TXT_estudio.Name = "TXT_estudio";
            this.TXT_estudio.Size = new System.Drawing.Size(207, 22);
            this.TXT_estudio.TabIndex = 47;
            // 
            // TXT_centro
            // 
            this.TXT_centro.Location = new System.Drawing.Point(232, 96);
            this.TXT_centro.Name = "TXT_centro";
            this.TXT_centro.Size = new System.Drawing.Size(207, 22);
            this.TXT_centro.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Fecha de finalizacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Fecha de inicio";
            // 
            // TXT_nivel
            // 
            this.TXT_nivel.AutoSize = true;
            this.TXT_nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_nivel.Location = new System.Drawing.Point(34, 170);
            this.TXT_nivel.Name = "TXT_nivel";
            this.TXT_nivel.Size = new System.Drawing.Size(45, 18);
            this.TXT_nivel.TabIndex = 42;
            this.TXT_nivel.Text = "Nivel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nombre del estudio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Centro educativo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 46);
            this.label1.TabIndex = 39;
            this.label1.Text = "Cursos Realizados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(983, 525);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 525);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BT_borrar);
            this.Controls.Add(this.BT_cambiar);
            this.Controls.Add(this.BT_ingresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CB_estado);
            this.Controls.Add(this.TXT_final);
            this.Controls.Add(this.TXT_inicio);
            this.Controls.Add(this.CB_nivel);
            this.Controls.Add(this.TXT_estudio);
            this.Controls.Add(this.TXT_centro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_nivel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Cursos";
            this.Text = "Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BT_borrar;
        private System.Windows.Forms.Button BT_cambiar;
        private System.Windows.Forms.Button BT_ingresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CB_estado;
        private System.Windows.Forms.TextBox TXT_final;
        private System.Windows.Forms.TextBox TXT_inicio;
        private System.Windows.Forms.ComboBox CB_nivel;
        private System.Windows.Forms.TextBox TXT_estudio;
        private System.Windows.Forms.TextBox TXT_centro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TXT_nivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}