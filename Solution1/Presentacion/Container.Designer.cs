namespace Presentacion
{
    partial class Container
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.experienciaDelUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experienciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosRealizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examenesMedicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queremosSaberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conocerteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.experienciaDelUsuarioToolStripMenuItem,
            this.cursosRealizadosToolStripMenuItem,
            this.examenesMedicosToolStripMenuItem,
            this.queremosSaberToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // experienciaDelUsuarioToolStripMenuItem
            // 
            this.experienciaDelUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.experienciaToolStripMenuItem});
            this.experienciaDelUsuarioToolStripMenuItem.Name = "experienciaDelUsuarioToolStripMenuItem";
            this.experienciaDelUsuarioToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.experienciaDelUsuarioToolStripMenuItem.Text = "Experiencia del usuario";
            // 
            // experienciaToolStripMenuItem
            // 
            this.experienciaToolStripMenuItem.Name = "experienciaToolStripMenuItem";
            this.experienciaToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.experienciaToolStripMenuItem.Text = "Experiencia ";
            this.experienciaToolStripMenuItem.Click += new System.EventHandler(this.experienciaToolStripMenuItem_Click);
            // 
            // cursosRealizadosToolStripMenuItem
            // 
            this.cursosRealizadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursosToolStripMenuItem});
            this.cursosRealizadosToolStripMenuItem.Name = "cursosRealizadosToolStripMenuItem";
            this.cursosRealizadosToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.cursosRealizadosToolStripMenuItem.Text = "Cursos Realizados ";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // examenesMedicosToolStripMenuItem
            // 
            this.examenesMedicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suExamenToolStripMenuItem});
            this.examenesMedicosToolStripMenuItem.Name = "examenesMedicosToolStripMenuItem";
            this.examenesMedicosToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.examenesMedicosToolStripMenuItem.Text = "Examenes Medicos";
            // 
            // suExamenToolStripMenuItem
            // 
            this.suExamenToolStripMenuItem.Name = "suExamenToolStripMenuItem";
            this.suExamenToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.suExamenToolStripMenuItem.Text = "Su examen";
            this.suExamenToolStripMenuItem.Click += new System.EventHandler(this.suExamenToolStripMenuItem_Click);
            // 
            // queremosSaberToolStripMenuItem
            // 
            this.queremosSaberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conocerteToolStripMenuItem});
            this.queremosSaberToolStripMenuItem.Name = "queremosSaberToolStripMenuItem";
            this.queremosSaberToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.queremosSaberToolStripMenuItem.Text = "¿Queremos saber?";
            // 
            // conocerteToolStripMenuItem
            // 
            this.conocerteToolStripMenuItem.Name = "conocerteToolStripMenuItem";
            this.conocerteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.conocerteToolStripMenuItem.Text = "Conocerte";
            this.conocerteToolStripMenuItem.Click += new System.EventHandler(this.conocerteToolStripMenuItem_Click);
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Container";
            this.Text = "Container";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem experienciaDelUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem experienciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosRealizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examenesMedicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suExamenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queremosSaberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conocerteToolStripMenuItem;
    }
}