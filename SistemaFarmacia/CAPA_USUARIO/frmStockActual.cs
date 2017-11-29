using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CAPA_NEGOCIO;
using System.Windows.Forms;

namespace CAPA_USUARIO
{
    public partial class frmStockActual : Form
    {
        ConsultaNEG cneg = new ConsultaNEG();
        private const int totalRecords = 0;
        private const int pageSize = 10;


        public frmStockActual()
        {
            InitializeComponent();
            //const int  x = cneg.listar_medicamentos().Tables[0].Rows.Count;
            //totalRecords  = cneg.listar_medicamentos().Tables[0].Rows.Count;
            


            //dgvMedicamentos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Index" });
            //bindingNavigator1.BindingSource = bindingSource1;
            //bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            //bindingSource1.DataSource = new PageOffsetList();



        }

        private void frmStockActual_Load(object sender, EventArgs e)
        {
            listar_medicamentos();
            listar_otros_prod();
        }

        private void listar_medicamentos()
        {
            dgvMedicamentos.DataSource = cneg.listar_medicamentos().Tables[0];
        }

        private void listar_otros_prod() {
            dataGridView2.DataSource = cneg.listar_otros_productos().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listar_medicamentos();
            listar_otros_prod();
        }

        //private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        //{
        //    // The desired page has changed, so fetch the page of records using the "Current" offset 
        //    int offset = (int)bindingSource1.Current;
        //    var records = new List<Record>();
        //    for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
        //        records.Add(new Record { Index = i });
        //    dgvMedicamentos.DataSource = records;
        //}

        //class Record
        //{
        //    public int Index { get; set; }
        //}

        //class PageOffsetList : System.ComponentModel.IListSource
        //{
        //    public bool ContainsListCollection { get; protected set; }

        //    public System.Collections.IList GetList()
        //    {
        //        // Return a list of page offsets based on "totalRecords" and "pageSize"
        //        var pageOffsets = new List<int>();
        //        for (int offset = 0; offset < totalRecords; offset += pageSize)
        //            pageOffsets.Add(offset);
        //        return pageOffsets;
        //    }
        //}

    }
}
