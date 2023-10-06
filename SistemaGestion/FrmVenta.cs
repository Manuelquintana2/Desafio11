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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }
        private void CargarVentas()
        {
            List<Venta> lista = Contexto.ListarVentas();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void FrmVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarVentas();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FrmCrearVenta venta = new FrmCrearVenta();
            venta.FormClosed += FrmVenta_FormClosed;
            venta.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            Venta venta = Contexto.ListarVentas().Where(x => x.Id == Id).FirstOrDefault();


            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                FrmModificarVenta modificar = new FrmModificarVenta(venta);
                modificar.FormClosed += FrmVenta_FormClosed;
                modificar.ShowDialog();
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                FrmEliminarVenta eliminar = new FrmEliminarVenta(venta);
                eliminar.FormClosed += FrmVenta_FormClosed;
                eliminar.ShowDialog();
            }
        }
    }
}
