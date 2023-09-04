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
    public partial class FrmPais : Form
    {
        public FrmPais()
        {
            InitializeComponent();
        }
        PaisDAO paisDAO = new PaisDAO();

        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtNombrePais.Text))
            {
                Error.SetError(txtNombrePais, "Ingrese el nombre del pais");
                return false;
            }
            else
            {
                Error.SetError(txtNombrePais, "");
                return true;
            }
        }

        private bool ValidarCodigo()
        {
            if (string.IsNullOrEmpty(txtCodigoPais.Text))
            {
                Error.SetError(txtCodigoPais, "Ingrese el codigo del pais");
                return false;
            }
            else
            {
                Error.SetError(txtCodigoPais, "");
                return true;
            }
        }

        private void FrmPais_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            string code = "Pa0" + random.Next(1, 20).ToString();
            if (paisDAO.Buscar(code) == null)
                txtCodigoPais.Text = code;
            else
                FrmPais_Load(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Pais pais = new Pais();
            if (ValidarNombre() != true)
                return;

            pais.CodigoPais = txtCodigoPais.Text.Trim();
            pais.NombrePais = txtNombrePais.Text.Trim();
            if (paisDAO.Agregar(pais) != false)
                MessageBox.Show("El registro se guardo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("El registro no se guardo correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtNombrePais.Text = "";
            FrmPais_Load(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtCodigoPais.Enabled = true;
            if (ValidarCodigo() != true)
                return;

            Pais pais = paisDAO.Buscar(txtCodigoPais.Text);
            if(pais != null)
            {
                if(paisDAO.Eliminar(pais) != false)
                    MessageBox.Show("El registro se elimino correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El registro no se elimino correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("El registro no existe", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            FrmPais_Load(sender,e);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
