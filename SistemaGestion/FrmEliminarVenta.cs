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
    public partial class FrmEliminarVenta : Form
    {
        public FrmEliminarVenta()
        {
            InitializeComponent();
        }

        private Venta venta;
        public FrmEliminarVenta(Venta venta) : this()
        {
            this.venta = venta;
        }
        private void FrmEliminarVenta_Load(object sender, EventArgs e)
        {
            this.txtComentarios.Text = this.venta.Comentarios;
            this.txtIdUsuario.Text = venta.IdUsuario.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Contexto.EliminarVenta(venta);
            MessageBox.Show("Se grabo Correctamente");
        }
    }
}
