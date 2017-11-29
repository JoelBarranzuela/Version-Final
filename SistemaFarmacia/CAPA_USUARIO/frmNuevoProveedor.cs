using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CAPA_ENTIDAD;
using CAPA_NEGOCIO;
namespace CAPA_USUARIO
{
    public partial class frmNuevoProveedor : Form
    {
        RegistrosNEG rneg = new RegistrosNEG();
        ProveedorEnt proent;
        public frmNuevoProveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                    {
                        c.Focus();
                        MessageBox.Show("Necesita rellenar este  campo");
                        return;
                    }
                }
            }

            r_proveedor();


        }

        private void r_proveedor() {
            proent = new ProveedorEnt();
            proent.RAZON_SOCIAL1 = txtRazonsocial.Text;
            proent.TELEFONO1 = txtTelefono.Text;
            proent.EMAIL1 = txtEmail.Text;

            rneg.registrar_proveedor(proent);
            MessageBox.Show("Proveedor registrado correctamente");
            cargar_grilla();

        }

        private void cargar_grilla() {

            dataGridView1.DataSource = rneg.lista_proveedor().Tables[0];
        }

        private void frmNuevoProveedor_Load(object sender, EventArgs e)
        {
            cargar_grilla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
