using Laboratorio2.Data;
using Laboratorio2.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2.Vista
{
    public partial class FrmGuardar : Form
    {
        public FrmGuardar()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona Per = new persona();
            Per.nombrePersona = Nombre.Text;
            Per.edadPersona = Convert.ToInt32(Edad.Text);
            Per.descripcionPersona = Descripccion.Text;
            ClsPersona clsPersona = new ClsPersona();
            clsPersona.Almacenar(Per);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar();
            frmMostrar.Show();

        }
    }
}
