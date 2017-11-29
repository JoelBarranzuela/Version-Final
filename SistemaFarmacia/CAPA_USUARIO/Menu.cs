using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CAPA_ENTIDAD;
using System.Security.Cryptography;
using System.Globalization;
namespace CAPA_USUARIO
{
    public partial class Menu : Form
    {
        Venta v;
        public Menu()
        {

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Productos().Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (Credenciales.Tipo_usuario_cod != 1)
            {
                registrarToolStripMenuItem.Enabled = false;
                editarToolStripMenuItem.Enabled = false;
               
            }
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                    c.BackColor = Color.White;
            }

            toolStripButton4.Text = "Bievenido Usuario : " + Credenciales.Username;




        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            v = new Venta();
            v.Show();
        }




        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v = new Venta();
            v.MdiParent = this;
            v.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
                this.Close();
        }

        private void toolStripButton1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightBlue;
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v = new Venta();
            v.MdiParent = this;
            v.Show();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario frm1 = new FrmRegistrarUsuario();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void nuevoProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNuevoProducto frnp = new frmNuevoProducto();
            frnp.MdiParent = this;
            frnp.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Estas seguro de cerrar el menu principal ? Sera redirigido al Login", "Salir del menu principal", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new Login().Show();
                this.Dispose();
            }
            else
            {
                e.Cancel = true;

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            v = new Venta();
            v.MdiParent = this;
            v.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime localDate = DateTime.Now;

            var culture = new CultureInfo("fr-FR");
            tsmfechayhora.Text = "Fecha y Hora del Sistema  " + localDate.ToString(culture);
           
        }

        private void toolStripButton1_MouseHover_1(object sender, EventArgs e)
        {
            toolStripButton1.BackColor = System.Drawing.Color.LightBlue;
        }

        private void toolStripButton1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void estadoDeTransaccionVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentaDetalle frmdet = new frmVentaDetalle();
            frmdet.MdiParent = this;
            frmdet.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmStockActual frmst = new frmStockActual();
            frmst.MdiParent = this;
            frmst.Show();
        }

        private void actualizarTipoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoLaboratorio frnl = new FrmNuevoLaboratorio();
            frnl.MdiParent = this;
            frnl.Show();
        }

        private void nuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoProveedor frmpr = new frmNuevoProveedor();
            frmpr.MdiParent = this;
            frmpr.Show();
        }

        public Menu formulario()
        {
            return this;
        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actualizarDatosUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosMasVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteProductoVendido rptp = new frmReporteProductoVendido();
            rptp.MdiParent = this;
            rptp.Show();
        }

        private void ventasPorRangoDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentasporFechas rvpf = new frmVentasporFechas();
            rvpf.MdiParent = this;
            rvpf.Show();
        }

        private void datosLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarVentanasAbiertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                    frm.Dispose(); 
            }
        }
    }
}
