using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantillaMvc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controlador.ProductosControler ObjetController = new Controlador.ProductosControler();
            var cargadata = ObjetController.MostrarProduc();
            dataGridView1.DataSource = cargadata;
            lblCantidadProductos.Text = cargadata.Rows.Count.ToString();
            double suma = 0;
            foreach (DataRow item in cargadata.Rows)
            {
                suma = suma + double.Parse(item[5].ToString());
            }
            lblPrecio.Text = suma.ToString();
        }
    }
}
