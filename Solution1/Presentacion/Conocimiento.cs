using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Conocimiento : Form
    {
        public Conocimiento()
        {
            InitializeComponent();
        }

        NegocioNG usuarios = new NegocioNG();
        int Id_conocimiento;
        bool Editar = false;
        public void Mostrar5()
        {
            dataGridView1.DataSource = usuarios.Mostrar_Tabla5();
        }

        private void BT_ingresar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    usuarios.Digitar5(TXT_puesto.Text, decimal.Parse(TXT_salario.Text), TXT_idioma.Text, CB_programas.Text);
                    Mostrar5();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            if (Editar == true)
            {
                usuarios.Diferente5(Id_conocimiento, TXT_puesto.Text, decimal.Parse(TXT_salario.Text), TXT_idioma.Text, CB_programas.Text);
                Mostrar5();
            }
        }

        private void BT_cambiar_Click(object sender, EventArgs e)
        {
            Editar = true;
            TXT_puesto.Text = dataGridView1.CurrentRow.Cells["Puesto_E"].Value.ToString();
            string salarioStr = dataGridView1.CurrentRow.Cells["Salario"].Value.ToString();
            if (decimal.TryParse(salarioStr, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal salario))
            {
                TXT_salario.Text = salario.ToString();
            }
            else
            {
                MessageBox.Show("El valor del salario no es válido.");
                TXT_salario.Text = string.Empty;
            }
            TXT_idioma.Text = dataGridView1.CurrentRow.Cells["Idioma"].Value.ToString();
            CB_programas.Text = dataGridView1.CurrentRow.Cells["Programas"].Value.ToString();
            Id_conocimiento = int.Parse(dataGridView1.CurrentRow.Cells["Id_conocimiento"].Value.ToString());
        }

        private void BT_borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Id_conocimiento = int.Parse(dataGridView1.CurrentRow.Cells["Id_conocimiento"].Value.ToString());
                usuarios.Borrar5(Id_conocimiento);
                Mostrar5();
            }
        }

        private void TXT_salario_TextChanged(object sender, EventArgs e)
        {
            TXT_salario.MaxLength = 9;
            string currentText = TXT_salario.Text;


            for (int i = 0; i < currentText.Length; i++)
            {
                if (!char.IsDigit(currentText[i]))
                {
                    TXT_salario.Text = currentText.Remove(i, 1);

                    TXT_salario.SelectionStart = TXT_salario.Text.Length;
                    break;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar5();
        }
    }
}
