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
    public partial class frmVentasporFechas : Form
    {
        public frmVentasporFechas()
        {
            InitializeComponent();
        }

        ConsultaNEG cneg = new ConsultaNEG();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmVentasporFechas_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = cneg.ventas_por_fechas(null, null).Tables[0];
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                dataGridView1.DataSource = cneg.ventas_por_fechas(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date).Tables[0];

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = cneg.ventas_por_fechas(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date).Tables[0];

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
