using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Cursos : Form
    {
        NegocioNG usuario = new NegocioNG();
        int Id_cursos;
        bool Editar = false;
        public Cursos()
        {
            InitializeComponent();
        }
        public void Mostrar3()
        {
            dataGridView1.DataSource = usuario.Mostrar_Tabla3();
        }

        private void BT_ingresar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    usuario.Digitar3(TXT_centro.Text, TXT_estudio.Text, CB_nivel.Text, TXT_inicio.Text, CB_estado.Text, TXT_final.Text);
                    Mostrar3();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            if (Editar == true)
            {
                usuario.Diferente3(Id_cursos, TXT_centro.Text, TXT_estudio.Text, CB_nivel.Text, TXT_inicio.Text, CB_estado.Text, TXT_final.Text);
                Mostrar3();
            }
        }

        private void BT_cambiar_Click(object sender, EventArgs e)
        {
            Editar = true;
            TXT_centro.Text = dataGridView1.CurrentRow.Cells["Centro"].Value.ToString();
            TXT_estudio.Text = dataGridView1.CurrentRow.Cells["Estudio"].Value.ToString();
            CB_nivel.Text = dataGridView1.CurrentRow.Cells["Nivel"].Value.ToString();
            TXT_inicio.Text = dataGridView1.CurrentRow.Cells["F_inicio"].Value.ToString();
            CB_estado.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
            TXT_final.Text = dataGridView1.CurrentRow.Cells["F_final"].Value.ToString();
            Id_cursos = int.Parse(dataGridView1.CurrentRow.Cells["Id_cursos"].Value.ToString());
        }

        private void BT_borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Id_cursos = int.Parse(dataGridView1.CurrentRow.Cells["Id_cursos"].Value.ToString());
                usuario.Borrar3(Id_cursos);
                Mostrar3();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar3();
        }
    }
}
