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
    public partial class FrmModificarProductoVendido : Form
    {
        public FrmModificarProductoVendido()
        {
            InitializeComponent();
        }

        private ProductoVendido productoVendido;
        public FrmModificarProductoVendido(ProductoVendido productoVendido) : this()
        {
            this.productoVendido = productoVendido;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {

            this.productoVendido.Stock = numStock.Value;
            this.productoVendido.IdProducto = int.Parse(txtProducto.Text);
            this.productoVendido.IdVenta = int.Parse(txtVenta.Text);

            Contexto.ModificarProductoVendido(this.productoVendido);
            MessageBox.Show("Se grabo Correctamente");
        }

        private void FrmModificarProductoVendido_Load(object sender, EventArgs e)
        {
            this.numStock.Value = productoVendido.Stock;
            this.txtProducto.Text = productoVendido.IdProducto.ToString();
            this.txtVenta.Text = productoVendido.IdVenta.ToString();
        }
    }
}
