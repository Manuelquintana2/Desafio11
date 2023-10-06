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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
        private void CargarUsuarios()
        {
            List<Usuario> lista = Contexto.ListarUsuarios();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void FormUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarUsuarios();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario usuario = new FrmCrearUsuario();
            usuario.FormClosed += FormUsuarios_FormClosed;
            usuario.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            Usuario usuario = Contexto.ListarUsuarios().Where(x => x.Id == Id).FirstOrDefault();


            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                FrmModificarUsuario modificar = new FrmModificarUsuario(usuario);
                modificar.FormClosed += FormUsuarios_FormClosed;
                modificar.ShowDialog();
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "BtnEliminar")
            {
                FrmEliminarUsuario eliminar = new FrmEliminarUsuario(usuario);
                eliminar.FormClosed += FormUsuarios_FormClosed;
                eliminar.ShowDialog();
            }
        }
    }
}
