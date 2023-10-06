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
    public partial class FrmCrearVenta : Form
    {
        public FrmCrearVenta()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();

            venta.Comentarios = txtComentarios.Text;
            venta.IdUsuario = int.Parse(txtIdUsuario.Text);

            Contexto.CrearVentas(venta);
            MessageBox.Show("Se grabo Correctamente");
        }
    }
}
