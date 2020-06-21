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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        SQL consulta = new SQL(); // esto es para acceder a la clase SQL 

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            DataGridViewRow filas = dataGridView1.Rows[e.RowIndex]; // esto servira para saberque es es igual a la fila seleccionada 
            //(osea para que cuando yo seleccione una fila en el data grid se ponga en los textbox)
            txtid.Text = Convert.ToString(filas.Cells[0].Value); // esto es que el id (que esta en la posicion 0 se mostrara ahi)
            txtnombre.Text = Convert.ToString(filas.Cells[1].Value);
            txtapellido.Text = Convert.ToString(filas.Cells[2].Value);
            txttelefono.Text = Convert.ToString(filas.Cells[3].Value);
            txtdireccion.Text = Convert.ToString(filas.Cells[4].Value);
            txtcedula.Text = Convert.ToString(filas.Cells[5].Value);
            txtcorreo.Text = Convert.ToString(filas.Cells[6].Value);
            txtfecha.Text = Convert.ToString(filas.Cells[7].Value);
        }

        private void Cliente_Load(object sender, EventArgs e)
        { // ya aqui se muestran los datos y se accede a las tablas
            dataGridView1.DataSource = consulta.MostrarDatos();
        }

        private void btnguardarcl_Click(object sender, EventArgs e)
        { // Aqui comnezamos a insertar
            // aqui solo dice que se va a insertar lo que pongamos en el txt al data grid
            txtid.Text = dataGridView1.Rows.Count.ToString(); // esto es para que el id se incremente ya que no se puede tocr 


            if (consulta.Insertar(txtid.Text, txtnombre.Text,txtapellido.Text,txttelefono.Text,txtdireccion.Text,txtcedula.Text,txtcorreo.Text,txtfecha.Text))
            { // aqui solo dice que se va a insertar lo que pongamos en el txt al data grid
                MessageBox.Show("Datos insertados correctamente");
                dataGridView1.DataSource = consulta.MostrarDatos(); // aqui actualizamos la data con los nuevos valores
            } else MessageBox.Show("No se ha podido insertar los datos");

            // esto es solo borrar
            txtnombre.Clear();
            txtapellido.Clear();
            txtcedula.Clear();
            txtcorreo.Clear();
            txtfecha.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtid.Clear();
            /////
        }

        private void btnElimClie_Click(object sender, EventArgs e)
        {
           

            if (consulta.Eliminar(txtid.Text))
            {
                MessageBox.Show("Datos Eliminados correctamente");
                dataGridView1.DataSource = consulta.MostrarDatos();
            }
            else MessageBox.Show("No se ha podido Eliminar los datos");

            txtnombre.Clear();
            txtapellido.Clear();
            txtcedula.Clear();
            txtcorreo.Clear();
            txtfecha.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtid.Clear();
        }

        private void btneditclien_Click(object sender, EventArgs e)
        {

            if (consulta.Actualizar(txtid.Text, txtnombre.Text, txtapellido.Text, txttelefono.Text, txtdireccion.Text, txtcedula.Text, txtcorreo.Text, txtfecha.Text))
            {
                MessageBox.Show("Datos Actualizados correctamente");
                dataGridView1.DataSource = consulta.MostrarDatos();
            }
            else MessageBox.Show("No se ha actualizar los datos");

            txtnombre.Clear();
            txtapellido.Clear();
            txtcedula.Clear();
            txtcorreo.Clear();
            txtfecha.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtid.Clear();
        }

        
        private void txtbuscarcliente_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscarcliente.Text != "") // si el txt es algo 
             dataGridView1.DataSource = consulta.Buscar(txtbuscarcliente.Text); // aqui buscaremos automaticamente
                       else dataGridView1.DataSource = consulta.MostrarDatos(); // entonces mostraremos los datos
            
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlimpiarcliente_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtcedula.Clear();
            txtcorreo.Clear();
            txtfecha.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtid.Clear();
        }
    }
    }

