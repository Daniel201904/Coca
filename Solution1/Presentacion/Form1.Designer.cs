namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BT_registrar = new System.Windows.Forms.Button();
            this.BT_ingresar = new System.Windows.Forms.Button();
            this.TXT_pasword = new System.Windows.Forms.TextBox();
            this.TXT_correoV = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_registrar
            // 
            this.BT_registrar.BackColor = System.Drawing.Color.Black;
            this.BT_registrar.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BT_registrar.ForeColor = System.Drawing.Color.AliceBlue;
            this.BT_registrar.Location = new System.Drawing.Point(533, 388);
            this.BT_registrar.Name = "BT_registrar";
            this.BT_registrar.Size = new System.Drawing.Size(229, 67);
            this.BT_registrar.TabIndex = 20;
            this.BT_registrar.Text = "Registrarse";
            this.BT_registrar.UseVisualStyleBackColor = false;
            this.BT_registrar.Click += new System.EventHandler(this.BT_registrar_Click);
            // 
            // BT_ingresar
            // 
            this.BT_ingresar.BackColor = System.Drawing.Color.Red;
            this.BT_ingresar.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BT_ingresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_ingresar.Location = new System.Drawing.Point(780, 388);
            this.BT_ingresar.Name = "BT_ingresar";
            this.BT_ingresar.Size = new System.Drawing.Size(177, 67);
            this.BT_ingresar.TabIndex = 19;
            this.BT_ingresar.Text = "Ingresar";
            this.BT_ingresar.UseVisualStyleBackColor = false;
            this.BT_ingresar.Click += new System.EventHandler(this.BT_ingresar_Click);
            // 
            // TXT_pasword
            // 
            this.TXT_pasword.Location = new System.Drawing.Point(648, 298);
            this.TXT_pasword.Name = "TXT_pasword";
            this.TXT_pasword.Size = new System.Drawing.Size(229, 22);
            this.TXT_pasword.TabIndex = 18;
            // 
            // TXT_correoV
            // 
            this.TXT_correoV.Location = new System.Drawing.Point(648, 146);
            this.TXT_correoV.Name = "TXT_correoV";
            this.TXT_correoV.Size = new System.Drawing.Size(229, 22);
            this.TXT_correoV.TabIndex = 17;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.BackColor = System.Drawing.Color.White;
            this.Contraseña.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold);
            this.Contraseña.Location = new System.Drawing.Point(648, 209);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(229, 46);
            this.Contraseña.TabIndex = 16;
            this.Contraseña.Text = "Contraseña";
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.BackColor = System.Drawing.Color.White;
            this.Correo.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold);
            this.Correo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Correo.Location = new System.Drawing.Point(682, 77);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(144, 46);
            this.Correo.TabIndex = 15;
            this.Correo.Text = "Correo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-87, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(849, 612);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(982, 525);
            this.Controls.Add(this.BT_registrar);
            this.Controls.Add(this.BT_ingresar);
            this.Controls.Add(this.TXT_pasword);
            this.Controls.Add(this.TXT_correoV);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_registrar;
        private System.Windows.Forms.Button BT_ingresar;
        private System.Windows.Forms.TextBox TXT_pasword;
        private System.Windows.Forms.TextBox TXT_correoV;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Label Correo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

