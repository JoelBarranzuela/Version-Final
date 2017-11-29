using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CAPA_NEGOCIO;
namespace CAPA_USUARIO
{
    public partial class frmReporteProductoVendido : Form
    {


        ConsultaReporteNEG cneg = new ConsultaReporteNEG();
        public frmReporteProductoVendido()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmReporteProductoVendido_Load(object sender, EventArgs e)
        {


            cboTipoProducto.DataSource = cneg.lista_tipoproductos().Tables[0];
            cboTipoProducto.DisplayMember = "NOMBRE";
            cboTipoProducto.ValueMember = "CODIGO";

            cboTipoProducto.SelectedValue = 0;


            cboPresentacionProducto.DataSource = cneg.lista_presentacion_producto().Tables[0];
            cboPresentacionProducto.DisplayMember = "NOMBRE";
            cboPresentacionProducto.ValueMember = "CODIGO";

            cboPresentacionProducto.SelectedValue = 0;


            cboTipoProducto.Enabled = false;
            cboPresentacionProducto.Enabled = false;

            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {



            if (checkBox1.Checked)
            {
                dtpFechaFin.Enabled = true;
                dateTimePicker1.Enabled = true;
                cboTipoProducto.Enabled = true;
                cboPresentacionProducto.Enabled = true;
                button1.Enabled = true;

            }
            else if (!checkBox1.Checked)
            {

                dtpFechaFin.Enabled = false;
                dateTimePicker1.Enabled = false;
                cboTipoProducto.Enabled = false;
                cboPresentacionProducto.Enabled = false;
                cboPresentacionProducto.SelectedValue = 0;
                cboTipoProducto.SelectedValue = 0;
                button1.Enabled = false;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboPresentacionProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reporte();
        }
        private void reporte()
        {


            try
            {
                ReportDocument rd = new ReportDocument();
                ParameterFields pds;


                
                if (checkBox1.Checked)
                {

                    pds = new ParameterFields();

                    ParameterDiscreteValue pdv1;
                    ParameterField pf1 = new ParameterField();


                    pf1.ParameterFieldName = "@FECHAINI";//no is a crystal report parameter name
                    pf1.CurrentValues.Clear();
                    pdv1 = new ParameterDiscreteValue();
                    pdv1.Value = dateTimePicker1.Value.Date.ToString();
                    pf1.CurrentValues.Add(pdv1);



                    ParameterDiscreteValue pdv2;
                    ParameterField pf2 = new ParameterField();


                    pf2.ParameterFieldName = "@FECHAFIN";//no is a crystal report parameter name
                    pf2.CurrentValues.Clear();
                    pdv2 = new ParameterDiscreteValue();
                    pdv2.Value = dtpFechaFin.Value.Date.ToString();
                    pf2.CurrentValues.Add(pdv2);


                    ParameterDiscreteValue pdv3;
                    ParameterField pf3 = new ParameterField();

                    pf3.ParameterFieldName = "@TIPO_PRODUCTO";//no is a crystal report parameter name
                    pf3.CurrentValues.Clear();
                    pdv3 = new ParameterDiscreteValue();
                    pdv3.Value = (int)cboTipoProducto.SelectedValue;
                    pf3.CurrentValues.Add(pdv3);


                    ParameterDiscreteValue pdv4;
                    ParameterField pf4 = new ParameterField();

                    pf4.ParameterFieldName = "@TIPO_PRESENTACION";//no is a crystal report parameter name
                    pf4.CurrentValues.Clear();
                    pdv4 = new ParameterDiscreteValue();
                    pdv4.Value = (int)cboPresentacionProducto.SelectedValue;
                    pf4.CurrentValues.Add(pdv4);


                    crystalReportViewer1.ParameterFieldInfo = pds;
                }

                

                string spath = AppDomain.CurrentDomain.BaseDirectory;
                spath = spath.Substring(0, spath.Length - 10);
                spath += @"Reportes\rptHistoricoProducto.rpt";
                rd.Load(spath);
               
                crystalReportViewer1.ReportSource = rd;



            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }

        }



        private void rptHistoricoProducto1_InitReport(object sender, EventArgs e)
        {
           

        }

    }
}
