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
    public partial class FrmMoneda : Form
    {
        public FrmMoneda()
        {
            InitializeComponent();
        }

        MonedaDAO monedaDAO = new MonedaDAO();

        private void txtIdMoneda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtNombrePais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 33 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private bool ValidarId()
        {
            if (string.IsNullOrEmpty(txtIdMoneda.Text))
            {
                Error.SetError(txtIdMoneda, "Debe ingresar el Id del Pais");
                return false;
            }
            else
            {
                Error.SetError(txtIdMoneda, "");
                return true;
            }
        }

        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtTipoMoneda.Text))
            {
                Error.SetError(txtTipoMoneda, "Debe ingresar el nombre del Pais");
                return false;
            }
            else
            {
                Error.SetError(txtTipoMoneda, "");
                return true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Moneda moneda = new Moneda();
            if (ValidarNombre() != true)
                return;
            moneda.TipoMoneda = txtTipoMoneda.Text.Trim();
            if(monedaDAO.Agregar(moneda) != false)
                MessageBox.Show("El registro se guardo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("El registro no se guardo correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtTipoMoneda.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtIdMoneda.Enabled = true;
            if (ValidarId() != true)
                return;

            Moneda moneda = monedaDAO.Buscar(int.Parse(txtIdMoneda.Text));
            if(moneda != null)
            {
                if(monedaDAO.Eliminar(moneda) != false)
                    MessageBox.Show("El registro se elimino correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El registro no se elimino correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("El registro no existe", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btnCancelar_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdMoneda.Enabled = false;
            txtIdMoneda.Text = "";
            txtTipoMoneda.Text = "";
        }
    }
}
