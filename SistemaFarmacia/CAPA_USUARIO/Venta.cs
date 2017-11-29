using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using CAPA_ENTIDAD;
using CAPA_NEGOCIO;
namespace CAPA_USUARIO
{
    public partial class Venta : Form
    {
        VentaEnt vent = new VentaEnt();
        RegistrosNEG rneg = new RegistrosNEG();
        DataTable dtdetalle = new DataTable();
        DataRow row;


        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            Credenciales.Username = Credenciales.Username;
            Credenciales.CodigoUsuario = Credenciales.CodigoUsuario;
            lblUsuario.Text = Credenciales.Username;


            dtdetalle.Columns.Add("Codigo", typeof(Int32)).Unique = true;
            dtdetalle.Columns.Add("Nombre", typeof(String));
            dtdetalle.Columns.Add("Precio", typeof(Double));
            dtdetalle.Columns.Add("Cantidad", typeof(Int32));
            dtdetalle.Columns.Add("Importe", typeof(Single), "Precio * Cantidad");
            

            dataGridView1.DataSource = dtdetalle;

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "btnEliminar";
                button.HeaderText = "Accion";
                button.Text = "Eliminar";
                button.Width = 100;
                button.UseColumnTextForButtonValue = true; //dont forget this line
                this.dataGridView1.Columns.Add(button);
            }

        }

        double precio  = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;

            var culture = new CultureInfo("fr-FR");
            lblfechayhora.Text = localDate.ToString(culture);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSeleccionarProducto fr1 = new frmSeleccionarProducto(this);
            fr1.MdiParent = this.ParentForm;
            fr1.Show();
        }


        public void agregar_producto(String[] x)
        {
            try
            {
                row = dtdetalle.NewRow();
                row[0] = Convert.ToInt32(x[0]);
                row[1] = x[1];
                row[2] = Convert.ToDouble(x[2]);
                row[3] = Convert.ToInt32(x[3]);
                

               
                dtdetalle.Rows.Add(row);
                //foreach(DataRow roww  in dtdetalle.Rows){
                //    precio += ((double)row[2] * (int)row[3]) ;
                //}
                precio += ((double)row[2] * (int)row[3]);
                lblsubtotal.Text = "S/ " + precio.ToString();
                lbltotal.Text = "S/ " + (precio).ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Este producto ya fue agregado ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.RowCount >= 1)
            {
                vent.ID_USUARIO1 = Credenciales.CodigoUsuario;
                int c = 0;
                c = rneg.Registrar_venta(vent, dtdetalle);
                if (c != 0)
                {
                    txtTransaccion.Text = c.ToString();
                    MessageBox.Show("Venta Registrada correctamente");
                    //dtdetalle.Rows.Clear();
                    //dataGridView1.DataSource = dtdetalle;

                    btnRegistrarVenta.Enabled = false;
                    btnImprimirComprobante.Enabled = true;
                    btnAgregarProducto.Enabled = false;
            

                }

            }
            else
            {
                MessageBox.Show("Al parecer , no haz seleccionado ningun producto");
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpiar_cajas();
        }

        private void limpiar_cajas()
        {
            txtTransaccion.Text = "";
            lblsubtotal.Text = "";
            lbltotal.Text = "";
            btnRegistrarVenta.Enabled = true;
            btnImprimirComprobante.Enabled = false;
            btnAgregarProducto.Enabled = true;
            dtdetalle.Rows.Clear();
            dataGridView1.DataSource = dtdetalle;
            
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnImprimirComprobante_Click(object sender, EventArgs e)
        {
            frmReporte s = new frmReporte(txtTransaccion.Text, lblfechayhora.Text);
            s.MdiParent = this.ParentForm;
            s.Show();
           
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnEliminar"].Index)
            {
                dtdetalle.AcceptChanges();
                int x = dataGridView1.CurrentCell.RowIndex;
                dtdetalle.Rows[0].Delete();
                dtdetalle.AcceptChanges();

                precio = 0;
                foreach (DataRow row in dtdetalle.Rows) {
                    precio += ((double)row[2] * (int)row[3]);
                }
                lblsubtotal.Text = "S/ " + precio.ToString();
                lbltotal.Text = "S/ " + (precio).ToString();
                //String x = dataGridView1.CurrentCell.RowIndex.ToString();
                //MessageBox.Show(x);

            }
        }

       
    }
}
