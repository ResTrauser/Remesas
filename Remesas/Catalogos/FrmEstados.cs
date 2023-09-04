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
    public partial class FrmEstados : Form
    {
        public FrmEstados()
        {
            InitializeComponent();
        }

        EstadoRemesaDAO estadoRemesaDAO = new EstadoRemesaDAO();

        private bool ValidarEstado()
        {
            if (string.IsNullOrEmpty(txtEstado.Text))
            {
                Error.SetError(txtEstado, "Debe de ingresar un estado");
                return false;
            }
            else
            {
                Error.SetError(txtEstado, "");
                return true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarEstado() != true)
                return;

            EstadoRemesa estadoRemesa = new EstadoRemesa();
            Random random = new Random();
            string code;
            code = "Est" + random.Next(100, 1000).ToString();
            if (estadoRemesaDAO.Buscar(code) == null)
            {
                txtCodigoEstado.Text = code;
                estadoRemesa.CodigoEstadoRemesa = txtCodigoEstado.Text.Trim();
                estadoRemesa.Estado = txtEstado.Text.Trim();
                if (estadoRemesaDAO.Agregar(estadoRemesa) != false)
                    MessageBox.Show("Se guardo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se guardo correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
                MessageBox.Show("No se guardo intentalo otra vez", "Intentalo una vez mas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 33 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void FrmEstados_Load(object sender, EventArgs e)
        {
        }
    }
}
