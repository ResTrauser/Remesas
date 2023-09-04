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

namespace Remesas.Catalogos
{
    public partial class FrmBuscarMoneda : Form
    {
        public FrmBuscarMoneda()
        {
            InitializeComponent();
        }

        TipoDeCambioDAO tipoDeCambioDAO = new TipoDeCambioDAO();

        private void txtNombreMoneda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 33 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtNombreMoneda.Text))
            {
                Error.SetError(txtNombreMoneda, "Debe de ingresar el nombre de la moneda");
                return false;
            }
            else
            {
                Error.SetError(txtNombreMoneda, "");
                return true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() != true)
                return;

            uspBuscarMonedaBindingSource.DataSource = tipoDeCambioDAO.ProcBuscarMoneda(txtNombreMoneda.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
