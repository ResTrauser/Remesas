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
    public partial class FrmClienteEmisor : Form
    {
        public FrmClienteEmisor()
        {
            InitializeComponent();
        }

        private ClienteEmisorDAO emisorDAO = new ClienteEmisorDAO();
        private PaisDAO paisDAO = new PaisDAO();

        private bool ValidarCodigo()
        {
            if (string.IsNullOrEmpty(txtCodigoEmisor.Text))
            {
                Error.SetError(txtCodigoEmisor, "Debe ingresar el codigo del cliente");
                return false;
            }
            else
            {
                Error.SetError(txtCodigoEmisor, "");
                return true;
            }
        }

        private bool ValidacionNombre()
        {
            if (string.IsNullOrEmpty(txtNombresEmisor.Text))
            {
                Error.SetError(txtNombresEmisor, "Debe ingresar el nombre del cliente");
                return false;
            }
            else
            {
                Error.SetError(txtNombresEmisor, "");
                return true;
            }
        }

        private bool Validacion1Apellido()
        {
            if (string.IsNullOrEmpty(txt1ApellidoEmisor.Text))
            {
                Error.SetError(txt1ApellidoEmisor,"Debe ingresar el primer apellido del cliente");
                return false;
            }
            else
            {
                Error.SetError(txt1ApellidoEmisor, "");
                return true;
            }
        }

        private bool Validacion2Apellido()
        {
            if (string.IsNullOrEmpty(txt2ApellidoEmisor.Text))
            {
                Error.SetError(txt2ApellidoEmisor, "Debe ingresar el segundo apellido");
                return false;
            }
            else
            {
                Error.SetError(txt2ApellidoEmisor, "");
                return true;
            }
        }

        private bool ValidacionDireccion()
        {
            if (string.IsNullOrEmpty(txtDireccionEmisor.Text))
            {
                Error.SetError(txtDireccionEmisor, "Debe ingresar la direccion del cliente");
                return false;
            }
            else
            {
                Error.SetError(txtDireccionEmisor, "");
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            ClienteEmisor emisor = new ClienteEmisor();

            if(ValidacionNombre() != true)
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
            string code = "Emi" + r.ToString();
            if (emisorDAO.Buscar(code) == null)
            {
                emisor.CodigoEmisor = code;
                emisor.NombresEmisor = txtNombresEmisor.Text.Trim();
                emisor.Apellido1Emisor = txt1ApellidoEmisor.Text.Trim();
                emisor.Apellido2Emisor = txt2ApellidoEmisor.Text.Trim();
                emisor.DireccionEmisor = txtDireccionEmisor.Text.Trim();
                emisor.TelefonoEmisor = int.Parse(txtNumeroTelefonico.Text);
                emisor.Cedula = txtCedula.Text.Trim();
                emisor.PaisId = (int)cboPais.SelectedValue;

                if (emisorDAO.Agregar(emisor) != false)
                    MessageBox.Show("El registro se guardo con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El registro no se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombresEmisor.Text = "";
                txt1ApellidoEmisor.Text = "";
                txt2ApellidoEmisor.Text = "";
                txtDireccionEmisor.Text = "";
                txtNumeroTelefonico.Text = "";
                txtCedula.Text = "";
                cboPais.SelectedIndex = -1;
            }
            else
                MessageBox.Show("Intenta guardarlo otra vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClienteEmisor emisor = new ClienteEmisor();
            if(ValidarCodigo() == false)
            {
                return;
            }
            emisor = emisorDAO.Buscar(txtCodigoEmisor.Text.Trim());
            if(emisor != null)
            {
                if (emisorDAO.Eliminar(emisor) == true)
                    MessageBox.Show("El registro se elimino correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El registro no se elimino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("El registro no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
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

            ClienteEmisor emisor = emisorDAO.Buscar(txtCodigoEmisor.Text);
            if(emisor != null)
            {
                emisor.NombresEmisor = txtNombresEmisor.Text.Trim();
                emisor.Apellido1Emisor = txt1ApellidoEmisor.Text.Trim();
                emisor.Apellido2Emisor = txt2ApellidoEmisor.Text.Trim();
                emisor.DireccionEmisor = txtDireccionEmisor.Text.Trim();
                emisor.TelefonoEmisor = int.Parse(txtNumeroTelefonico.Text);
                emisor.PaisId = (int)cboPais.SelectedValue;
                if (emisorDAO.Modificar(emisor) == true)
                    MessageBox.Show("El registro se modifico correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El registro no se modifico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("El registro no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void btnBuscarDato_Click(object sender, EventArgs e)
        {
            lblCodigoEmisor.Visible = true;
            txtCodigoEmisor.Visible = true;
            lblCedula.Visible = false;
            txtCedula.Visible = false;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;
            if (ValidarCodigo() == false)
            {
                return;
            }
            ClienteEmisor emisor = emisorDAO.Buscar(txtCodigoEmisor.Text);
            if (emisor != null)
            {
                txtNombresEmisor.Text = emisor.NombresEmisor;
                txt1ApellidoEmisor.Text = emisor.Apellido1Emisor;
                txt2ApellidoEmisor.Text = emisor.Apellido2Emisor;
                txtDireccionEmisor.Text = emisor.DireccionEmisor;
                txtNumeroTelefonico.Text = emisor.TelefonoEmisor.ToString();
                cboPais.SelectedValue = emisor.PaisId;
            }
            else
            {
                MessageBox.Show("El registro no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigoEmisor.Text = "";
            }
        }

        private void txtCodigoEmisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros y letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtNombresEmisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 33 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txt1ApellidoEmisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txt2ApellidoEmisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtDireccionEmisor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Limpiar()
        {
            txtCodigoEmisor.Text = "";
            txtNombresEmisor.Text = "";
            txt1ApellidoEmisor.Text = "";
            txt2ApellidoEmisor.Text = "";
            txtDireccionEmisor.Text = "";
            txtNumeroTelefonico.Text = "";
            txtCedula.Text = "";
            lblCedula.Visible = true;
            txtCedula.Visible = true;
            cboPais.SelectedIndex = -1;
            lblCodigoEmisor.Visible = false;
            txtCodigoEmisor.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmClienteEmisor_Load(object sender, EventArgs e)
        {
            cboPais.DataSource = paisDAO.Listar();
            cboPais.DisplayMember = "NombrePais";
            cboPais.ValueMember = "Id";
            cboPais.SelectedIndex = -1;
        }
    }
}
