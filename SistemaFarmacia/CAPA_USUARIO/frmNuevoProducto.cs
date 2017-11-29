using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CAPA_NEGOCIO;
using CAPA_ENTIDAD;
namespace CAPA_USUARIO
{
    public partial class frmNuevoProducto : Form
    {
        ConsultacomboNEG cneg = new ConsultacomboNEG();
        RegistrosNEG rneg = new RegistrosNEG();
        Producto pent;
        Medicamento ment ;

        public frmNuevoProducto()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cargar_tipo_productos()
        {
            cboTipoProducto.DataSource = cneg.lista_tipoproductos().Tables[0];
            cboTipoProducto.ValueMember = "codigo";
            cboTipoProducto.DisplayMember = "nombre";
        }

        private void cargar_tipos_presentacion_producto()
        {
            cboTpresentacion1.DataSource = cneg.lista_presentacion_producto().Tables[0];
            cboTpresentacion1.ValueMember = "codigo";
            cboTpresentacion1.DisplayMember = "nombre";

            cboTpresentacion2.DataSource = cneg.lista_presentacion_producto().Tables[0];
            cboTpresentacion2.ValueMember = "codigo";
            cboTpresentacion2.DisplayMember = "nombre";
        }


        private void cargar_principio_activo()
        {
            cboPrincipioActivo.DataSource = cneg.lista_principio_activo().Tables[0];
            cboPrincipioActivo.DisplayMember = "nombre";
            cboPrincipioActivo.ValueMember = "codigo";
        }

        private void cargar_laboratorio()
        {
            cboLaboratorio.DataSource = cneg.lista_laboratorios().Tables[0];
            cboLaboratorio.DisplayMember = "nombre";
            cboLaboratorio.ValueMember = "codigo";
        }
        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            cargar_tipo_productos();
            cargar_tipos_presentacion_producto();
            cargar_principio_activo();
            cargar_laboratorio();
            cboCondicionVenta.SelectedIndex = 0;
            cboTipoMedicamento.SelectedIndex = 0;





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Controls.ClearControls();
            pn1.Enabled = true;
            pn2.Enabled = true;
            button1.Enabled = true;

            pn1.Visible = true;
            pn2.Visible = true;
            button1.Visible = true;

            if (cboTipoProducto.Text.Equals("MEDICAMENTOS"))
            {
                pn1.Show(); // PANEL PARA REGISTRO DE PRODUCTOS CON OPCIONES ADICIONALES DE MEDICAMENTO
                pn2.Hide(); // PANEL PARA REGISTRO DE PRODUCTOS SIN OPCIONES ADICIONALES
                this.Width = 798; // CAMBIO EL TAMAÑO

            }
            else
            {
                this.Width = 550; // TAMAÑO POR DEFECTO
                pn2.Show(); // PANEL PARA REGISTRO DE PRODUCTOS SIN OPCIONES ADICIONALES 
                pn1.Hide();// PANEL PARA REGISTRO DE PRODUCTOS CON OPCIONES ADICIONALES DE MEDICAMENTO
            }
        }

        // BOTON DE REGISTRAR
        private void button1_Click(object sender, EventArgs e)
        {
           
                if (cboTipoProducto.Text.Equals("MEDICAMENTOS"))
                {
                    validar_panel1();
                    pent = new Producto();
                    pent.CodigoCategoria = Convert.ToInt32(cboTipoProducto.SelectedValue);
                    pent.CodigoTipopresentacion = Convert.ToInt32(cboTpresentacion1.SelectedValue);
                    pent.Nombre_producto = txtNombre1.Text;
                    pent.Precio_uni = (float)Convert.ToDecimal(txtPrecioUnitario1.Text);
                    pent.Stock = Convert.ToInt32(nudStock1.Value);
                    pent.Descripcion = txtDescripcion1.Text;

                    ment = new Medicamento();
                    ment.Id_codigoprincipioact = Convert.ToInt32(cboPrincipioActivo.SelectedValue);
                    ment.Id_codigolaboratorio = Convert.ToInt32(cboLaboratorio.SelectedValue);
                    ment.Nro_lote = txtNrolote1.Text;
                    ment.Fecha_vencimimiento = dtpFechavencimiento1.Value;
                    ment.Condicion_Venta = cboCondicionVenta.Text;
                    ment.Tipo_medicamento1 = cboTipoMedicamento.Text;
                    

                    int codigo = rneg.registrar_producto(pent, 1, ment);
                    MessageBox.Show("Producto registrado con exito \n , Codigo Generado : " + codigo.ToString());
                }
                else
                {
                    validar_panel2();
                    pent = new Producto();
                    pent.CodigoCategoria = Convert.ToInt32(cboTipoProducto.SelectedValue);
                    pent.CodigoTipopresentacion = Convert.ToInt32(cboTpresentacion2.SelectedValue);
                    pent.Nombre_producto = txtNombre2.Text;
                    pent.Precio_uni = (float)Convert.ToDecimal(txtPrecioUnitario2.Text);
                    pent.Stock = Convert.ToInt32(nudStock2.Value);
                    pent.Descripcion = txtDescripcion2.Text;

                    int codigo = rneg.registrar_producto(pent, 0);

                    MessageBox.Show("Producto registrado con exito \n , Codigo Generado : " + codigo.ToString());

                }
                this.Controls.ClearControls();
            
            
        }

        private void validar_panel2()
        {
            foreach (Control c in pn2.Controls)
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

                if (c is ComboBox)
                {
                    if (c.Text == "")
                    {
                        c.Focus();
                        MessageBox.Show("Necesita rellenar este  campo");
                        return;
                    }
                }
                if (c is NumericUpDown)
                {
                    if (c.Text == "0" || c.Text == "")
                    {
                        c.Focus();
                        MessageBox.Show("Necesita rellenar este  campo");
                        return;
                    }
                }


            }

        }

        private void validar_panel1()
        {
            foreach (Control c in pn1.Controls)
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

                if (c is ComboBox)
                {
                    if (c.Text == "")
                    {
                       
                        MessageBox.Show("Necesita rellenar este  campo");
                        return;
                    }
                }
                if (c is NumericUpDown)
                {
                    if (c.Text == "0" || c.Text == "")
                    {
                        c.Focus();
                        MessageBox.Show("Necesita rellenar este  campo");
                        return;
                    }
                }


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
