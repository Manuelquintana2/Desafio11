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
    public partial class FrmModificarVenta : Form
    {
        public FrmModificarVenta()
        {
            InitializeComponent();
        }
        private Venta venta;
        public FrmModificarVenta(Venta venta) : this()
        {
            this.venta = venta;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.venta.Comentarios = txtComentarios.Text;
            this.venta.IdUsuario = int.Parse(txtIdUsuario.Text);

            Contexto.ModificarVentas(this.venta);
            MessageBox.Show("Se grabo Correctamente");
        }

        private void FrmModificarVenta_Load(object sender, EventArgs e)
        {
            this.txtComentarios.Text = this.venta.Comentarios;
            this.txtIdUsuario.Text = venta.IdUsuario.ToString();
        }
    }
}
