using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Iniciar_Sesion : Form
    {
        NegocioNG usuario = new NegocioNG();
        public Iniciar_Sesion()
        {
            InitializeComponent();
        }

        private void BT_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuario.Verificar(TXT_correoV.Text, TXT_pasword.Text))
                {
                    Perfil_Laboral mdicontainer = new Perfil_Laboral();
                    mdicontainer.Show();
                    this.Hide();
                    mdicontainer.FormClosed += (s, args) => Application.Exit();
                }
            }
            catch (Exception xe)
            {

                MessageBox.Show(xe.Message);
            }
        }

        private void BT_registrar_Click(object sender, EventArgs e)
        {
            Datos_Personales datos_personales = new Datos_Personales();
            datos_personales.Show();
            this.Hide();
        }
    }
}
