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
using Remesas.Catalogos;
using Remesas.Reportes;
using Remesas.GestionUsuario;
using RemesasDAO.GestionUsuarios;

namespace Remesas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public int Idusuario = 0;

        public void AddForm(Form f)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            f.TopLevel = false;
            this.panel1.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        //Catalogos1
        private void clienteEmisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 1))
            {
                FrmClienteEmisor frmemisor = new FrmClienteEmisor();
                AddForm(frmemisor);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }

        private void terminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Catalogos1
        private void clienteReceptorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 1))
            {
                FrmClienteReceptor frmReceptor = new FrmClienteReceptor();
                AddForm(frmReceptor);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }
        //Catalogos1
        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 1))
            {
                FrmPais frmPais = new FrmPais();
                AddForm(frmPais);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }
        //Catalogos1
        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 1))
            {
                FrmMoneda frmMoneda = new FrmMoneda();
                AddForm(frmMoneda);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }
        //Catalogos1
        private void cambioDelDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 1))
            {
                FrmCambioDia frmCambioDia = new FrmCambioDia();
                AddForm(frmCambioDia);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }
        //Consultas2
        private void clientesEmisoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 2))
            {
                FrmBuscarEmisor frmBuscarEmisor = new FrmBuscarEmisor();
                AddForm(frmBuscarEmisor);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }
        //Consultas2
        private void clientesReceptoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 2))
            {
                FrmBuscarReceptor frmBuscarReceptor = new FrmBuscarReceptor();
                AddForm(frmBuscarReceptor);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }
        //Consultas2
        private void buscarTransaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 2))
            {
                FrmBuscarTransaccion frmBuscarTransaccion = new FrmBuscarTransaccion();
                AddForm(frmBuscarTransaccion);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }
        //Consultas2
        private void buscarCambiosDeMonedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 2))
            {
                FrmBuscarMoneda frmBuscarMoneda = new FrmBuscarMoneda();
                AddForm(frmBuscarMoneda);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }
        //Operaciones3
        private void realizarTransacciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 3))
            {
                FrmEnvio frmEnvio = new FrmEnvio();
                AddForm(frmEnvio);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }
        //Catalogos1
        private void estadosDeRemesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 1))
            {
                FrmEstados frmEstados = new FrmEstados();
                AddForm(frmEstados);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }
        //Operaciones3
        private void ModificarEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 3))
            {
                FrmModificarEstado frmModificarEstado = new FrmModificarEstado();
                AddForm(frmModificarEstado);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }
        //Operaciones3
        private void cobrarTransacciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 3))
            {
                FrmCobarar frmCobarar = new FrmCobarar();
                AddForm(frmCobarar);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }
        //Reportes4
        private void transaccionesReallizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 4))
            {
                FrmReportTransacciones frmReport = new FrmReportTransacciones();
                AddForm(frmReport);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }
        //Reportes4
        private void emisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 4))
            {
                FrmRptEnvioCliente frmRptEnvio = new FrmRptEnvioCliente();
                AddForm(frmRptEnvio);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }
        //Reportes4
        private void tiposDeCambiosDeMonedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 4))
            {
                FrmRptMonedas rptMonedas = new FrmRptMonedas();
                AddForm(rptMonedas);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var lfrm = new GestionUsuario.FrmLogin();
            lfrm.ShowDialog();
            Idusuario = lfrm.Idusuario;
            lfrm.Dispose();
            if (Idusuario < 1)
                this.Close();
        }
        //Seguridad5
        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 5))
            {
                FrmUsuario frmUsuario = new FrmUsuario();
                AddForm(frmUsuario);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }

        private void crearPermisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 5))
            {
                FrmFunciones frmFunciones = new FrmFunciones();
                AddForm(frmFunciones);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }

        private void asignarPermisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.VerificarPermiso(Idusuario, 5))
            {
                FrmPermisos frmPermisos = new FrmPermisos();
                AddForm(frmPermisos);
            }
            else
                MessageBox.Show("Usted no tine permiso a este modulo");
        }
    }
}