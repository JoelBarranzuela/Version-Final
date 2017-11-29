using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace CAPA_USUARIO
{

    public partial class frmInicio : Form
    {
        int data = 0;
        Process[] plist = Process.GetProcesses();
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            this.label1.BackColor = System.Drawing.Color.Transparent;


        }
        int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            if (data >= plist.Count() - 1)
            {
                data = 0;
                label1.Text = "Sistema cargandose , espere por favor";
            }
            else
            {
                data += 1;
                label1.Text = plist[data].ToString();
            }

            if (progressBar1.Value < 50)
            {
                progressBar1.Value += 1;

            }

            if (x == 60)
            {
                timer1.Stop();
                this.Close();
                new Login().Show();
                

            }

        }


    }
}
