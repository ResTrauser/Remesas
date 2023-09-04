using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemesasDAO.GestionUsuarios;
using RemesasEDM.ModeloSeguridad;

namespace Remesas.GestionUsuario
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        UsuarioDAO UsuarioDAO = new UsuarioDAO();

        private bool ValidarUsuario()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                Error.SetError(txtUsuario, "Debe de ingresar el nombre de usuario");
                return false;
            }
            else
            {
                Error.SetError(txtUsuario, "");
                return true;
            }
        }

        private bool ValidarClave()
        {
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                Error.SetError(txtClave, "Debe de ingresar la clave de usuario");
                return false;
            }
            else
            {
                Error.SetError(txtClave, "");
                return true;
            }
        }

        private bool ValidarExistencia ()
        {
            Usuario usuario = UsuarioDAO.Buscar(txtUsuario.Text);
            if (usuario != null && txtUsuario.Text == usuario.NombreUsuario)
            {
                Error.SetError(txtUsuario, "El usuario ya existe porfavor escoja otro nombre de usuario");
                return false;
            }
            else
            {
                Error.SetError(txtUsuario, "");
                return true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            if (ValidarClave() != true)
                return;
            if (ValidarUsuario() != true)
                return;
            if (ValidarExistencia() != true)
                return;

            usuario.NombreUsuario = txtUsuario.Text.Trim();
            usuario.ClaveUsuario = txtClave.Text.Trim();
            if (UsuarioDAO.CrearUsuario(usuario) != false)
                MessageBox.Show("El usuario " + txtUsuario.Text + " se creo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("El usuario" + txtUsuario.Text + " no se pudo crear", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnCancelar_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
            this.Close();
        }
    }
}
