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
    public partial class FrmCambioDia : Form
    {
        public FrmCambioDia()
        {
            InitializeComponent();
        }

        TipoDeCambioDAO TipoDeCambioDAO = new TipoDeCambioDAO();
        MonedaDAO monedaDAO = new MonedaDAO();

        private void FrmCambioDia_Load(object sender, EventArgs e)
        {
            cboTipoMoneda.DataSource = monedaDAO.Listar();
            cboTipoMoneda.DisplayMember = "TipoMoneda";
            cboTipoMoneda.ValueMember = "Id";
            cboTipoMoneda.SelectedIndex = -1;

            Random random = new Random();
            string code = "Camb" + random.Next(0, 100).ToString();
            TipoDeCambio tipo = TipoDeCambioDAO.Buscar(code);
            if (tipo == null)
                txtCodigoCambio.Text = code;
            else
                FrmCambioDia_Load(sender, e);
        }

        private void txtCambioDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 45 || e.KeyChar == 47 ||e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private bool validarCodigo()
        {
            if (string.IsNullOrEmpty(txtCodigoCambio.Text))
            {
                Error.SetError(txtCodigoCambio, "Debe ingresar el codigo del cambio");
                return false;
            }
            else
            {
                Error.SetError(txtCodigoCambio, "");
                return true;
            }
        }

        private bool ValidarCambio()
        {
            if (string.IsNullOrEmpty(txtCambioDia.Text))
            {
                Error.SetError(txtCambioDia, "Debe de ingresar el tipo de cambio");
                return false;
            }
            else
            {
                Error.SetError(txtCambioDia, "");
                return true;
            }
        }

        private bool validarMoneda()
        {
            if(cboTipoMoneda.SelectedIndex == -1)
            {
                Error.SetError(cboTipoMoneda, "Seleccione una moneda");
                return false;
            }
            else
            {
                Error.SetError(cboTipoMoneda, "");
                return true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TipoDeCambio tipoDeCambio = new TipoDeCambio();
            if (ValidarCambio() != true)
                return;
            if (validarMoneda() != true)
                return;

            tipoDeCambio.CodigoTipoCambio = txtCodigoCambio.Text.Trim();
            tipoDeCambio.CambioDia = Double.Parse(txtCambioDia.Text);
            tipoDeCambio.FechaTipoCambio = dtFechaCambio.Value;
            tipoDeCambio.MonedaId = (int)cboTipoMoneda.SelectedValue;
            if(TipoDeCambioDAO.Agregar(tipoDeCambio) != false)
                MessageBox.Show("El registro se guardo con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("El registro no se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCambioDia.Text = "";
            cboTipoMoneda.SelectedIndex = -1;
            FrmCambioDia_Load(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtCodigoCambio.Enabled = true;
            if (validarCodigo() != true)
                return;
            TipoDeCambio tipoDeCambio = TipoDeCambioDAO.Buscar(txtCodigoCambio.Text);
            if(tipoDeCambio != null)
            {
                if(TipoDeCambioDAO.Eliminar(tipoDeCambio) != false)
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
            txtCambioDia.Text = "";
            cboTipoMoneda.SelectedIndex = -1;
            txtCodigoCambio.Enabled = false;
            FrmCambioDia_Load(sender, e);
        }
    }
}
