
namespace Remesas.Catalogos
{
    partial class FrmEnvio
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
            this.lblCodigoEnvio = new System.Windows.Forms.Label();
            this.lblMontoPagado = new System.Windows.Forms.Label();
            this.lblFechaEnvio = new System.Windows.Forms.Label();
            this.lblCodigoRetiro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoEnvio = new System.Windows.Forms.TextBox();
            this.txtMontoPagado = new System.Windows.Forms.TextBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCodigoRetiro = new System.Windows.Forms.TextBox();
            this.dtpFechaEnvio = new System.Windows.Forms.DateTimePicker();
            this.cmbEstadoRemesa = new System.Windows.Forms.ComboBox();
            this.txtIdEmisor = new System.Windows.Forms.TextBox();
            this.txtIdReceptor = new System.Windows.Forms.TextBox();
            this.cmbTipoCambio = new System.Windows.Forms.ComboBox();
            this.lblIdReceptor = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNrec = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNemi = new System.Windows.Forms.TextBox();
            this.dgvEmisor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uspCargarEmisorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataEmi = new Remesas.DataEmi();
            this.usp_CargarEmisorTableAdapter = new Remesas.DataEmiTableAdapters.usp_CargarEmisorTableAdapter();
            this.dgvReceptor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uspCargarReceptorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataRec = new Remesas.DataRec();
            this.usp_CargarReceptorTableAdapter = new Remesas.DataRecTableAdapters.usp_CargarReceptorTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspCargarEmisorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspCargarReceptorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRec)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoEnvio
            // 
            this.lblCodigoEnvio.AutoSize = true;
            this.lblCodigoEnvio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEnvio.Location = new System.Drawing.Point(60, 82);
            this.lblCodigoEnvio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoEnvio.Name = "lblCodigoEnvio";
            this.lblCodigoEnvio.Size = new System.Drawing.Size(115, 16);
            this.lblCodigoEnvio.TabIndex = 0;
            this.lblCodigoEnvio.Text = "Codigo de Envio";
            // 
            // lblMontoPagado
            // 
            this.lblMontoPagado.AutoSize = true;
            this.lblMontoPagado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoPagado.Location = new System.Drawing.Point(433, 81);
            this.lblMontoPagado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoPagado.Name = "lblMontoPagado";
            this.lblMontoPagado.Size = new System.Drawing.Size(106, 16);
            this.lblMontoPagado.TabIndex = 1;
            this.lblMontoPagado.Text = "Monto a enviar";
            // 
            // lblFechaEnvio
            // 
            this.lblFechaEnvio.AutoSize = true;
            this.lblFechaEnvio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEnvio.Location = new System.Drawing.Point(793, 87);
            this.lblFechaEnvio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaEnvio.Name = "lblFechaEnvio";
            this.lblFechaEnvio.Size = new System.Drawing.Size(107, 16);
            this.lblFechaEnvio.TabIndex = 2;
            this.lblFechaEnvio.Text = "Fecha de envio";
            // 
            // lblCodigoRetiro
            // 
            this.lblCodigoRetiro.AutoSize = true;
            this.lblCodigoRetiro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoRetiro.Location = new System.Drawing.Point(60, 130);
            this.lblCodigoRetiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoRetiro.Name = "lblCodigoRetiro";
            this.lblCodigoRetiro.Size = new System.Drawing.Size(115, 16);
            this.lblCodigoRetiro.TabIndex = 3;
            this.lblCodigoRetiro.Text = "Codigo de retiro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado de remesa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(816, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Id del Cliente Emisor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 194);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(416, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tipo de Moneda";
            // 
            // txtCodigoEnvio
            // 
            this.txtCodigoEnvio.Enabled = false;
            this.txtCodigoEnvio.Location = new System.Drawing.Point(253, 78);
            this.txtCodigoEnvio.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoEnvio.Name = "txtCodigoEnvio";
            this.txtCodigoEnvio.Size = new System.Drawing.Size(132, 23);
            this.txtCodigoEnvio.TabIndex = 8;
            this.txtCodigoEnvio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoEnvio_KeyPress);
            // 
            // txtMontoPagado
            // 
            this.txtMontoPagado.Location = new System.Drawing.Point(588, 81);
            this.txtMontoPagado.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoPagado.Name = "txtMontoPagado";
            this.txtMontoPagado.Size = new System.Drawing.Size(132, 23);
            this.txtMontoPagado.TabIndex = 9;
            this.txtMontoPagado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoPagado_KeyPress);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // txtCodigoRetiro
            // 
            this.txtCodigoRetiro.Enabled = false;
            this.txtCodigoRetiro.Location = new System.Drawing.Point(253, 130);
            this.txtCodigoRetiro.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoRetiro.Name = "txtCodigoRetiro";
            this.txtCodigoRetiro.Size = new System.Drawing.Size(132, 23);
            this.txtCodigoRetiro.TabIndex = 11;
            // 
            // dtpFechaEnvio
            // 
            this.dtpFechaEnvio.Location = new System.Drawing.Point(980, 80);
            this.dtpFechaEnvio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaEnvio.Name = "dtpFechaEnvio";
            this.dtpFechaEnvio.Size = new System.Drawing.Size(265, 23);
            this.dtpFechaEnvio.TabIndex = 12;
            // 
            // cmbEstadoRemesa
            // 
            this.cmbEstadoRemesa.FormattingEnabled = true;
            this.cmbEstadoRemesa.Location = new System.Drawing.Point(588, 128);
            this.cmbEstadoRemesa.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstadoRemesa.Name = "cmbEstadoRemesa";
            this.cmbEstadoRemesa.Size = new System.Drawing.Size(160, 24);
            this.cmbEstadoRemesa.TabIndex = 13;
            // 
            // txtIdEmisor
            // 
            this.txtIdEmisor.Location = new System.Drawing.Point(1027, 128);
            this.txtIdEmisor.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEmisor.Name = "txtIdEmisor";
            this.txtIdEmisor.Size = new System.Drawing.Size(132, 23);
            this.txtIdEmisor.TabIndex = 14;
            this.txtIdEmisor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdEmisor_KeyPress);
            // 
            // txtIdReceptor
            // 
            this.txtIdReceptor.Location = new System.Drawing.Point(253, 186);
            this.txtIdReceptor.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdReceptor.Name = "txtIdReceptor";
            this.txtIdReceptor.Size = new System.Drawing.Size(132, 23);
            this.txtIdReceptor.TabIndex = 15;
            this.txtIdReceptor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdReceptor_KeyPress);
            // 
            // cmbTipoCambio
            // 
            this.cmbTipoCambio.FormattingEnabled = true;
            this.cmbTipoCambio.Location = new System.Drawing.Point(588, 188);
            this.cmbTipoCambio.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoCambio.Name = "cmbTipoCambio";
            this.cmbTipoCambio.Size = new System.Drawing.Size(160, 24);
            this.cmbTipoCambio.TabIndex = 16;
            // 
            // lblIdReceptor
            // 
            this.lblIdReceptor.AutoSize = true;
            this.lblIdReceptor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdReceptor.Location = new System.Drawing.Point(32, 191);
            this.lblIdReceptor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdReceptor.Name = "lblIdReceptor";
            this.lblIdReceptor.Size = new System.Drawing.Size(158, 16);
            this.lblIdReceptor.TabIndex = 17;
            this.lblIdReceptor.Text = "Id del Cliente Receptor";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Lime;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(1027, 214);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(100, 28);
            this.btnCargar.TabIndex = 19;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Lime;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(1027, 265);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1148, 214);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Lime;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(1148, 265);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNrec
            // 
            this.txtNrec.Location = new System.Drawing.Point(749, 268);
            this.txtNrec.Margin = new System.Windows.Forms.Padding(4);
            this.txtNrec.Name = "txtNrec";
            this.txtNrec.Size = new System.Drawing.Size(132, 23);
            this.txtNrec.TabIndex = 24;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(620, 276);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(114, 16);
            this.lbl.TabIndex = 25;
            this.lbl.Text = "Buscar Receptor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Buscar Emisor";
            // 
            // txtNemi
            // 
            this.txtNemi.Location = new System.Drawing.Point(236, 268);
            this.txtNemi.Margin = new System.Windows.Forms.Padding(4);
            this.txtNemi.Name = "txtNemi";
            this.txtNemi.Size = new System.Drawing.Size(132, 23);
            this.txtNemi.TabIndex = 26;
            // 
            // dgvEmisor
            // 
            this.dgvEmisor.AutoGenerateColumns = false;
            this.dgvEmisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmisor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvEmisor.DataSource = this.uspCargarEmisorBindingSource;
            this.dgvEmisor.Location = new System.Drawing.Point(138, 316);
            this.dgvEmisor.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmisor.Name = "dgvEmisor";
            this.dgvEmisor.Size = new System.Drawing.Size(339, 185);
            this.dgvEmisor.TabIndex = 28;
            this.dgvEmisor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmisor_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cedula";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cedula";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // uspCargarEmisorBindingSource
            // 
            this.uspCargarEmisorBindingSource.DataMember = "usp_CargarEmisor";
            this.uspCargarEmisorBindingSource.DataSource = this.dataEmi;
            // 
            // dataEmi
            // 
            this.dataEmi.DataSetName = "DataEmi";
            this.dataEmi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usp_CargarEmisorTableAdapter
            // 
            this.usp_CargarEmisorTableAdapter.ClearBeforeFill = true;
            // 
            // dgvReceptor
            // 
            this.dgvReceptor.AutoGenerateColumns = false;
            this.dgvReceptor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceptor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvReceptor.DataSource = this.uspCargarReceptorBindingSource;
            this.dgvReceptor.Location = new System.Drawing.Point(607, 316);
            this.dgvReceptor.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReceptor.Name = "dgvReceptor";
            this.dgvReceptor.Size = new System.Drawing.Size(339, 185);
            this.dgvReceptor.TabIndex = 29;
            this.dgvReceptor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceptor_CellClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn7.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cedula";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cedula";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // uspCargarReceptorBindingSource
            // 
            this.uspCargarReceptorBindingSource.DataMember = "usp_CargarReceptor";
            this.uspCargarReceptorBindingSource.DataSource = this.dataRec;
            // 
            // dataRec
            // 
            this.dataRec.DataSetName = "DataRec";
            this.dataRec.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usp_CargarReceptorTableAdapter
            // 
            this.usp_CargarReceptorTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 32);
            this.label4.TabIndex = 30;
            this.label4.Text = "Realizar envio";
            // 
            // FrmEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1257, 515);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvReceptor);
            this.Controls.Add(this.dgvEmisor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNemi);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtNrec);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblIdReceptor);
            this.Controls.Add(this.cmbTipoCambio);
            this.Controls.Add(this.txtIdReceptor);
            this.Controls.Add(this.txtIdEmisor);
            this.Controls.Add(this.cmbEstadoRemesa);
            this.Controls.Add(this.dtpFechaEnvio);
            this.Controls.Add(this.txtCodigoRetiro);
            this.Controls.Add(this.txtMontoPagado);
            this.Controls.Add(this.txtCodigoEnvio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCodigoRetiro);
            this.Controls.Add(this.lblFechaEnvio);
            this.Controls.Add(this.lblMontoPagado);
            this.Controls.Add(this.lblCodigoEnvio);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEnvio";
            this.Text = "FrmEnvio";
            this.Load += new System.EventHandler(this.FrmEnvio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspCargarEmisorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspCargarReceptorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoEnvio;
        private System.Windows.Forms.Label lblMontoPagado;
        private System.Windows.Forms.Label lblFechaEnvio;
        private System.Windows.Forms.Label lblCodigoRetiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoEnvio;
        private System.Windows.Forms.TextBox txtMontoPagado;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.ComboBox cmbTipoCambio;
        private System.Windows.Forms.TextBox txtIdReceptor;
        private System.Windows.Forms.TextBox txtIdEmisor;
        private System.Windows.Forms.ComboBox cmbEstadoRemesa;
        private System.Windows.Forms.DateTimePicker dtpFechaEnvio;
        private System.Windows.Forms.TextBox txtCodigoRetiro;
        private System.Windows.Forms.Label lblIdReceptor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNemi;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtNrec;
        private System.Windows.Forms.DataGridView dgvReceptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource uspCargarReceptorBindingSource;
        private DataRec dataRec;
        private System.Windows.Forms.DataGridView dgvEmisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource uspCargarEmisorBindingSource;
        private DataEmi dataEmi;
        private DataEmiTableAdapters.usp_CargarEmisorTableAdapter usp_CargarEmisorTableAdapter;
        private DataRecTableAdapters.usp_CargarReceptorTableAdapter usp_CargarReceptorTableAdapter;
        private System.Windows.Forms.Label label4;
    }
}