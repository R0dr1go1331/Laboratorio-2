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
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
        }

        private void Listape_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            ClsPersona clsPersona = new ClsPersona();
            var ok = clsPersona.ListaFinal();

            foreach (var iterar in ok)
            {
                Listape.Rows.Add(iterar.nombrePersona, iterar.edadPersona, iterar.descripcionPersona);
            }
        }
    }
}
