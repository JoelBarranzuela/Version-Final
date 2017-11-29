using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CAPA_NEGOCIO;
namespace CAPA_USUARIO
{
    public partial class frmVentaDetalle : Form
    {
        ConsultaNEG cneg = new ConsultaNEG();
        DetallesNEG dneg = new DetallesNEG();
        public frmVentaDetalle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar_ventas();
        }

        private void frmVentaDetalle_Load(object sender, EventArgs e)
        {
            cargar_ventas();
        }

        private void cargar_ventas()
        {
            try
            {
                dataGridView1.DataSource = cneg.ventas_por_codigo(textBox1.Text.ToString()).Tables[0];
                dataGridView2.DataSource = "";
            }
            catch (Exception)
            {
                
                throw;
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cargar_ventas();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) > 0)
                    {
                        string val = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //IDPRODUCTO
                        dataGridView2.DataSource = dneg.venta_detalle(val).Tables[0];

                    }


                }
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
