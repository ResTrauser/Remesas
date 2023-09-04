
namespace Remesas.Catalogos
{
    partial class FrmCobarar
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
            this.txtCodRetiro = new System.Windows.Forms.TextBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvCobrar = new System.Windows.Forms.DataGridView();
            this.dataEnvio1 = new Remesas.DataEnvio();
            this.dataEnvio1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspBuscarTransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_BuscarTransaccionTableAdapter = new Remesas.DataEnvioTableAdapters.usp_BuscarTransaccionTableAdapter();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnvio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnvio1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspBuscarTransaccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de retiro";
            // 
            // txtCodRetiro
            // 
            this.txtCodRetiro.Location = new System.Drawing.Point(247, 96);
            this.txtCodRetiro.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodRetiro.Name = "txtCodRetiro";
            this.txtCodRetiro.Size = new System.Drawing.Size(132, 23);
            this.txtCodRetiro.TabIndex = 1;
            this.txtCodRetiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodRetiro_KeyPress);
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(508, 98);
            this.btnCobrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(100, 28);
            this.btnCobrar.TabIndex = 2;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(640, 96);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(763, 98);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvCobrar
            // 
            this.dgvCobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobrar.Location = new System.Drawing.Point(160, 189);
            this.dgvCobrar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCobrar.Name = "dgvCobrar";
            this.dgvCobrar.Size = new System.Drawing.Size(324, 185);
            this.dgvCobrar.TabIndex = 5;
            // 
            // dataEnvio1
            // 
            this.dataEnvio1.DataSetName = "DataEnvio";
            this.dataEnvio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataEnvio1BindingSource
            // 
            this.dataEnvio1BindingSource.DataSource = this.dataEnvio1;
            this.dataEnvio1BindingSource.Position = 0;
            // 
            // uspBuscarTransaccionBindingSource
            // 
            this.uspBuscarTransaccionBindingSource.DataMember = "usp_BuscarTransaccion";
            this.uspBuscarTransaccionBindingSource.DataSource = this.dataEnvio1BindingSource;
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
            this.label4.Location = new System.Drawing.Point(264, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cobrar remesa";
            // 
            // FrmCobarar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(879, 472);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCobrar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.txtCodRetiro);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCobarar";
            this.Text = "FrmCobarar";
            this.Load += new System.EventHandler(this.FrmCobarar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnvio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnvio1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspBuscarTransaccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodRetiro;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvCobrar;
        private System.Windows.Forms.BindingSource dataEnvio1BindingSource;
        private DataEnvio dataEnvio1;
        private System.Windows.Forms.BindingSource uspBuscarTransaccionBindingSource;
        private DataEnvioTableAdapters.usp_BuscarTransaccionTableAdapter usp_BuscarTransaccionTableAdapter;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.Label label4;
    }
}