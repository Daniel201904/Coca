namespace Presentacion
{
    partial class Experiencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Experiencia));
            this.BT_borrar = new System.Windows.Forms.Button();
            this.BT_cambiar = new System.Windows.Forms.Button();
            this.BT_ingresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TXT_telefono2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_jefe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_area = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_cargo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_empresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_borrar
            // 
            this.BT_borrar.BackColor = System.Drawing.Color.Black;
            this.BT_borrar.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BT_borrar.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_borrar.Location = new System.Drawing.Point(542, 206);
            this.BT_borrar.Name = "BT_borrar";
            this.BT_borrar.Size = new System.Drawing.Size(128, 40);
            this.BT_borrar.TabIndex = 31;
            this.BT_borrar.Text = "Borrar";
            this.BT_borrar.UseVisualStyleBackColor = false;
            this.BT_borrar.Click += new System.EventHandler(this.BT_borrar_Click);
            // 
            // BT_cambiar
            // 
            this.BT_cambiar.BackColor = System.Drawing.Color.Black;
            this.BT_cambiar.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BT_cambiar.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_cambiar.Location = new System.Drawing.Point(527, 161);
            this.BT_cambiar.Name = "BT_cambiar";
            this.BT_cambiar.Size = new System.Drawing.Size(165, 39);
            this.BT_cambiar.TabIndex = 30;
            this.BT_cambiar.Text = "Modificar";
            this.BT_cambiar.UseVisualStyleBackColor = false;
            this.BT_cambiar.Click += new System.EventHandler(this.BT_cambiar_Click);
            // 
            // BT_ingresar
            // 
            this.BT_ingresar.BackColor = System.Drawing.Color.Black;
            this.BT_ingresar.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BT_ingresar.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_ingresar.Location = new System.Drawing.Point(542, 113);
            this.BT_ingresar.Name = "BT_ingresar";
            this.BT_ingresar.Size = new System.Drawing.Size(128, 42);
            this.BT_ingresar.TabIndex = 29;
            this.BT_ingresar.Text = "Añadir";
            this.BT_ingresar.UseVisualStyleBackColor = false;
            this.BT_ingresar.Click += new System.EventHandler(this.BT_ingresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(915, 182);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TXT_telefono2
            // 
            this.TXT_telefono2.Location = new System.Drawing.Point(274, 263);
            this.TXT_telefono2.Name = "TXT_telefono2";
            this.TXT_telefono2.Size = new System.Drawing.Size(207, 22);
            this.TXT_telefono2.TabIndex = 27;
            this.TXT_telefono2.TextChanged += new System.EventHandler(this.TXT_telefono2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Telefono";
            // 
            // TXT_jefe
            // 
            this.TXT_jefe.Location = new System.Drawing.Point(274, 216);
            this.TXT_jefe.Name = "TXT_jefe";
            this.TXT_jefe.Size = new System.Drawing.Size(207, 22);
            this.TXT_jefe.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Jefe directo";
            // 
            // TXT_area
            // 
            this.TXT_area.Location = new System.Drawing.Point(274, 171);
            this.TXT_area.Name = "TXT_area";
            this.TXT_area.Size = new System.Drawing.Size(207, 22);
            this.TXT_area.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Area de la empresa";
            // 
            // TXT_cargo
            // 
            this.TXT_cargo.BackColor = System.Drawing.SystemColors.Window;
            this.TXT_cargo.Location = new System.Drawing.Point(274, 123);
            this.TXT_cargo.Name = "TXT_cargo";
            this.TXT_cargo.Size = new System.Drawing.Size(207, 22);
            this.TXT_cargo.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cargo";
            // 
            // TXT_empresa
            // 
            this.TXT_empresa.Location = new System.Drawing.Point(274, 78);
            this.TXT_empresa.Name = "TXT_empresa";
            this.TXT_empresa.Size = new System.Drawing.Size(207, 22);
            this.TXT_empresa.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre de la empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "Experiencia Laboral";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(967, 523);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(724, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Experiencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 525);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BT_borrar);
            this.Controls.Add(this.BT_cambiar);
            this.Controls.Add(this.BT_ingresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TXT_telefono2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXT_jefe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_area);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_cargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_empresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Experiencia";
            this.Text = "Experiencia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_borrar;
        private System.Windows.Forms.Button BT_cambiar;
        private System.Windows.Forms.Button BT_ingresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TXT_telefono2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_jefe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_area;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_cargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_empresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}