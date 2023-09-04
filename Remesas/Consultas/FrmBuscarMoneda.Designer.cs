
namespace Remesas.Catalogos
{
    partial class FrmBuscarMoneda
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreMoneda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMonedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cambioDiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaTipoCambioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uspBuscarMonedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remesasDataSet3 = new Remesas.RemesasDataSet3();
            this.usp_BuscarMonedaTableAdapter = new Remesas.RemesasDataSet3TableAdapters.usp_BuscarMonedaTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspBuscarMonedaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remesasDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la Moneda";
            // 
            // txtNombreMoneda
            // 
            this.txtNombreMoneda.Location = new System.Drawing.Point(285, 105);
            this.txtNombreMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMoneda.Name = "txtNombreMoneda";
            this.txtNombreMoneda.Size = new System.Drawing.Size(132, 23);
            this.txtNombreMoneda.TabIndex = 1;
            this.txtNombreMoneda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMoneda_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(483, 79);
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
            this.btnCerrar.Location = new System.Drawing.Point(483, 126);
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
            this.idDataGridViewTextBoxColumn,
            this.tipoMonedaDataGridViewTextBoxColumn,
            this.cambioDiaDataGridViewTextBoxColumn,
            this.fechaTipoCambioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uspBuscarMonedaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(99, 198);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 185);
            this.dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoMonedaDataGridViewTextBoxColumn
            // 
            this.tipoMonedaDataGridViewTextBoxColumn.DataPropertyName = "TipoMoneda";
            this.tipoMonedaDataGridViewTextBoxColumn.HeaderText = "TipoMoneda";
            this.tipoMonedaDataGridViewTextBoxColumn.Name = "tipoMonedaDataGridViewTextBoxColumn";
            // 
            // cambioDiaDataGridViewTextBoxColumn
            // 
            this.cambioDiaDataGridViewTextBoxColumn.DataPropertyName = "CambioDia";
            this.cambioDiaDataGridViewTextBoxColumn.HeaderText = "CambioDia";
            this.cambioDiaDataGridViewTextBoxColumn.Name = "cambioDiaDataGridViewTextBoxColumn";
            // 
            // fechaTipoCambioDataGridViewTextBoxColumn
            // 
            this.fechaTipoCambioDataGridViewTextBoxColumn.DataPropertyName = "FechaTipoCambio";
            this.fechaTipoCambioDataGridViewTextBoxColumn.HeaderText = "FechaTipoCambio";
            this.fechaTipoCambioDataGridViewTextBoxColumn.Name = "fechaTipoCambioDataGridViewTextBoxColumn";
            // 
            // uspBuscarMonedaBindingSource
            // 
            this.uspBuscarMonedaBindingSource.DataMember = "usp_BuscarMoneda";
            this.uspBuscarMonedaBindingSource.DataSource = this.remesasDataSet3;
            // 
            // remesasDataSet3
            // 
            this.remesasDataSet3.DataSetName = "RemesasDataSet3";
            this.remesasDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usp_BuscarMonedaTableAdapter
            // 
            this.usp_BuscarMonedaTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Buscar moneda";
            // 
            // FrmBuscarMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(740, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombreMoneda);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBuscarMoneda";
            this.Text = "FrmBuscarMoneda";
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspBuscarMonedaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remesasDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombreMoneda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMonedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cambioDiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaTipoCambioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uspBuscarMonedaBindingSource;
        private RemesasDataSet3 remesasDataSet3;
        private RemesasDataSet3TableAdapters.usp_BuscarMonedaTableAdapter usp_BuscarMonedaTableAdapter;
        private System.Windows.Forms.Label label4;
    }
}