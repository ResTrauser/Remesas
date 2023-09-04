using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemesasDAO.DAO;
using RemesasEDM.ModeloApp;

namespace Remesas.Catalogos
{
    public partial class FrmBuscarReceptor : Form
    {
        public FrmBuscarReceptor()
        {
            InitializeComponent();
        }

        ClienteReceptorDAO receptorDAO = new ClienteReceptorDAO();

        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtNombreReceptor.Text))
            {
                Error.SetError(txtNombreReceptor, "Debe de ingresar el nombre del cliente");
                return false;
            }
            else
            {
                Error.SetError(txtNombreReceptor, "");
                return true;
            }
        }

        private bool ValidarApellido()
        {
            if (string.IsNullOrEmpty(txtApellidoReceptor.Text))
            {
                Error.SetError(txtApellidoReceptor, "Debe de ingresar el apellido del cliente");
                return false;
            }
            else
            {
                Error.SetError(txtApellidoReceptor, "");
                return true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() != true)
                return;
            if (ValidarApellido() != true)
                return;
            uspBuscarClienteReceptorBindingSource.DataSource = receptorDAO.ProcBuscarReceptor(txtNombreReceptor.Text,txtApellidoReceptor.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNombreReceptor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 33 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidoReceptor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void FrmBuscarReceptor_Load(object sender, EventArgs e)
        {

        }
    }
}
