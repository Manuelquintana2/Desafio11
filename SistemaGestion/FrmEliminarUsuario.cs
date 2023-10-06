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
    public partial class FrmEliminarUsuario : Form
    {
        public FrmEliminarUsuario()
        {
            InitializeComponent();
        }
        private Usuario usuario;
        public FrmEliminarUsuario(Usuario usuario) : this()
        {
            this.usuario = usuario;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Contexto.EliminarUsuario(usuario);
            MessageBox.Show("Se grabo Correctamente");
        }

        private void FrmEliminarUsuario_Load(object sender, EventArgs e)
        { 
            this.txtNombre.Text = this.usuario.Nombre;
            this.txtApellido.Text = this.usuario.Apellido;
            this.txtNombreUsuario.Text = this.usuario.NombreUsuario;
            this.txtContraseña.Text = this.usuario.Contraseña;
            this.txtMail.Text = this.usuario.Mail;

        }
    }
}
