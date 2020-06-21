using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Katherin_Soto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnacerca_Click(object sender, EventArgs e)
        {

        }

        private void prestamosbtn_Click(object sender, EventArgs e)
        {
            AbrirFormPrestamo(new Prestamos());
        }

        private void Clientebtn_Click(object sender, EventArgs e)
        {
            AbrirFormCliente(new Cliente());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormCliente(object formcliente)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fc = formcliente as Form;
            fc.TopLevel = false;
            this.PanelContenedor.Controls.Add(fc);
            this.PanelContenedor.Tag = fc;
            fc.Show();
        }

        private void AbrirFormPrestamo (object formprestamo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fp = formprestamo as Form;
            fp.TopLevel = false;
            this.PanelContenedor.Controls.Add(fp);
            this.PanelContenedor.Tag = fp;
            fp.Show();
        }

        private void AbrirFormPrincipal(object formprincipal)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fp = formprincipal as Form;
            fp.TopLevel = false;
            this.PanelContenedor.Controls.Add(fp);
            this.PanelContenedor.Tag = fp;
            fp.Show();
        }
        
        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

            AbrirFormPrincipal(new Principal());
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {
            panelLogo_Paint(null, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new Principal());
        }
    }
}

   

