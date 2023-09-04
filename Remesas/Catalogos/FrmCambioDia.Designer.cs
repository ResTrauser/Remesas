
namespace Remesas.Catalogos
{
    partial class FrmCambioDia
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCodigoCambio = new System.Windows.Forms.Label();
            this.txtCodigoCambio = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCambioDia = new System.Windows.Forms.TextBox();
            this.lblCambioDia = new System.Windows.Forms.Label();
            this.FrmEmisoresTitulo = new System.Windows.Forms.Label();
            this.lblFechaCambio = new System.Windows.Forms.Label();
            this.dtFechaCambio = new System.Windows.Forms.DateTimePicker();
            this.lblTipoMoneda = new System.Windows.Forms.Label();
            this.cboTipoMoneda = new System.Windows.Forms.ComboBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(684, 147);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 47);
            this.btnCancelar.TabIndex = 83;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCodigoCambio
            // 
            this.lblCodigoCambio.AutoSize = true;
            this.lblCodigoCambio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCambio.Location = new System.Drawing.Point(69, 178);
            this.lblCodigoCambio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoCambio.Name = "lblCodigoCambio";
            this.lblCodigoCambio.Size = new System.Drawing.Size(112, 16);
            this.lblCodigoCambio.TabIndex = 82;
            this.lblCodigoCambio.Text = "Codigo Cambio";
            // 
            // txtCodigoCambio
            // 
            this.txtCodigoCambio.Enabled = false;
            this.txtCodigoCambio.Location = new System.Drawing.Point(296, 168);
            this.txtCodigoCambio.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoCambio.Name = "txtCodigoCambio";
            this.txtCodigoCambio.ShortcutsEnabled = false;
            this.txtCodigoCambio.Size = new System.Drawing.Size(281, 23);
            this.txtCodigoCambio.TabIndex = 81;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(684, 277);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 47);
            this.btnEliminar.TabIndex = 80;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(684, 211);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 47);
            this.btnGuardar.TabIndex = 79;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCambioDia
            // 
            this.txtCambioDia.Location = new System.Drawing.Point(296, 211);
            this.txtCambioDia.Margin = new System.Windows.Forms.Padding(4);
            this.txtCambioDia.Name = "txtCambioDia";
            this.txtCambioDia.ShortcutsEnabled = false;
            this.txtCambioDia.Size = new System.Drawing.Size(281, 23);
            this.txtCambioDia.TabIndex = 78;
            this.txtCambioDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCambioDia_KeyPress);
            // 
            // lblCambioDia
            // 
            this.lblCambioDia.AutoSize = true;
            this.lblCambioDia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambioDia.Location = new System.Drawing.Point(69, 220);
            this.lblCambioDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCambioDia.Name = "lblCambioDia";
            this.lblCambioDia.Size = new System.Drawing.Size(111, 16);
            this.lblCambioDia.TabIndex = 77;
            this.lblCambioDia.Text = "Cambio del Dia";
            // 
            // FrmEmisoresTitulo
            // 
            this.FrmEmisoresTitulo.AutoSize = true;
            this.FrmEmisoresTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmEmisoresTitulo.Location = new System.Drawing.Point(372, 75);
            this.FrmEmisoresTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FrmEmisoresTitulo.Name = "FrmEmisoresTitulo";
            this.FrmEmisoresTitulo.Size = new System.Drawing.Size(220, 32);
            this.FrmEmisoresTitulo.TabIndex = 76;
            this.FrmEmisoresTitulo.Text = "Cambio del Dia";
            // 
            // lblFechaCambio
            // 
            this.lblFechaCambio.AutoSize = true;
            this.lblFechaCambio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCambio.Location = new System.Drawing.Point(73, 258);
            this.lblFechaCambio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaCambio.Name = "lblFechaCambio";
            this.lblFechaCambio.Size = new System.Drawing.Size(124, 16);
            this.lblFechaCambio.TabIndex = 84;
            this.lblFechaCambio.Text = "Fecha de Cambio";
            // 
            // dtFechaCambio
            // 
            this.dtFechaCambio.Location = new System.Drawing.Point(296, 258);
            this.dtFechaCambio.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaCambio.Name = "dtFechaCambio";
            this.dtFechaCambio.Size = new System.Drawing.Size(281, 23);
            this.dtFechaCambio.TabIndex = 85;
            // 
            // lblTipoMoneda
            // 
            this.lblTipoMoneda.AutoSize = true;
            this.lblTipoMoneda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMoneda.Location = new System.Drawing.Point(73, 299);
            this.lblTipoMoneda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoMoneda.Name = "lblTipoMoneda";
            this.lblTipoMoneda.Size = new System.Drawing.Size(114, 16);
            this.lblTipoMoneda.TabIndex = 86;
            this.lblTipoMoneda.Text = "Tipo de Moneda";
            // 
            // cboTipoMoneda
            // 
            this.cboTipoMoneda.FormattingEnabled = true;
            this.cboTipoMoneda.Location = new System.Drawing.Point(296, 299);
            this.cboTipoMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoMoneda.Name = "cboTipoMoneda";
            this.cboTipoMoneda.Size = new System.Drawing.Size(160, 24);
            this.cboTipoMoneda.TabIndex = 87;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // FrmCambioDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cboTipoMoneda);
            this.Controls.Add(this.lblTipoMoneda);
            this.Controls.Add(this.dtFechaCambio);
            this.Controls.Add(this.lblFechaCambio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCodigoCambio);
            this.Controls.Add(this.txtCodigoCambio);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCambioDia);
            this.Controls.Add(this.lblCambioDia);
            this.Controls.Add(this.FrmEmisoresTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCambioDia";
            this.Text = "FrmCambioDia";
            this.Load += new System.EventHandler(this.FrmCambioDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCodigoCambio;
        private System.Windows.Forms.TextBox txtCodigoCambio;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCambioDia;
        private System.Windows.Forms.Label lblCambioDia;
        private System.Windows.Forms.Label FrmEmisoresTitulo;
        private System.Windows.Forms.Label lblFechaCambio;
        private System.Windows.Forms.DateTimePicker dtFechaCambio;
        private System.Windows.Forms.Label lblTipoMoneda;
        private System.Windows.Forms.ComboBox cboTipoMoneda;
        private System.Windows.Forms.ErrorProvider Error;
    }
}