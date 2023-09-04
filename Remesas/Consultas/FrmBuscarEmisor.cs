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
    public partial class FrmBuscarEmisor : Form
    {
        public FrmBuscarEmisor()
        {
            InitializeComponent();
        }

        ClienteEmisorDAO emisorDAO = new ClienteEmisorDAO();

        private void txtNombreEmisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 33 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidoEmisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtNombreEmisor.Text))
            {
                Error.SetError(txtNombreEmisor, "Debe de ingresar el nombre del cliente");
                return false;
            }
            else
            {
                Error.SetError(txtNombreEmisor, "");
                return true;
            }
        }

        private bool ValidarApellido()
        {
            if (string.IsNullOrEmpty(txtApellidoEmisor.Text))
            {
                Error.SetError(txtApellidoEmisor, "Debe de ingresar el apellido del cliente");
                return false;
            }
            else
            {
                Error.SetError(txtApellidoEmisor, "");
                return true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() != true)
                return;
            if (ValidarApellido() != true)
                return;

            uspBuscarClienteBindingSource.DataSource = emisorDAO.ProcBuscarEmisor(txtNombreEmisor.Text, txtApellidoEmisor.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
