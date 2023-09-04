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
    public partial class FrmCobarar : Form
    {
        public FrmCobarar()
        {
            InitializeComponent();
        }
        EnvioDAO envioDAO = new EnvioDAO();

        private bool ValidarUsuario()
        {
            if (string.IsNullOrEmpty(txtCodRetiro.Text))
            {
                Error.SetError(txtCodRetiro, "Debe de ingresar el codigo de retiro");
                return false;
            }
            else
            {
                Error.SetError(txtCodRetiro, "");
                return true;
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(txtCodRetiro.Text);
            Envio envio = envioDAO.ValidarRetiro(cod);
            if (envio != null)
            {
                envio.EstadoRemesaId = 3;
                if (envioDAO.Modificar(envio) != false)
                {
                    MessageBox.Show("La remesa se a cobrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCobrar.DataSource = envioDAO.Listar(int.Parse(txtCodRetiro.Text));
                }
                else
                    MessageBox.Show("La remesa no se pudo cobrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("El registro no existe", "Valor inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodRetiro.Text = "";
            //dataEnvio1BindingSource.DataSource = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCobarar_Load(object sender, EventArgs e)
        {
            
        }

        private void txtCodRetiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
    }
}
