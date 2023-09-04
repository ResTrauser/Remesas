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
    public partial class FrmClienteReceptor : Form
    {
        public FrmClienteReceptor()
        {
            InitializeComponent();
        }

        private ClienteReceptorDAO receptorDAO = new ClienteReceptorDAO();
        private PaisDAO paisDAO = new PaisDAO();

        private void FrmClienteReceptor_Load(object sender, EventArgs e)
        {
            cboPais.DataSource = paisDAO.Listar();
            cboPais.DisplayMember = "NombrePais";
            cboPais.ValueMember = "Id";
            cboPais.SelectedIndex = -1;
        }

        private bool ValidarCodigo()
        {
            if (string.IsNullOrEmpty(txtCodigoReceptor.Text))
            {
                Error.SetError(txtCodigoReceptor, "Debe ingresar el codigo del cliente");
                return false;
            }
            else
            {
                Error.SetError(txtCodigoReceptor, "");
                return true;
            }
        }

        private bool ValidacionNombre()
        {
            if (string.IsNullOrEmpty(txtNombreReceptor.Text))
            {
                Error.SetError(txtNombreReceptor, "Debe ingresar el nombre del cliente");
                return false;
            }
            else
            {
                Error.SetError(txtNombreReceptor, "");
                return true;
            }
        }

        private bool Validacion1Apellido()
        {
            if (string.IsNullOrEmpty(txt1ApellidoReceptor.Text))
            {
                Error.SetError(txt1ApellidoReceptor, "Debe ingresar el primer apellido del cliente");
                return false;
            }
            else
            {
                Error.SetError(txt1ApellidoReceptor, "");
                return true;
            }
        }

        private bool Validacion2Apellido()
        {
            if (string.IsNullOrEmpty(txt2ApellidoReceptor.Text))
            {
                Error.SetError(txt2ApellidoReceptor, "Debe ingresar el segundo apellido");
                return false;
            }
            else
            {
                Error.SetError(txt2ApellidoReceptor, "");
                return true;
            }
        }

        private bool ValidacionDireccion()
        {
            if (string.IsNullOrEmpty(txtDireccionReceptor.Text))
            {
                Error.SetError(txtDireccionReceptor, "Debe ingresar la direccion del cliente");
                return false;
            }
            else
            {
                Error.SetError(txtDireccionReceptor, "");
                return true;
            }
        }

        private bool ValidacionCedula()
        {
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                Error.SetError(txtCedula, "Debe ingresar la cedula del cliente");
                return false;
            }
            else
            {
                Error.SetError(txtCedula, "");
                return true;
            }
        }

        private bool FormatoCedula()
        {
            if (!txtCedula.Text.Substring(0, 12).All(char.IsDigit) || !txtCedula.Text.Substring(13).All(char.IsLetter) || txtCedula.Text.ToString().Length > 14 || txtCedula.Text.ToString().Length < 14)
            {
                Error.SetError(txtCedula, "El formato es incorrecto, se necesitan 13 numeros y una letra al final");
                txtCedula.Text = string.Empty;
                return false;
            }
            else
            {
                Error.SetError(txtCedula, "");
                return true;
            }
        }

        private bool ValidacionTelefono()
        {
            if (string.IsNullOrEmpty(txtNumeroTelefonico.Text) || txtNumeroTelefonico.Text.Length > 8 || txtNumeroTelefonico.Text.Length < 8)
            {
                Error.SetError(txtNumeroTelefonico, "Debe ingresar el telefono del cliente correctamente");
                return false;
            }
            else
            {
                Error.SetError(txtNumeroTelefonico, "");
                return true;
            }
        }

        private bool ValidacionPais()
        {
            if (cboPais.SelectedIndex == -1)
            {
                Error.SetError(cboPais, "Debe ingresar el id del pais");
                return false;
            }
            else
            {
                Error.SetError(cboPais, "");
                return true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpiar()
        {
            txtCodigoReceptor.Text = "";
            txtNombreReceptor.Text = "";
            txt1ApellidoReceptor.Text = "";
            txt2ApellidoReceptor.Text = "";
            txtDireccionReceptor.Text = "";
            txtNumeroTelefonico.Text = "";
            txtCedula.Text = "";
            lblCedula.Visible = true;
            txtCedula.Visible = true;
            cboPais.SelectedIndex = -1;
            lblCodigoReceptor.Visible = false;
            txtCodigoReceptor.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            ClienteReceptor receptor = new ClienteReceptor();

            if (ValidacionNombre() != true)
                return;
            if (Validacion1Apellido() != true)
                return;
            if (ValidacionDireccion() != true)
                return;
            if (ValidacionTelefono() != true)
                return;
            if (ValidacionCedula() != true)
                return;
            if (FormatoCedula() != true)
                return;
            if (ValidacionPais() != true)
                return;

            var r = random.Next(100, 1000);
            string code = "Rec" + r.ToString();
            if (receptorDAO.Buscar(code) == null)
            {
                receptor.CodigoReceptor = code;
                receptor.NombresReceptor = txtNombreReceptor.Text.Trim();
                receptor.Apellido1Receptor = txt1ApellidoReceptor.Text.Trim();
                receptor.Apellido2Receptor = txt2ApellidoReceptor.Text.Trim();
                receptor.DireccionReceptor = txtDireccionReceptor.Text.Trim();
                receptor.TelefonoReceptor = int.Parse(txtNumeroTelefonico.Text);
                receptor.Cedula = txtCedula.Text.Trim();
                receptor.PaisId = (int)cboPais.SelectedValue;

                if (receptorDAO.Agregar(receptor) != false)
                    MessageBox.Show("El registro se guardo con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El registro no se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreReceptor.Text = "";
                txt1ApellidoReceptor.Text = "";
                txt2ApellidoReceptor.Text = "";
                txtDireccionReceptor.Text = "";
                txtNumeroTelefonico.Text = "";
                txtCedula.Text = "";
                cboPais.SelectedIndex = -1;
            }
            else
                MessageBox.Show("Intenta guardarlo otra vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblCodigoReceptor.Visible = true;
            txtCodigoReceptor.Visible = true;
            lblCedula.Visible = false;
            txtCedula.Visible = false;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;
            if (ValidarCodigo() == false)
            {
                return;
            }
            ClienteReceptor emisor = receptorDAO.Buscar(txtCodigoReceptor.Text);
            if (emisor != null)
            {
                txtNombreReceptor.Text = emisor.NombresReceptor;
                txt1ApellidoReceptor.Text = emisor.Apellido1Receptor;
                txt2ApellidoReceptor.Text = emisor.Apellido2Receptor;
                txtDireccionReceptor.Text = emisor.DireccionReceptor;
                txtNumeroTelefonico.Text = emisor.TelefonoReceptor.ToString();
                cboPais.SelectedValue = emisor.PaisId;
            }
            else
            {
                MessageBox.Show("El registro no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigoReceptor.Text = "";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarCodigo() == false)
                return;
            if (ValidacionNombre() != true)
                return;
            if (Validacion1Apellido() != true)
                return;
            if (Validacion2Apellido() != true)
                return;
            if (ValidacionDireccion() != true)
                return;
            if (ValidacionTelefono() != true)
                return;
            if (ValidacionPais() != true)
                return;

            ClienteReceptor receptor = receptorDAO.Buscar(txtCodigoReceptor.Text);
            if (receptor != null)
            {
                receptor.NombresReceptor = txtNombreReceptor.Text.Trim();
                receptor.Apellido1Receptor = txt1ApellidoReceptor.Text.Trim();
                receptor.Apellido2Receptor = txt2ApellidoReceptor.Text.Trim();
                receptor.DireccionReceptor = txtDireccionReceptor.Text.Trim();
                receptor.TelefonoReceptor = int.Parse(txtNumeroTelefonico.Text);
                receptor.PaisId = (int)cboPais.SelectedValue;
                if (receptorDAO.Modificar(receptor) == true)
                    MessageBox.Show("El registro se modifico correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El registro no se modifico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("El registro no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnCancelar_Click(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClienteReceptor receptor = new ClienteReceptor();
            if (ValidarCodigo() == false)
            {
                return;
            }
            receptor = receptorDAO.Buscar(txtCodigoReceptor.Text.Trim());
            if (receptor != null)
            {
                if (receptorDAO.Eliminar(receptor) == true)
                    MessageBox.Show("El registro se elimino correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El registro no se elimino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("El registro no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void txtCodigoReceptor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros y letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
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

        private void txt1ApellidoReceptor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txt2ApellidoReceptor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtDireccionReceptor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 33 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo letras y numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtNumeroTelefonico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo letras y numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
    }
}