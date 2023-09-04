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
    public partial class FrmPermisos : Form
    {
        public FrmPermisos()
        {
            InitializeComponent();
        }
        PermisosDAO permisos = new PermisosDAO();
        UsuarioDAO usuario = new UsuarioDAO();
        AsignarFuncionDAO funcion = new AsignarFuncionDAO();
        private void FrmPermisos_Load(object sender, EventArgs e)
        {
            cboPermiso.DataSource = permisos.Listar();
            cboPermiso.DisplayMember = "Descripcion";
            cboPermiso.ValueMember = "Id";
            cboPermiso.SelectedIndex = -1;

            cboUsuarios.DataSource = usuario.Listar();
            cboUsuarios.DisplayMember = "NombreUsuario";
            cboUsuarios.ValueMember = "Id";
            cboUsuarios.SelectedIndex = -1;
        }

        private bool ValidarUsuario()
        {
            if (cboUsuarios.SelectedIndex == -1)
            {
                Error.SetError(cboUsuarios, "Debe de escoger un usuario");
                return false;
            }
            else
            {
                Error.SetError(cboUsuarios, "");
                return true;
            }
        }

        private bool ValidarPermiso()
        {
            if (cboPermiso.SelectedIndex == -1)
            {
                Error.SetError(cboPermiso, "Debe de escoger un permiso");
                return false;
            }
            else
            {
                Error.SetError(cboPermiso, "");
                return true;
            }
        }

        private bool ValidarFecha()
        {
            if (dtpVencimiento.Value < DateTime.Now)
            {
                Error.SetError(dtpVencimiento, "Debe de escoger una fecha con almenos un dia de duración");
                return false;
            }
            else
            {
                Error.SetError(dtpVencimiento, "");
                return true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FuncionAsignada asignada = new FuncionAsignada();

            if (ValidarUsuario() != true)
                return;
            if (ValidarPermiso() != true)
                return;
            if (ValidarFecha() != true)
                return;

            asignada.FuncionDeAccesoId = (int)cboPermiso.SelectedValue;
            asignada.UsuarioId = (int)cboUsuarios.SelectedValue;
            asignada.FechaVencimiento = dtpVencimiento.Value;
            if(funcion.Agregar(asignada) != false)
                MessageBox.Show("El registro se guardo", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("El registro no se guardo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cboPermiso.SelectedIndex = 0;
            cboPermiso.SelectedIndex = 0;
            dtpVencimiento.Value = DateTime.Now;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
