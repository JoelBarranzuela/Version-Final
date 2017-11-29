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
    public partial class FrmDetalleUsuario : Form
    {
        int xcodigo;
        DetallesNEG dneg = new DetallesNEG();
        public FrmDetalleUsuario(int codigo)
        {
            this.xcodigo = codigo;
            InitializeComponent();
        }

        private void FrmDetalleUsuario_Load(object sender, EventArgs e)
        {
            DataSet ds = dneg.detalle_nuevo_usuario(xcodigo);
            lblcodigo.Text = ds.Tables[0].Rows[0][0].ToString();
            lblusername.Text = ds.Tables[0].Rows[0][1].ToString();
            lblpassword.Text = ds.Tables[0].Rows[0][2].ToString();
            lbltipousuario.Text = ds.Tables[0].Rows[0][3].ToString();
            lblregistrado.Text = ds.Tables[0].Rows[0][4].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario fr = new FrmRegistrarUsuario();
            Menu m = new Menu();
            fr.MdiParent = m.formulario();
            fr.Show();
            this.Close();
        }
    }
}
