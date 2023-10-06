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
    public partial class FrmModificarUsuario : Form
    {
        public FrmModificarUsuario()
        {
            InitializeComponent();
        }
        private Usuario usuario;
        public FrmModificarUsuario(Usuario usuario) : this()
        {
            this.usuario = usuario;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.usuario.Nombre = txtNombre.Text;
            this.usuario.Apellido = txtApellido.Text;
            this.usuario.NombreUsuario = txtNombreUsuario.Text;
            this.usuario.Contraseña = txtContraseña.Text;
            this.usuario.Mail = txtMail.Text;

            Contexto.ModificarUsuario(this.usuario);
            MessageBox.Show("Se grabo Correctamente");
        }

        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = this.usuario.Nombre;
            this.txtApellido.Text = this.usuario.Apellido;
            this.txtNombreUsuario.Text = this.usuario.NombreUsuario;
            this.txtContraseña.Text = this.usuario.Contraseña;
            this.txtMail.Text = this.usuario.Mail;
        }
    }
}
