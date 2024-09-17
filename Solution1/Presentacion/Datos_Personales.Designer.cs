namespace Presentacion
{
    partial class Datos_Personales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos_Personales));
            this.BT_añadir = new System.Windows.Forms.Button();
            this.TXT_contraseña = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BT_ingresar = new System.Windows.Forms.Button();
            this.TXT_telefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_correo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TXT_direccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_fecha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_genero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_apellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_doc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_tipodoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_añadir
            // 
            this.BT_añadir.BackColor = System.Drawing.Color.Black;
            this.BT_añadir.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BT_añadir.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_añadir.Location = new System.Drawing.Point(659, 465);
            this.BT_añadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_añadir.Name = "BT_añadir";
            this.BT_añadir.Size = new System.Drawing.Size(141, 52);
            this.BT_añadir.TabIndex = 71;
            this.BT_añadir.Text = "Añadir";
            this.BT_añadir.UseVisualStyleBackColor = false;
            this.BT_añadir.Click += new System.EventHandler(this.BT_añadir_Click);
            // 
            // TXT_contraseña
            // 
            this.TXT_contraseña.Location = new System.Drawing.Point(562, 425);
            this.TXT_contraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_contraseña.Name = "TXT_contraseña";
            this.TXT_contraseña.PasswordChar = '*';
            this.TXT_contraseña.Size = new System.Drawing.Size(209, 22);
            this.TXT_contraseña.TabIndex = 70;
            this.TXT_contraseña.TextChanged += new System.EventHandler(this.TXT_contraseña_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(359, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 18);
            this.label11.TabIndex = 69;
            this.label11.Text = "Contraseña";
            // 
            // BT_ingresar
            // 
            this.BT_ingresar.BackColor = System.Drawing.Color.Black;
            this.BT_ingresar.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BT_ingresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_ingresar.Location = new System.Drawing.Point(805, 465);
            this.BT_ingresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_ingresar.Name = "BT_ingresar";
            this.BT_ingresar.Size = new System.Drawing.Size(140, 52);
            this.BT_ingresar.TabIndex = 68;
            this.BT_ingresar.Text = "Ingresar";
            this.BT_ingresar.UseVisualStyleBackColor = false;
            this.BT_ingresar.Click += new System.EventHandler(this.BT_ingresar_Click);
            // 
            // TXT_telefono
            // 
            this.TXT_telefono.Location = new System.Drawing.Point(562, 384);
            this.TXT_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_telefono.Name = "TXT_telefono";
            this.TXT_telefono.Size = new System.Drawing.Size(209, 22);
            this.TXT_telefono.TabIndex = 67;
            this.TXT_telefono.TextChanged += new System.EventHandler(this.TXT_telefono_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(359, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 66;
            this.label10.Text = "Telefono";
            // 
            // TXT_correo
            // 
            this.TXT_correo.Location = new System.Drawing.Point(562, 341);
            this.TXT_correo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_correo.Name = "TXT_correo";
            this.TXT_correo.Size = new System.Drawing.Size(209, 22);
            this.TXT_correo.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(359, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 64;
            this.label9.Text = "Correo";
            // 
            // TXT_direccion
            // 
            this.TXT_direccion.Location = new System.Drawing.Point(562, 302);
            this.TXT_direccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_direccion.Name = "TXT_direccion";
            this.TXT_direccion.Size = new System.Drawing.Size(209, 22);
            this.TXT_direccion.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(359, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 62;
            this.label8.Text = "Direccion";
            // 
            // TXT_fecha
            // 
            this.TXT_fecha.Location = new System.Drawing.Point(562, 260);
            this.TXT_fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_fecha.Name = "TXT_fecha";
            this.TXT_fecha.Size = new System.Drawing.Size(209, 22);
            this.TXT_fecha.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(359, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 18);
            this.label7.TabIndex = 60;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // CB_genero
            // 
            this.CB_genero.FormattingEnabled = true;
            this.CB_genero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "Binario"});
            this.CB_genero.Location = new System.Drawing.Point(562, 223);
            this.CB_genero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_genero.Name = "CB_genero";
            this.CB_genero.Size = new System.Drawing.Size(209, 24);
            this.CB_genero.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(359, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 58;
            this.label6.Text = "Genero";
            // 
            // TXT_apellido
            // 
            this.TXT_apellido.Location = new System.Drawing.Point(562, 181);
            this.TXT_apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_apellido.Name = "TXT_apellido";
            this.TXT_apellido.Size = new System.Drawing.Size(209, 22);
            this.TXT_apellido.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(359, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 56;
            this.label5.Text = "Apellidos";
            // 
            // TXT_nombre
            // 
            this.TXT_nombre.Location = new System.Drawing.Point(562, 145);
            this.TXT_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_nombre.Name = "TXT_nombre";
            this.TXT_nombre.Size = new System.Drawing.Size(209, 22);
            this.TXT_nombre.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(359, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Nombres";
            // 
            // TXT_doc
            // 
            this.TXT_doc.Location = new System.Drawing.Point(562, 105);
            this.TXT_doc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_doc.Name = "TXT_doc";
            this.TXT_doc.Size = new System.Drawing.Size(209, 22);
            this.TXT_doc.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(359, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "Numero de documento";
            // 
            // CB_tipodoc
            // 
            this.CB_tipodoc.FormattingEnabled = true;
            this.CB_tipodoc.Items.AddRange(new object[] {
            "CC",
            "TI",
            "PP",
            "CE"});
            this.CB_tipodoc.Location = new System.Drawing.Point(562, 62);
            this.CB_tipodoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_tipodoc.Name = "CB_tipodoc";
            this.CB_tipodoc.Size = new System.Drawing.Size(209, 24);
            this.CB_tipodoc.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(359, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tipo de documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 46);
            this.label1.TabIndex = 49;
            this.label1.Text = "Datos personales";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-81, -39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 567);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // Datos_Personales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 525);
            this.Controls.Add(this.BT_añadir);
            this.Controls.Add(this.TXT_contraseña);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BT_ingresar);
            this.Controls.Add(this.TXT_telefono);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TXT_correo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TXT_direccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXT_fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CB_genero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXT_apellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_doc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_tipodoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Datos_Personales";
            this.Text = "Datos_Personales";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_añadir;
        private System.Windows.Forms.TextBox TXT_contraseña;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BT_ingresar;
        private System.Windows.Forms.TextBox TXT_telefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXT_correo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXT_direccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXT_fecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_genero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_apellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_doc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_tipodoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}