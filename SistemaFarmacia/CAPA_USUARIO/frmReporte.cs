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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Web.UI;
using System.Web;
using System.IO;
using System.Reflection;
namespace CAPA_USUARIO
{
    public partial class frmReporte : Form
    {
        String codigo;
        String fecha;
        DetallesNEG dneg = new DetallesNEG();

        public frmReporte(String x, String y)
        {
            InitializeComponent();
            codigo = x;
            fecha = y;
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {

            /*
             
             */
            try
            {
                ReportDocument rd = new ReportDocument();
                ParameterField pf = new ParameterField();
                ParameterFields pds = new ParameterFields();
                ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                pf.Name = "@CODIGO";
                pdv.Value = codigo;
                pf.CurrentValues.Add(pdv);
                pds.Add(pf);
                crystalReportViewer1.ParameterFieldInfo = pds;
              
                string spath = AppDomain.CurrentDomain.BaseDirectory;
                spath = spath.Substring(0, spath.Length - 10);
                spath += "Reporte1.rpt";
                rd.Load(spath);
                rd.SetParameterValue("pCodigoVenta", codigo);
                rd.SetParameterValue("pFecha", fecha);
                crystalReportViewer1.ReportSource = rd;


            }
            catch (Exception)
            {

                throw;
            }

            //rp.SetDataSource(dneg.detalle_Venta_boleta(Convert.ToInt32(codigo)));

            //rp.SetParameterValue("@CODIGO", codigo);

            //crystalReportViewer1.ReportSource = rp;
            //ReportDocument rc = new ReportDocument();
            //rc.Load(@"C:\Users\Jesus\Desktop\SistemaFarmacia2017\SistemaFarmacia\CAPA_USUARIO\CrystalReport1.rpt");

            //rc.SetDataSource(dneg.detalle_Venta_boleta(Convert.ToInt32(codigo)));
            ////rp.SetParameterValue("pCodigoVenta", codigo);
            ////rp.SetParameterValue("pFecha", fecha);
            //rc.SetParameterValue("@CODIGO", Convert.ToInt32(codigo));
            //crystalReportViewer1.ReportSource = rc;
        }


    }
}
