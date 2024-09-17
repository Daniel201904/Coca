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
    public partial class Datos_Personales : Form
    {
        NegocioNG usuario = new NegocioNG();
        public Datos_Personales()
        {
            InitializeComponent();
        }

        private void BT_ingresar_Click(object sender, EventArgs e)
        {
            Perfil_Laboral perfil = new Perfil_Laboral();
            perfil.Show();
            this.Hide();
        }

        private void BT_añadir_Click(object sender, EventArgs e)
        {
            usuario.Digitar1(CB_tipodoc.Text, int.Parse(TXT_doc.Text), TXT_nombre.Text, TXT_apellido.Text, CB_genero.Text, TXT_fecha.Text, TXT_direccion.Text, TXT_correo.Text, int.Parse(TXT_telefono.Text), int.Parse(TXT_contraseña.Text));
        
        }

        private void TXT_contraseña_TextChanged(object sender, EventArgs e)
        {
            TXT_contraseña.MaxLength = 4;
            string currentText = TXT_contraseña.Text;


            for (int i = 0; i < currentText.Length; i++)
            {
                if (!char.IsDigit(currentText[i]))
                {
                    TXT_contraseña.Text = currentText.Remove(i, 1);

                    TXT_contraseña.SelectionStart = TXT_contraseña.Text.Length;
                    break;
                }
            }
        }

        private void TXT_telefono_TextChanged(object sender, EventArgs e)
        {
            TXT_telefono.MaxLength = 9;
            string currentText = TXT_telefono.Text;


            for (int i = 0; i < currentText.Length; i++)
            {
                if (!char.IsDigit(currentText[i]))
                {
                    TXT_telefono.Text = currentText.Remove(i, 1);

                    TXT_telefono.SelectionStart = TXT_telefono.Text.Length;
                    break;
                }
            }
        }
    }
}
