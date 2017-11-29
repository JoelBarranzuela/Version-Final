using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CAPA_USUARIO
{
    public partial class frmSeleccionarCantidad : Form
    {
        public frmSeleccionarProducto fr1;
        String x;
        public frmSeleccionarCantidad(frmSeleccionarProducto fr2, String Nombreproducto)
        {
            this.fr1 = fr2;
            this.x = Nombreproducto;
            InitializeComponent();
        }

        private void frmSeleccionarCantidad_Load(object sender, EventArgs e)
        {
            lblnombreproducto.Text = x.Substring(0,15) + "...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Cantidad no puede ser 0");
            }
            else
            {
                fr1.cantidad = Convert.ToInt32(numericUpDown1.Value);
                fr1.seleccionar_producto();
                this.Dispose();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
