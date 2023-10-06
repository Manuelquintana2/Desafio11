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
    public partial class FrmProductoVendido : Form
    {
        public FrmProductoVendido()
        {
            InitializeComponent();
        }

        private void FrmProductoVendido_Load(object sender, EventArgs e)
        {
            CargarProductosVendidos();
        }
        private void CargarProductosVendidos()
        {
            List<ProductoVendido> lista = Contexto.ListarProductosVendidos();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }
        private void FrmProductoVendido_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarProductosVendidos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FrmCrearProductoVendido frmCrearProductoVendido = new FrmCrearProductoVendido();
            frmCrearProductoVendido.FormClosed += FrmProductoVendido_FormClosed;
            frmCrearProductoVendido.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            ProductoVendido productoVendido = Contexto.ListarProductosVendidos().Where(x => x.Id == Id).FirstOrDefault();


            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                FrmModificarProductoVendido modificar = new FrmModificarProductoVendido(productoVendido);
                modificar.FormClosed += FrmProductoVendido_FormClosed;
                modificar.ShowDialog();
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                FrmEliminarProductoVendido eliminar = new FrmEliminarProductoVendido(productoVendido);
                eliminar.FormClosed += FrmProductoVendido_FormClosed;
                eliminar.ShowDialog();
            }
        }
    }
}
