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
    public partial class Perfil_Laboral : Form
    {
        public Perfil_Laboral()
        {
            InitializeComponent();
        }

        private void BT_siguiente_Click(object sender, EventArgs e)
        {
            Container mdicontainer = new Container();
            mdicontainer.Show();
            this.Hide();
            mdicontainer.FormClosed += (s, args) => Application.Exit();
        }
    }
}
