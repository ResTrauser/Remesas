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
using Microsoft.Reporting.WinForms;

namespace Remesas.Reportes
{
    public partial class FrmRptEnvioCliente : Form
    {
        public FrmRptEnvioCliente()
        {
            InitializeComponent();
        }
        EnvioDAO envioDAO = new EnvioDAO();
        ClienteEmisorDAO emisorDAO = new ClienteEmisorDAO();
        private void FrmRptEnvioCliente_Load(object sender, EventArgs e)
        {
            cboEmisor.DataSource = emisorDAO.Listar();
            cboEmisor.DisplayMember = "NombresEmisor";
            cboEmisor.ValueMember = "Id";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Remesas.Informes.RptEnvioClienteEmisor.rdlc";
            bindingSource1.DataSource = envioDAO.ReportCliente((int)cboEmisor.SelectedValue);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bindingSource1));
            this.reportViewer1.RefreshReport();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
