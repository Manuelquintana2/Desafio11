using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class FrmCrearProductoVendido : Form
    {
        public FrmCrearProductoVendido()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProductoVendido productoVendido = new ProductoVendido();


            productoVendido.Stock = numStock.Value;
            productoVendido.IdProducto = int.Parse(txtProducto.Text);
            productoVendido.IdVenta = int.Parse(txtVenta.Text);

            Contexto.CrearProductoVendido(productoVendido);
            MessageBox.Show("Se grabo Correctamente");
        }

        private void FrmCrearProductoVendido_Load(object sender, EventArgs e)
        {

        }
    }
}
