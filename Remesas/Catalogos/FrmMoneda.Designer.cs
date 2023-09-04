
namespace Remesas.Catalogos
{
    partial class FrmMoneda
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
            this.lblIdPais = new System.Windows.Forms.Label();
            this.txtIdMoneda = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTipoMoneda = new System.Windows.Forms.TextBox();
            this.lblNombrePais = new System.Windows.Forms.Label();
            this.FrmEmisoresTitulo = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(472, 99);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 38);
            this.btnCancelar.TabIndex = 75;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIdPais
            // 
            this.lblIdPais.AutoSize = true;
            this.lblIdPais.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPais.ForeColor = System.Drawing.Color.Black;
            this.lblIdPais.Location = new System.Drawing.Point(31, 141);
            this.lblIdPais.Name = "lblIdPais";
            this.lblIdPais.Size = new System.Drawing.Size(79, 16);
            this.lblIdPais.TabIndex = 74;
            this.lblIdPais.Text = "Id Moneda";
            // 
            // txtIdMoneda
            // 
            this.txtIdMoneda.Enabled = false;
            this.txtIdMoneda.Location = new System.Drawing.Point(198, 134);
            this.txtIdMoneda.Name = "txtIdMoneda";
            this.txtIdMoneda.ShortcutsEnabled = false;
            this.txtIdMoneda.Size = new System.Drawing.Size(212, 20);
            this.txtIdMoneda.TabIndex = 73;
            this.txtIdMoneda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdMoneda_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(472, 204);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 38);
            this.btnEliminar.TabIndex = 72;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(472, 151);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 38);
            this.btnGuardar.TabIndex = 71;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTipoMoneda
            // 
            this.txtTipoMoneda.Location = new System.Drawing.Point(198, 169);
            this.txtTipoMoneda.Name = "txtTipoMoneda";
            this.txtTipoMoneda.ShortcutsEnabled = false;
            this.txtTipoMoneda.Size = new System.Drawing.Size(212, 20);
            this.txtTipoMoneda.TabIndex = 70;
            this.txtTipoMoneda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePais_KeyPress);
            // 
            // lblNombrePais
            // 
            this.lblNombrePais.AutoSize = true;
            this.lblNombrePais.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePais.ForeColor = System.Drawing.Color.Black;
            this.lblNombrePais.Location = new System.Drawing.Point(28, 176);
            this.lblNombrePais.Name = "lblNombrePais";
            this.lblNombrePais.Size = new System.Drawing.Size(93, 16);
            this.lblNombrePais.TabIndex = 69;
            this.lblNombrePais.Text = "Tipo Moneda";
            // 
            // FrmEmisoresTitulo
            // 
            this.FrmEmisoresTitulo.AutoSize = true;
            this.FrmEmisoresTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmEmisoresTitulo.Location = new System.Drawing.Point(192, 61);
            this.FrmEmisoresTitulo.Name = "FrmEmisoresTitulo";
            this.FrmEmisoresTitulo.Size = new System.Drawing.Size(137, 32);
            this.FrmEmisoresTitulo.TabIndex = 68;
            this.FrmEmisoresTitulo.Text = "Monedas";
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // FrmMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(720, 395);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblIdPais);
            this.Controls.Add(this.txtIdMoneda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTipoMoneda);
            this.Controls.Add(this.lblNombrePais);
            this.Controls.Add(this.FrmEmisoresTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMoneda";
            this.Text = "FrmMoneda";
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblIdPais;
        private System.Windows.Forms.TextBox txtIdMoneda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtTipoMoneda;
        private System.Windows.Forms.Label lblNombrePais;
        private System.Windows.Forms.Label FrmEmisoresTitulo;
        private System.Windows.Forms.ErrorProvider Error;
    }
}