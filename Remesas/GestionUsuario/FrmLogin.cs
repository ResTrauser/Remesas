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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public int Idusuario = 0;
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Usuario usuario = usuarioDAO.Buscar(txtUsuario.Text.Trim());
            if (ValidarUsuario() != true)
                return;
            if (ValidarClave() != true)
                return;

            if (usuario != null && usuario.ClaveUsuario == txtClave.Text.Trim())
            {
                MessageBox.Show("Bienvenido " + usuario.NombreUsuario);
                txtUsuario.Text = "";
                txtClave.Text = "";
                txtUsuario.Focus();
                Idusuario = usuario.Id;
                this.Close();
            }
            else
                MessageBox.Show("El usuario no existe", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros y letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros y letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
    }
}
