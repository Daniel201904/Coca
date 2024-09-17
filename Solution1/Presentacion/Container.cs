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
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
        }

        private void experienciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Experiencia XP = new Experiencia();
            XP.Show();
            XP.MdiParent = this;
        }
    }
}