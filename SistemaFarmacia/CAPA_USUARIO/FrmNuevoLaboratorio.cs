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
    public partial class FrmNuevoLaboratorio : Form
    {

        LaboratorioEnt l;
        RegistrosNEG rneg = new RegistrosNEG();
        public FrmNuevoLaboratorio()
        {
            InitializeComponent();
        }

        private void FrmNuevoLaboratorio_Load(object sender, EventArgs e)
        {
            actualizaR_grilla();

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


            registrar_lab();
            actualizaR_grilla();
        }

        private void actualizaR_grilla()
        {
            dataGridView1.DataSource = rneg.lista_laboratorios().Tables[0];
        }

        private void registrar_lab() {
            l = new LaboratorioEnt();
            l.RAZON_SOCIAL1 = txtRazonsocial.Text;
            l.UBICACION1 = txtUbicacion.Text;
            l.TELEFONO1 = txtTelefono.Text;
            l.HORA_ATENCION1 = txtHoraatencion.Text;
            l.DIRECTOR1 = txtDirector.Text;

            rneg.registrar_laboratorio(l);
            MessageBox.Show("Laboratorio registrador correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
