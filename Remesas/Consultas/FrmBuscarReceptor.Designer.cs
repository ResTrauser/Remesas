
namespace Remesas.Catalogos
{
    partial class FrmBuscarReceptor
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
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNombreReceptor = new System.Windows.Forms.Label();
            this.lblApellidoReceptor = new System.Windows.Forms.Label();
            this.txtNombreReceptor = new System.Windows.Forms.TextBox();
            this.txtApellidoReceptor = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvBuscarRec = new System.Windows.Forms.DataGridView();
            this.codigoReceptorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresReceptorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1ReceptorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2ReceptorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionReceptorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoReceptorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uspBuscarClienteReceptorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remesasDataSet6 = new Remesas.RemesasDataSet6();
            this.usp_BuscarClienteReceptorTableAdapter = new Remesas.RemesasDataSet6TableAdapters.usp_BuscarClienteReceptorTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspBuscarClienteReceptorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remesasDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // lblNombreReceptor
            // 
            this.lblNombreReceptor.AutoSize = true;
            this.lblNombreReceptor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreReceptor.Location = new System.Drawing.Point(54, 77);
            this.lblNombreReceptor.Name = "lblNombreReceptor";
            this.lblNombreReceptor.Size = new System.Drawing.Size(73, 19);
            this.lblNombreReceptor.TabIndex = 0;
            this.lblNombreReceptor.Text = "Nombre";
            // 
            // lblApellidoReceptor
            // 
            this.lblApellidoReceptor.AutoSize = true;
            this.lblApellidoReceptor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoReceptor.Location = new System.Drawing.Point(54, 109);
            this.lblApellidoReceptor.Name = "lblApellidoReceptor";
            this.lblApellidoReceptor.Size = new System.Drawing.Size(75, 19);
            this.lblApellidoReceptor.TabIndex = 1;
            this.lblApellidoReceptor.Text = "Apellido";
            // 
            // txtNombreReceptor
            // 
            this.txtNombreReceptor.Location = new System.Drawing.Point(151, 76);
            this.txtNombreReceptor.Name = "txtNombreReceptor";
            this.txtNombreReceptor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreReceptor.TabIndex = 2;
            this.txtNombreReceptor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreReceptor_KeyPress);
            // 
            // txtApellidoReceptor
            // 
            this.txtApellidoReceptor.Location = new System.Drawing.Point(151, 108);
            this.txtApellidoReceptor.Name = "txtApellidoReceptor";
            this.txtApellidoReceptor.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoReceptor.TabIndex = 3;
            this.txtApellidoReceptor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoReceptor_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(149)))), ((int)(((byte)(27)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(309, 74);
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
            this.btnCerrar.Location = new System.Drawing.Point(309, 108);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvBuscarRec
            // 
            this.dgvBuscarRec.AutoGenerateColumns = false;
            this.dgvBuscarRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoReceptorDataGridViewTextBoxColumn,
            this.nombresReceptorDataGridViewTextBoxColumn,
            this.apellido1ReceptorDataGridViewTextBoxColumn,
            this.apellido2ReceptorDataGridViewTextBoxColumn,
            this.direccionReceptorDataGridViewTextBoxColumn,
            this.telefonoReceptorDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.nombrePaisDataGridViewTextBoxColumn});
            this.dgvBuscarRec.DataSource = this.uspBuscarClienteReceptorBindingSource;
            this.dgvBuscarRec.Location = new System.Drawing.Point(27, 177);
            this.dgvBuscarRec.Name = "dgvBuscarRec";
            this.dgvBuscarRec.Size = new System.Drawing.Size(845, 150);
            this.dgvBuscarRec.TabIndex = 6;
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
            // apellido2ReceptorDataGridViewTextBoxColumn
            // 
            this.apellido2ReceptorDataGridViewTextBoxColumn.DataPropertyName = "Apellido2Receptor";
            this.apellido2ReceptorDataGridViewTextBoxColumn.HeaderText = "Apellido2Receptor";
            this.apellido2ReceptorDataGridViewTextBoxColumn.Name = "apellido2ReceptorDataGridViewTextBoxColumn";
            // 
            // direccionReceptorDataGridViewTextBoxColumn
            // 
            this.direccionReceptorDataGridViewTextBoxColumn.DataPropertyName = "DireccionReceptor";
            this.direccionReceptorDataGridViewTextBoxColumn.HeaderText = "DireccionReceptor";
            this.direccionReceptorDataGridViewTextBoxColumn.Name = "direccionReceptorDataGridViewTextBoxColumn";
            // 
            // telefonoReceptorDataGridViewTextBoxColumn
            // 
            this.telefonoReceptorDataGridViewTextBoxColumn.DataPropertyName = "TelefonoReceptor";
            this.telefonoReceptorDataGridViewTextBoxColumn.HeaderText = "TelefonoReceptor";
            this.telefonoReceptorDataGridViewTextBoxColumn.Name = "telefonoReceptorDataGridViewTextBoxColumn";
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
            // uspBuscarClienteReceptorBindingSource
            // 
            this.uspBuscarClienteReceptorBindingSource.DataMember = "usp_BuscarClienteReceptor";
            this.uspBuscarClienteReceptorBindingSource.DataSource = this.remesasDataSet6;
            // 
            // remesasDataSet6
            // 
            this.remesasDataSet6.DataSetName = "RemesasDataSet6";
            this.remesasDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usp_BuscarClienteReceptorTableAdapter
            // 
            this.usp_BuscarClienteReceptorTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Buscar cliente receptor";
            // 
            // FrmBuscarReceptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvBuscarRec);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtApellidoReceptor);
            this.Controls.Add(this.txtNombreReceptor);
            this.Controls.Add(this.lblApellidoReceptor);
            this.Controls.Add(this.lblNombreReceptor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarReceptor";
            this.Text = "FrmBuscarReceptor";
            this.Load += new System.EventHandler(this.FrmBuscarReceptor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspBuscarClienteReceptorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remesasDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtApellidoReceptor;
        private System.Windows.Forms.TextBox txtNombreReceptor;
        private System.Windows.Forms.Label lblApellidoReceptor;
        private System.Windows.Forms.Label lblNombreReceptor;
        private System.Windows.Forms.DataGridView dgvBuscarRec;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoReceptorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresReceptorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1ReceptorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2ReceptorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionReceptorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoReceptorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uspBuscarClienteReceptorBindingSource;
        private RemesasDataSet6 remesasDataSet6;
        private RemesasDataSet6TableAdapters.usp_BuscarClienteReceptorTableAdapter usp_BuscarClienteReceptorTableAdapter;
        private System.Windows.Forms.Label label4;
    }
}