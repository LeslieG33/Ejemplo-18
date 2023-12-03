using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_18
{
    public partial class frmEjemplo18 : Form
    {
        public frmEjemplo18()
        {
            InitializeComponent();
        }

        private void cmdCaptura_Click(object sender, EventArgs e)
        {
            // Entrada a cinco nombres y almacenarlos en un arreglo bidimensional
            // Ejemplo 18
            // Leslie Giselle Avila Romero 23211918

            // Declaración de variables
            int R;
            string[] Nom = new string[5];

            // Crea un objeto de la clase frmSegunda
            frmCaptura FormaCaptura = new frmCaptura();

            // Desactivar botón Captura
            cmdCaptura.Enabled = false;

            // Entrada de datos
            for (R = 0; R < 5; R++)
            {
                if (FormaCaptura.ShowDialog() == DialogResult.OK)
                {
                    Nom[R] = FormaCaptura.txtNombre.Text;
                }
                else
                {
                    R--;
                }
 
            }
            // Desplegado del arreglo unidimensional
            for (R = 0; R < 5; R++)
            {
                txtNombres.Text = txtNombres.Text + Nom[R] + "\r\n";
            }
        }

        private void cmdSalida_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            cmdCaptura.Enabled = true;
        }
    }
}
