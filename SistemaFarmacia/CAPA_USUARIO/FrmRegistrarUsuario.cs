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
using System.Security.Cryptography;

namespace CAPA_USUARIO
{
    public partial class FrmRegistrarUsuario : Form
    {
        ConsultacomboNEG cneg = new ConsultacomboNEG();
        RegistrosNEG rneg = new RegistrosNEG();
        Usuario u;
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            cboTipoUsuario.DataSource = cneg.tipos_usuarios().Tables[0];
            cboTipoUsuario.ValueMember = "codigo";
            cboTipoUsuario.DisplayMember = "nombre";

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

            u = new Usuario();
            u.Username = txtUsuario.Text;
            MD5 md5Hash = MD5.Create();
            string hash = GetMd5Hash(md5Hash, txtPassword.Text);
            u.Password = hash;
            u.Tipo_usuario = Convert.ToInt32(cboTipoUsuario.SelectedValue);
            u.Descripcion = txtDescripcion.Text;
            int codigo = rneg.registrar_usuario(u);
            FrmDetalleUsuario frmdetalle = new FrmDetalleUsuario(codigo);
            frmdetalle.Show();
            this.Close();

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
