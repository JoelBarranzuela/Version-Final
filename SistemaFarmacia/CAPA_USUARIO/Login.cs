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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        ConsultacomboNEG cneg = new ConsultacomboNEG();
        Usuario u;


        private void button1_Click(object sender, EventArgs e)
        {
            u = new Usuario();
            u.Username = txtusuario.Text;
            MD5 md5Hash = MD5.Create();
            string hash = GetMd5Hash(md5Hash, txtpassword.Text);
            u.Password = hash;

            DataSet ds = cneg.confirmar_acceso(u);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Usuario autentificado correctamente");
                Credenciales.Username = txtusuario.Text;
                Credenciales.Password = hash;
                Credenciales.CodigoUsuario = (int)ds.Tables[0].Rows[0][0];
                Credenciales.Tipo_usuario_cod = (int)ds.Tables[0].Rows[0][1];

                new Menu().Show(); this.Visible = false; 
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
            
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
           // this.BackColor = System.Drawing.ColorTranslator.FromHtml("#C3C3C3");
            foreach (Control c in this.Controls)
            {
                if (c is Label) {
                   c.ForeColor = System.Drawing.Color.Transparent;
                   
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.Environment.Exit(1);
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("El sistema se cerrara , desea continuar ?","Cerrar Sistema", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;

            }
        }
    }
}
