
namespace Remesas.Catalogos
{
    partial class FrmBuscarTransaccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoEnvio = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoEnvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoPagadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cambioDiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMonedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresEmisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1EmisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoReceptorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresReceptorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1ReceptorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDestinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uspBuscarTransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remesasDataSet2 = new Remesas.RemesasDataSet2();
            this.usp_BuscarTransaccionTableAdapter = new Remesas.RemesasDataSet2TableAdapters.usp_BuscarTransaccionTableAdapter();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspBuscarTransaccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remesasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Transaccion";
            // 
            // txtCodigoEnvio
            // 
            this.txtCodigoEnvio.Location = new System.Drawing.Point(291, 108);
            this.txtCodigoEnvio.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoEnvio.Name = "txtCodigoEnvio";
            this.txtCodigoEnvio.Size = new System.Drawing.Size(132, 23);
            this.txtCodigoEnvio.TabIndex = 1;
            this.txtCodigoEnvio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoEnvio_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(495, 82);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(495, 129);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoEnvioDataGridViewTextBoxColumn,
            this.fechaPagoDataGridViewTextBoxColumn,
            this.montoPagadoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.cambioDiaDataGridViewTextBoxColumn,
            this.tipoMonedaDataGridViewTextBoxColumn,
            this.codigoEmisorDataGridViewTextBoxColumn,
            this.nombresEmisorDataGridViewTextBoxColumn,
            this.apellido1EmisorDataGridViewTextBoxColumn,
            this.codigoReceptorDataGridViewTextBoxColumn,
            this.nombresReceptorDataGridViewTextBoxColumn,
            this.apellido1ReceptorDataGridViewTextBoxColumn,
            this.paisDestinoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uspBuscarTransaccionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 190);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1119, 185);
            this.dataGridView1.TabIndex = 4;
            // 
            // codigoEnvioDataGridViewTextBoxColumn
            // 
            this.codigoEnvioDataGridViewTextBoxColumn.DataPropertyName = "CodigoEnvio";
            this.codigoEnvioDataGridViewTextBoxColumn.HeaderText = "CodigoEnvio";
            this.codigoEnvioDataGridViewTextBoxColumn.Name = "codigoEnvioDataGridViewTextBoxColumn";
            // 
            // fechaPagoDataGridViewTextBoxColumn
            // 
            this.fechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago";
            this.fechaPagoDataGridViewTextBoxColumn.HeaderText = "FechaPago";
            this.fechaPagoDataGridViewTextBoxColumn.Name = "fechaPagoDataGridViewTextBoxColumn";
            // 
            // montoPagadoDataGridViewTextBoxColumn
            // 
            this.montoPagadoDataGridViewTextBoxColumn.DataPropertyName = "MontoPagado";
            this.montoPagadoDataGridViewTextBoxColumn.HeaderText = "MontoPagado";
            this.montoPagadoDataGridViewTextBoxColumn.Name = "montoPagadoDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // cambioDiaDataGridViewTextBoxColumn
            // 
            this.cambioDiaDataGridViewTextBoxColumn.DataPropertyName = "CambioDia";
            this.cambioDiaDataGridViewTextBoxColumn.HeaderText = "CambioDia";
            this.cambioDiaDataGridViewTextBoxColumn.Name = "cambioDiaDataGridViewTextBoxColumn";
            // 
            // tipoMonedaDataGridViewTextBoxColumn
            // 
            this.tipoMonedaDataGridViewTextBoxColumn.DataPropertyName = "TipoMoneda";
            this.tipoMonedaDataGridViewTextBoxColumn.HeaderText = "TipoMoneda";
            this.tipoMonedaDataGridViewTextBoxColumn.Name = "tipoMonedaDataGridViewTextBoxColumn";
            // 
            // codigoEmisorDataGridViewTextBoxColumn
            // 
            this.codigoEmisorDataGridViewTextBoxColumn.DataPropertyName = "CodigoEmisor";
            this.codigoEmisorDataGridViewTextBoxColumn.HeaderText = "CodigoEmisor";
            this.codigoEmisorDataGridViewTextBoxColumn.Name = "codigoEmisorDataGridViewTextBoxColumn";
            // 
            // nombresEmisorDataGridViewTextBoxColumn
            // 
            this.nombresEmisorDataGridViewTextBoxColumn.DataPropertyName = "NombresEmisor";
            this.nombresEmisorDataGridViewTextBoxColumn.HeaderText = "NombresEmisor";
            this.nombresEmisorDataGridViewTextBoxColumn.Name = "nombresEmisorDataGridViewTextBoxColumn";
            // 
            // apellido1EmisorDataGridViewTextBoxColumn
            // 
            this.apellido1EmisorDataGridViewTextBoxColumn.DataPropertyName = "Apellido1Emisor";
            this.apellido1EmisorDataGridViewTextBoxColumn.HeaderText = "Apellido1Emisor";
            this.apellido1EmisorDataGridViewTextBoxColumn.Name = "apellido1EmisorDataGridViewTextBoxColumn";
            // 
            // codigoReceptorDataGridViewTextBoxColumn
            // 
            this.codigoReceptorDataGridViewTextBoxColumn.DataPropertyName = "CodigoReceptor";
            this.codigoReceptorDataGridViewTextBoxColumn.HeaderText = "CodigoReceptor";
            this.codigoReceptorDataGridViewTextBoxColumn.Name = "codigoReceptorDataGridViewTextBoxColumn";
            // 
            // nombresReceptorDataGridViewTextBoxColumn
            // 
            this.nombresReceptorDataGridViewTextBoxColumn.DataPropertyName = "NombresReceptor";
            this.nombresReceptorDataGridViewTextBoxColumn.HeaderText = "NombresReceptor";
            this.nombresReceptorDataGridViewTextBoxColumn.Name = "nombresReceptorDataGridViewTextBoxColumn";
            // 
            // apellido1ReceptorDataGridViewTextBoxColumn
            // 
            this.apellido1ReceptorDataGridViewTextBoxColumn.DataPropertyName = "Apellido1Receptor";
            this.apellido1ReceptorDataGridViewTextBoxColumn.HeaderText = "Apellido1Receptor";
            this.apellido1ReceptorDataGridViewTextBoxColumn.Name = "apellido1ReceptorDataGridViewTextBoxColumn";
            // 
            // paisDestinoDataGridViewTextBoxColumn
            // 
            this.paisDestinoDataGridViewTextBoxColumn.DataPropertyName = "PaisDestino";
            this.paisDestinoDataGridViewTextBoxColumn.HeaderText = "PaisDestino";
            this.paisDestinoDataGridViewTextBoxColumn.Name = "paisDestinoDataGridViewTextBoxColumn";
            // 
            // uspBuscarTransaccionBindingSource
            // 
            this.uspBuscarTransaccionBindingSource.DataMember = "usp_BuscarTransaccion";
            this.uspBuscarTransaccionBindingSource.DataSource = this.remesasDataSet2;
            // 
            // remesasDataSet2
            // 
            this.remesasDataSet2.DataSetName = "RemesasDataSet2";
            this.remesasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usp_BuscarTransaccionTableAdapter
            // 
            this.usp_BuscarTransaccionTableAdapter.ClearBeforeFill = true;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Buscar envio";
            // 
            // FrmBuscarTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1151, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigoEnvio);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBuscarTransaccion";
            this.Text = "FrmBuscarTransaccion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspBuscarTransaccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remesasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoEnvio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEnvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoPagadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cambioDiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMonedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresEmisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1EmisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoReceptorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresReceptorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1ReceptorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uspBuscarTransaccionBindingSource;
        private RemesasDataSet2 remesasDataSet2;
        private RemesasDataSet2TableAdapters.usp_BuscarTransaccionTableAdapter usp_BuscarTransaccionTableAdapter;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.Label label4;
    }
}