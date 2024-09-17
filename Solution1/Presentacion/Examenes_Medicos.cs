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
    public partial class Examenes_Medicos : Form
    {
        NegocioNG usuarios = new NegocioNG();
        int Id_Medico;
        bool Editar = false;
        public Examenes_Medicos()
        {
            InitializeComponent();
        }
        public void Mostrar4()
        {
            dataGridView1.DataSource = usuarios.Mostrar_Tabla4();
        }

        private void BT_ingresar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    usuarios.Digitar4(TXT_cronica.Text, TXT_cirugia.Text, TXT_medicamentos.Text, TXT_alergia.Text, TXT_lesiones.Text);
                    Mostrar4();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            if (Editar == true)
            {
                usuarios.Diferente4(Id_Medico, TXT_cronica.Text, TXT_cirugia.Text, TXT_medicamentos.Text, TXT_alergia.Text, TXT_lesiones.Text);
                Mostrar4();
            }
        }

        private void BT_cambiar_Click(object sender, EventArgs e)
        {
            Editar = true;
            TXT_cronica.Text = dataGridView1.CurrentRow.Cells["E_cronica"].Value.ToString();
            TXT_cirugia.Text = dataGridView1.CurrentRow.Cells["Cirugia"].Value.ToString();
            TXT_medicamentos.Text = dataGridView1.CurrentRow.Cells["Medicamentos"].Value.ToString();
            TXT_alergia.Text = dataGridView1.CurrentRow.Cells["Alergia"].Value.ToString();
            TXT_lesiones.Text = dataGridView1.CurrentRow.Cells["Lesiones"].Value.ToString();
            Id_Medico = int.Parse(dataGridView1.CurrentRow.Cells["Id_Medico"].Value.ToString());
        }

        private void BT_borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Id_Medico = int.Parse(dataGridView1.CurrentRow.Cells["Id_Medico"].Value.ToString());
                usuarios.Borrar4(Id_Medico);
                Mostrar4();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar4();
        }
    }
}
