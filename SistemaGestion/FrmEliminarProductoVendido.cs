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
    public partial class FrmEliminarProductoVendido : Form
    {
        public FrmEliminarProductoVendido()
        {
            InitializeComponent();
        }
        private ProductoVendido productoVendido;
        public FrmEliminarProductoVendido(ProductoVendido productoVendido) : this()
        {
            this.productoVendido = productoVendido;
        }

        private void FrmEliminarProductoVendido_Load(object sender, EventArgs e)
        {
            Contexto.EliminarProductoVendido(this.productoVendido);
            MessageBox.Show("Se grabo Correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.numStock.Value = productoVendido.Stock;
            this.txtProducto.Text = productoVendido.IdProducto.ToString();
            this.txtVenta.Text = productoVendido.IdVenta.ToString();
        }
    }
}
