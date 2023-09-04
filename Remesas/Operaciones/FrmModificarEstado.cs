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
    public partial class FrmModificarEstado : Form
    {
        public FrmModificarEstado()
        {
            InitializeComponent();
        }
        EnvioDAO envioDAO = new EnvioDAO();
        EstadoRemesaDAO estadoDAO = new EstadoRemesaDAO();

        private bool ValidarCodigo()
        {
            if (string.IsNullOrEmpty(txtCodEnvio.Text))
            {
                Error.SetError(txtCodEnvio, "Debe de ingresar el codigo de la transacción");
                return false;
            }
            else
            {
                Error.SetError(txtCodEnvio, "");
                return true;
            }
        }

        private bool ValidarUsuario()
        {
            if (cmbEstado.SelectedIndex == -1)
            {
                Error.SetError(cmbEstado, "Debe de escoger un estado");
                return false;
            }
            else
            {
                Error.SetError(cmbEstado, "");
                return true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Envio envio = envioDAO.Buscar(txtCodEnvio.Text);
            if (envio != null)
                uspBuscarTransaccionBindingSource.DataSource = envioDAO.ProcBuscarEnvio(txtCodEnvio.Text);
            else
                MessageBox.Show("El registro no existe", "Valor inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Envio envio = envioDAO.Buscar(txtCodEnvio.Text);
            envio.EstadoRemesaId = (int)cmbEstado.SelectedValue;
            if(envioDAO.Modificar(envio) != false)
                MessageBox.Show("El registro se modifico", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("El registro no se modifico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCancelar_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodEnvio.Text = "";
            cmbEstado.SelectedIndex = -1;
            uspBuscarTransaccionBindingSource.DataSource = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmModificarEstado_Load(object sender, EventArgs e)
        {
            cmbEstado.DataSource = estadoDAO.Listar();
            cmbEstado.DisplayMember = "Estado";
            cmbEstado.ValueMember = "Id";
            cmbEstado.SelectedItem = -1;
        }

        private void txtCodEnvio_KeyPress(object sender, KeyPressEventArgs e)
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
