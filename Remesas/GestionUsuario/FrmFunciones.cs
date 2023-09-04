using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemesasDAO.GestionUsuarios;
using RemesasEDM.ModeloSeguridad;

namespace Remesas.GestionUsuario
{
    public partial class FrmFunciones : Form
    {
        public FrmFunciones()
        {
            InitializeComponent();
        }
        PermisosDAO permisosDAO = new PermisosDAO();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FuncionDeAcceso acceso = new FuncionDeAcceso();
            acceso.Codigo = txtCodigo.Text.Trim();
            acceso.Descripcion = txtDescripcion.Text.Trim();
            if (permisosDAO.Agregar(acceso) != false)
                MessageBox.Show("El registro se guardo", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("El registro no se guardo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtDescripcion.Text = "";
            FrmFunciones_Load(sender, e);
        }

        private void FrmFunciones_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            string cod = "Func" + random.Next(1, 10).ToString();
            if (permisosDAO.Buscar(cod) == null)
                txtCodigo.Text = cod;
            else
                FrmFunciones_Load(sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 33 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
    }
}
