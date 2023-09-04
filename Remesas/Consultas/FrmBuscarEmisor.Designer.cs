
namespace Remesas.Catalogos
{
    partial class FrmBuscarEmisor
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
            this.lblNombreEmisor = new System.Windows.Forms.Label();
            this.lblApellidoEmisor = new System.Windows.Forms.Label();
            this.txtNombreEmisor = new System.Windows.Forms.TextBox();
            this.txtApellidoEmisor = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgwBusqueda = new System.Windows.Forms.DataGridView();
            this.codigoEmisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresEmisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1EmisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2EmisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionEmisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoEmisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uspBuscarClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remesasDataSet5 = new Remesas.RemesasDataSet5();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.usp_BuscarClienteTableAdapter = new Remesas.RemesasDataSet5TableAdapters.usp_BuscarClienteTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspBuscarClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remesasDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreEmisor
            // 
            this.lblNombreEmisor.AutoSize = true;
            this.lblNombreEmisor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmisor.Location = new System.Drawing.Point(44, 114);
            this.lblNombreEmisor.Name = "lblNombreEmisor";
            this.lblNombreEmisor.Size = new System.Drawing.Size(60, 16);
            this.lblNombreEmisor.TabIndex = 0;
            this.lblNombreEmisor.Text = "Nombre";
            // 
            // lblApellidoEmisor
            // 
            this.lblApellidoEmisor.AutoSize = true;
            this.lblApellidoEmisor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEmisor.Location = new System.Drawing.Point(44, 166);
            this.lblApellidoEmisor.Name = "lblApellidoEmisor";
            this.lblApellidoEmisor.Size = new System.Drawing.Size(64, 16);
            this.lblApellidoEmisor.TabIndex = 1;
            this.lblApellidoEmisor.Text = "Apellido";
            // 
            // txtNombreEmisor
            // 
            this.txtNombreEmisor.Location = new System.Drawing.Point(125, 113);
            this.txtNombreEmisor.Name = "txtNombreEmisor";
            this.txtNombreEmisor.Size = new System.Drawing.Size(106, 20);
            this.txtNombreEmisor.TabIndex = 2;
            this.txtNombreEmisor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEmisor_KeyPress);
            // 
            // txtApellidoEmisor
            // 
            this.txtApellidoEmisor.Location = new System.Drawing.Point(125, 163);
            this.txtApellidoEmisor.Name = "txtApellidoEmisor";
            this.txtApellidoEmisor.Size = new System.Drawing.Size(106, 20);
            this.txtApellidoEmisor.TabIndex = 3;
            this.txtApellidoEmisor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoEmisor_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(291, 113);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(291, 153);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgwBusqueda
            // 
            this.dgwBusqueda.AutoGenerateColumns = false;
            this.dgwBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoEmisorDataGridViewTextBoxColumn,
            this.nombresEmisorDataGridViewTextBoxColumn,
            this.apellido1EmisorDataGridViewTextBoxColumn,
            this.apellido2EmisorDataGridViewTextBoxColumn,
            this.direccionEmisorDataGridViewTextBoxColumn,
            this.telefonoEmisorDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.nombrePaisDataGridViewTextBoxColumn});
            this.dgwBusqueda.DataSource = this.uspBuscarClienteBindingSource;
            this.dgwBusqueda.Location = new System.Drawing.Point(10, 217);
            this.dgwBusqueda.Name = "dgwBusqueda";
            this.dgwBusqueda.Size = new System.Drawing.Size(843, 166);
            this.dgwBusqueda.TabIndex = 6;
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
            // apellido2EmisorDataGridViewTextBoxColumn
            // 
            this.apellido2EmisorDataGridViewTextBoxColumn.DataPropertyName = "Apellido2Emisor";
            this.apellido2EmisorDataGridViewTextBoxColumn.HeaderText = "Apellido2Emisor";
            this.apellido2EmisorDataGridViewTextBoxColumn.Name = "apellido2EmisorDataGridViewTextBoxColumn";
            // 
            // direccionEmisorDataGridViewTextBoxColumn
            // 
            this.direccionEmisorDataGridViewTextBoxColumn.DataPropertyName = "DireccionEmisor";
            this.direccionEmisorDataGridViewTextBoxColumn.HeaderText = "DireccionEmisor";
            this.direccionEmisorDataGridViewTextBoxColumn.Name = "direccionEmisorDataGridViewTextBoxColumn";
            // 
            // telefonoEmisorDataGridViewTextBoxColumn
            // 
            this.telefonoEmisorDataGridViewTextBoxColumn.DataPropertyName = "TelefonoEmisor";
            this.telefonoEmisorDataGridViewTextBoxColumn.HeaderText = "TelefonoEmisor";
            this.telefonoEmisorDataGridViewTextBoxColumn.Name = "telefonoEmisorDataGridViewTextBoxColumn";
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            // 
            // nombrePaisDataGridViewTextBoxColumn
            // 
            this.nombrePaisDataGridViewTextBoxColumn.DataPropertyName = "NombrePais";
            this.nombrePaisDataGridViewTextBoxColumn.HeaderText = "NombrePais";
            this.nombrePaisDataGridViewTextBoxColumn.Name = "nombrePaisDataGridViewTextBoxColumn";
            // 
            // uspBuscarClienteBindingSource
            // 
            this.uspBuscarClienteBindingSource.DataMember = "usp_BuscarCliente";
            this.uspBuscarClienteBindingSource.DataSource = this.remesasDataSet5;
            // 
            // remesasDataSet5
            // 
            this.remesasDataSet5.DataSetName = "RemesasDataSet5";
            this.remesasDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // usp_BuscarClienteTableAdapter
            // 
            this.usp_BuscarClienteTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Buscar cliente emisor";
            // 
            // FrmBuscarEmisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgwBusqueda);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtApellidoEmisor);
            this.Controls.Add(this.txtNombreEmisor);
            this.Controls.Add(this.lblApellidoEmisor);
            this.Controls.Add(this.lblNombreEmisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarEmisor";
            this.Text = "FrmBuscarEmisor";
            ((System.ComponentModel.ISupportInitialize)(this.dgwBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspBuscarClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remesasDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreEmisor;
        private System.Windows.Forms.Label lblApellidoEmisor;
        private System.Windows.Forms.TextBox txtNombreEmisor;
        private System.Windows.Forms.TextBox txtApellidoEmisor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgwBusqueda;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresEmisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1EmisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2EmisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionEmisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoEmisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uspBuscarClienteBindingSource;
        private RemesasDataSet5 remesasDataSet5;
        private RemesasDataSet5TableAdapters.usp_BuscarClienteTableAdapter usp_BuscarClienteTableAdapter;
        private System.Windows.Forms.Label label4;
    }
}