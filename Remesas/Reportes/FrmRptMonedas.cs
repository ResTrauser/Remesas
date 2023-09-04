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
    public partial class FrmRptMonedas : Form
    {
        public FrmRptMonedas()
        {
            InitializeComponent();
        }
        MonedaDAO moneda = new MonedaDAO();
        private void FrmRptMonedas_Load(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Remesas.Informes.RptMonedas.rdlc";
            bindingSource1.DataSource = moneda.Reporte();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bindingSource1));
            this.reportViewer1.RefreshReport();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Remesas.Informes.RptMonedas.rdlc";
            bindingSource1.DataSource = moneda.Reporte();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bindingSource1));
            this.reportViewer1.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
