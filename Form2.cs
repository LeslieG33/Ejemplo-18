using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_18
{
    public partial class frmCaptura : Form
    {
        public frmCaptura()
        {
            InitializeComponent();
        }

        private void frmCaptura_Load(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtNombre.Focus();
        }
    }
}
