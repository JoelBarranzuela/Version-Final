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
    public partial class frmSeleccionarProducto : Form
    {
        public  Venta container;
        ConsultacomboNEG cneg = new ConsultacomboNEG();
        Producto pent;
        public String [] array = new String[4];
        public int cantidad;
        public frmSeleccionarProducto(Venta f1)
        {
            
            this.container = f1;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSeleccionarProducto_Load(object sender, EventArgs e)
        {
            cargar_tipoproducto();
        }

        private void cargar_tipoproducto() {
            cboTipoProducto.DataSource = cneg.lista_tipoproductos().Tables[0];
            cboTipoProducto.ValueMember = "codigo";
            cboTipoProducto.DisplayMember = "nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista_();
        }

        private void lista_()
        {
            pent = new Producto();
            pent.CodigoCategoria = Convert.ToInt32(cboTipoProducto.SelectedValue);
            pent.Nombre_producto = txtBusqueda.Text;
            dataGridView1.DataSource = cneg.producto_por_tipo_nombre(pent).Tables[0];
        
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            lista_();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value) > 0)
                {
                    array[0] = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //IDPRODUCTO
                    array[1] = dataGridView1.CurrentRow.Cells[1].Value.ToString(); // NOMBRE
                    //  array[2] = dataGridView1.CurrentRow.Cells[0].Value.ToString(); // STOCK
                    array[2] = dataGridView1.CurrentRow.Cells[3].Value.ToString(); // PRECIO UNITARIO
                    frmSeleccionarCantidad fr = new frmSeleccionarCantidad(this, dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    fr.MdiParent = this.ParentForm;
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Este producto no tiene stock");
                }
                
            }
        }

        public void seleccionar_producto(){
           
            array[3] = cantidad.ToString();
            agregar();
        }

        public void agregar()
        {
            container.agregar_producto(array);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

    }
}
