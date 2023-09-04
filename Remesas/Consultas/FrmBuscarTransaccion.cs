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
    public partial class FrmBuscarTransaccion : Form
    {
        public FrmBuscarTransaccion()
        {
            InitializeComponent();
        }

        EnvioDAO envioDAO = new EnvioDAO();

        private void txtCodigoEnvio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo letras y numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private bool ValidarCodigo()
        {
            if (string.IsNullOrEmpty(txtCodigoEnvio.Text))
            {
                Error.SetError(txtCodigoEnvio, "Debe de ingresar el codigo de la transaccion");
                return false;
            }
            else
            {
                Error.SetError(txtCodigoEnvio, "");
                return true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarCodigo() != true)
                return;

            uspBuscarTransaccionBindingSource.DataSource = envioDAO.ProcBuscarEnvio(txtCodigoEnvio.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
