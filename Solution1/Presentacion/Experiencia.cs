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
    public partial class Experiencia : Form
    {
        NegocioNG usuario = new NegocioNG();
        int Id_experiencia;
        bool Editar = false;
        public Experiencia()
        {
            InitializeComponent();
        }
        public void Mostrar2()
        {
            dataGridView1.DataSource = usuario.Mostrar_Tabla2();
        }

        private void BT_ingresar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    usuario.Digitar2(TXT_empresa.Text, TXT_cargo.Text, TXT_area.Text, TXT_jefe.Text, int.Parse(TXT_telefono2.Text));
                    Mostrar2();
                }
                catch (Exception ex)
                {

                }
            }
            if (Editar == true)
            {
                usuario.Diferente2(Id_experiencia, TXT_empresa.Text, TXT_cargo.Text, TXT_area.Text, TXT_jefe.Text, int.Parse(TXT_telefono2.Text));
                Mostrar2();
            }
        }

        private void BT_cambiar_Click(object sender, EventArgs e)
        {
            Editar = true;
            TXT_empresa.Text = dataGridView1.CurrentRow.Cells["N_empresa"].Value.ToString();
            TXT_cargo.Text = dataGridView1.CurrentRow.Cells["Cargo"].Value.ToString();
            TXT_area.Text = dataGridView1.CurrentRow.Cells["Area"].Value.ToString();
            TXT_jefe.Text = dataGridView1.CurrentRow.Cells["Jefe"].Value.ToString();
            TXT_telefono2.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
            Id_experiencia = int.Parse(dataGridView1.CurrentRow.Cells["Id_experiencia"].Value.ToString());
        }

        private void TXT_telefono2_TextChanged(object sender, EventArgs e)
        {
            TXT_telefono2.MaxLength = 9;
            string currentText = TXT_telefono2.Text;


            for (int i = 0; i < currentText.Length; i++)
            {
                if (!char.IsDigit(currentText[i]))
                {
                    TXT_telefono2.Text = currentText.Remove(i, 1);

                    TXT_telefono2.SelectionStart = TXT_telefono2.Text.Length;
                    break;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar2();
        }

        private void BT_borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Id_experiencia = int.Parse(dataGridView1.CurrentRow.Cells["Id_experiencia"].Value.ToString());
                usuario.Borrar2(Id_experiencia);
                Mostrar2();
            }
        }
    }
}
