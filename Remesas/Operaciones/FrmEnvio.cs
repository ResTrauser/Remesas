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
    public partial class FrmEnvio : Form
    {
        public FrmEnvio()
        {
            InitializeComponent();
        }

        MonedaDAO monedaDAO = new MonedaDAO();
        EstadoRemesaDAO estadoRemesaDAO = new EstadoRemesaDAO();
        EnvioDAO envioDAO = new EnvioDAO();
        ClienteEmisorDAO emisorDAO = new ClienteEmisorDAO();
        ClienteReceptorDAO receptorDAO = new ClienteReceptorDAO();

        private void txtCodigoEnvio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros y letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtIdReceptor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtMontoPagado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtIdEmisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private bool ValidarIdEmisor()
        {
            if (string.IsNullOrEmpty(txtIdEmisor.Text))
            {
                Error.SetError(txtIdEmisor, "Debe ingresar el id del cliente emisor");
                return false;
            }
            else
            {
                Error.SetError(txtIdEmisor, "");
                return true;
            }
        }

        private bool ValidarIdReceptor()
        {
            if (string.IsNullOrEmpty(txtIdReceptor.Text))
            {
                Error.SetError(txtIdReceptor, "Debe ingresar el id del cliente receptor");
                return false;
            }
            else
            {
                Error.SetError(txtIdReceptor, "");
                return true;
            }
        }

        private bool ValidarMonto()
        {
            if (string.IsNullOrEmpty(txtMontoPagado.Text))
            {
                Error.SetError(txtMontoPagado, "Debe ingresar el monto a enviar");
                return false;
            }
            else
            {
                Error.SetError(txtMontoPagado, "");
                return true;
            }
        }

        private bool ValidarEstado()
        {
            if (cmbEstadoRemesa.SelectedIndex == -1)
            {
                Error.SetError(cmbEstadoRemesa, "Debe seleccionar un estado");
                return false;
            }
            else
            {
                Error.SetError(cmbEstadoRemesa, "");
                return true;
            }
        }

        private bool ValidarCambio()
        {
            if (cmbEstadoRemesa.SelectedIndex == -1)
            {
                Error.SetError(cmbEstadoRemesa, "Debe seleccionar una moneda");
                return false;
            }
            else
            {
                Error.SetError(cmbEstadoRemesa, "");
                return true;
            }
        }

        private bool GenerarCoidgoEnvio()
        {
            Random random = new Random();
            string code = "Env" + random.Next(100, 999).ToString();
            if (envioDAO.Buscar(code) == null)
            {
                txtCodigoEnvio.Text = code;
                return true;
            }
            else
                return false;
        }

        private bool GenerarCoidgoRetiro()
        {
            Random random = new Random();
            int code = random.Next(10000, 20000);
            if (envioDAO.ValidarRetiro(code) != null)
            {
                txtCodigoRetiro.Text = code.ToString();
                return true;
            }
            else
                return false;
        }

        private void FrmEnvio_Load(object sender, EventArgs e)
        {
            cmbEstadoRemesa.DataSource = estadoRemesaDAO.Listar();
            cmbEstadoRemesa.DisplayMember = "Estado";
            cmbEstadoRemesa.ValueMember = "Id";
            cmbEstadoRemesa.SelectedIndex = 0;

            cmbTipoCambio.DataSource = monedaDAO.Listar();
            cmbTipoCambio.DisplayMember = "TipoMoneda";
            cmbTipoCambio.ValueMember = "Id";
            cmbTipoCambio.SelectedIndex = -1;

            Random random = new Random();
            int codrec = random.Next(100, 200);
            if (envioDAO.ValidarRetiro(codrec) == null)
                txtCodigoRetiro.Text = codrec.ToString();
            else
                FrmEnvio_Load(sender, e);

            Random random2 = new Random();
            string codenv = "Env" + random.Next(100, 999).ToString();
            if (envioDAO.Buscar(codenv) == null)
                txtCodigoEnvio.Text = codenv;
            else
                FrmEnvio_Load(sender, e);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            uspCargarEmisorBindingSource.DataSource = emisorDAO.ProcCargarEmisor(txtNemi.Text);
            uspCargarReceptorBindingSource.DataSource = receptorDAO.ProcCargarReceptor(txtNrec.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarIdEmisor() != true)
                return;
            if (ValidarIdReceptor() != true)
                return;
            if (ValidarMonto() != true)
                return;
            if (ValidarEstado() != true)
                return;
            if (ValidarCambio() != true)
                return;
            Envio envio = new Envio();
            envio.CodigoEnvio = txtCodigoEnvio.Text.Trim();
            envio.CodigoRetiro = int.Parse(txtCodigoRetiro.Text);
            envio.EstadoRemesaId = (int)cmbEstadoRemesa.SelectedValue;
            envio.TipoDeCambioId = (int)cmbTipoCambio.SelectedValue;
            envio.FechaPago = dtpFechaEnvio.Value;
            envio.ClienteEmisorId = int.Parse(txtIdEmisor.Text);
            envio.ClienteReceptorId = int.Parse(txtIdReceptor.Text);
            envio.MontoPagado = Double.Parse(txtMontoPagado.Text);
            if (envioDAO.Agregar(envio) != false)
                MessageBox.Show("Registro guardado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("EL registro no se guardo correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCancelar_Click(sender, e);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmEnvio_Load(sender, e);
            txtIdEmisor.Text = "";
            txtIdReceptor.Text = "";
            txtNemi.Text = "";
            txtNrec.Text = "";
            txtMontoPagado.Text = "";
            uspCargarEmisorBindingSource.DataSource = "";
            uspCargarReceptorBindingSource.DataSource = "";

        }

        private void dgvEmisor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdEmisor.Text = dgvEmisor.CurrentCell.Value.ToString();
        }

        private void dgvReceptor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdReceptor.Text = dgvReceptor.CurrentCell.Value.ToString();
        }
    }
}
