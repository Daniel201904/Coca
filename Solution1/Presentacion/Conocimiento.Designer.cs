namespace Presentacion
{
    partial class Conocimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conocimiento));
            this.BT_cambiar = new System.Windows.Forms.Button();
            this.BT_borrar = new System.Windows.Forms.Button();
            this.BT_ingresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TXT_salario = new System.Windows.Forms.TextBox();
            this.CB_programas = new System.Windows.Forms.ComboBox();
            this.TXT_idioma = new System.Windows.Forms.TextBox();
            this.TXT_puesto = new System.Windows.Forms.TextBox();
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
            // BT_cambiar
            // 
            this.BT_cambiar.BackColor = System.Drawing.Color.Black;
            this.BT_cambiar.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BT_cambiar.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_cambiar.Location = new System.Drawing.Point(676, 178);
            this.BT_cambiar.Name = "BT_cambiar";
            this.BT_cambiar.Size = new System.Drawing.Size(165, 39);
            this.BT_cambiar.TabIndex = 35;
            this.BT_cambiar.Text = "Modificar";
            this.BT_cambiar.UseVisualStyleBackColor = false;
            this.BT_cambiar.Click += new System.EventHandler(this.BT_cambiar_Click);
            // 
            // BT_borrar
            // 
            this.BT_borrar.BackColor = System.Drawing.Color.Black;
            this.BT_borrar.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BT_borrar.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_borrar.Location = new System.Drawing.Point(693, 130);
            this.BT_borrar.Name = "BT_borrar";
            this.BT_borrar.Size = new System.Drawing.Size(128, 42);
            this.BT_borrar.TabIndex = 34;
            this.BT_borrar.Text = "Borrar";
            this.BT_borrar.UseVisualStyleBackColor = false;
            this.BT_borrar.Click += new System.EventHandler(this.BT_borrar_Click);
            // 
            // BT_ingresar
            // 
            this.BT_ingresar.BackColor = System.Drawing.Color.Black;
            this.BT_ingresar.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BT_ingresar.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_ingresar.Location = new System.Drawing.Point(693, 74);
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
            this.dataGridView1.Location = new System.Drawing.Point(48, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(618, 251);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TXT_salario
            // 
            this.TXT_salario.Location = new System.Drawing.Point(441, 130);
            this.TXT_salario.Name = "TXT_salario";
            this.TXT_salario.Size = new System.Drawing.Size(207, 22);
            this.TXT_salario.TabIndex = 31;
            this.TXT_salario.TextChanged += new System.EventHandler(this.TXT_salario_TextChanged);
            // 
            // CB_programas
            // 
            this.CB_programas.FormattingEnabled = true;
            this.CB_programas.Items.AddRange(new object[] {
            "Word",
            "Exel",
            "Power point",
            "Acces",
            "Outlook",
            "Visual Estudio",
            "Illustrator"});
            this.CB_programas.Location = new System.Drawing.Point(441, 214);
            this.CB_programas.Name = "CB_programas";
            this.CB_programas.Size = new System.Drawing.Size(207, 24);
            this.CB_programas.TabIndex = 30;
            // 
            // TXT_idioma
            // 
            this.TXT_idioma.Location = new System.Drawing.Point(441, 173);
            this.TXT_idioma.Name = "TXT_idioma";
            this.TXT_idioma.Size = new System.Drawing.Size(207, 22);
            this.TXT_idioma.TabIndex = 29;
            // 
            // TXT_puesto
            // 
            this.TXT_puesto.Location = new System.Drawing.Point(441, 86);
            this.TXT_puesto.Name = "TXT_puesto";
            this.TXT_puesto.Size = new System.Drawing.Size(207, 22);
            this.TXT_puesto.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Programas informativos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "¿Habla otro idioma?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Salario a ganar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "¿Qué puesto quiere ocupar en la empresa?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 46);
            this.label1.TabIndex = 22;
            this.label1.Text = "Conocimiento Informativo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(982, 532);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(693, 262);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 251);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // Conocimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 525);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BT_cambiar);
            this.Controls.Add(this.BT_borrar);
            this.Controls.Add(this.BT_ingresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TXT_salario);
            this.Controls.Add(this.CB_programas);
            this.Controls.Add(this.TXT_idioma);
            this.Controls.Add(this.TXT_puesto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Conocimiento";
            this.Text = "Conocimiento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_cambiar;
        private System.Windows.Forms.Button BT_borrar;
        private System.Windows.Forms.Button BT_ingresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TXT_salario;
        private System.Windows.Forms.ComboBox CB_programas;
        private System.Windows.Forms.TextBox TXT_idioma;
        private System.Windows.Forms.TextBox TXT_puesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}