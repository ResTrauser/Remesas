
namespace Remesas.Catalogos
{
    partial class FrmClienteReceptor
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
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCodigoReceptor = new System.Windows.Forms.Label();
            this.txtCodigoReceptor = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNumeroTelefonico = new System.Windows.Forms.TextBox();
            this.txtDireccionReceptor = new System.Windows.Forms.TextBox();
            this.txt2ApellidoReceptor = new System.Windows.Forms.TextBox();
            this.txt1ApellidoReceptor = new System.Windows.Forms.TextBox();
            this.txtNombreReceptor = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FrmEmisoresTitulo = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPais
            // 
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(367, 463);
            this.cboPais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(160, 24);
            this.cboPais.TabIndex = 46;
            this.cboPais.Text = "Selecciona el Pais";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(819, 160);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 47);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(193, 463);
            this.lblPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(51, 16);
            this.lblPais.TabIndex = 44;
            this.lblPais.Text = "Id Pais";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(819, 287);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 47);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCodigoReceptor
            // 
            this.lblCodigoReceptor.AutoSize = true;
            this.lblCodigoReceptor.Location = new System.Drawing.Point(144, 169);
            this.lblCodigoReceptor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoReceptor.Name = "lblCodigoReceptor";
            this.lblCodigoReceptor.Size = new System.Drawing.Size(152, 16);
            this.lblCodigoReceptor.TabIndex = 42;
            this.lblCodigoReceptor.Text = "Codigo Cliente Emisor";
            this.lblCodigoReceptor.Visible = false;
            // 
            // txtCodigoReceptor
            // 
            this.txtCodigoReceptor.Location = new System.Drawing.Point(367, 160);
            this.txtCodigoReceptor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoReceptor.Name = "txtCodigoReceptor";
            this.txtCodigoReceptor.ShortcutsEnabled = false;
            this.txtCodigoReceptor.Size = new System.Drawing.Size(281, 23);
            this.txtCodigoReceptor.TabIndex = 41;
            this.txtCodigoReceptor.Visible = false;
            this.txtCodigoReceptor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoReceptor_KeyPress);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(819, 348);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 47);
            this.btnEditar.TabIndex = 40;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(819, 411);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 47);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(819, 224);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 47);
            this.btnGuardar.TabIndex = 38;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(367, 411);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ShortcutsEnabled = false;
            this.txtCedula.Size = new System.Drawing.Size(281, 23);
            this.txtCedula.TabIndex = 37;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtNumeroTelefonico
            // 
            this.txtNumeroTelefonico.Location = new System.Drawing.Point(367, 367);
            this.txtNumeroTelefonico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroTelefonico.Name = "txtNumeroTelefonico";
            this.txtNumeroTelefonico.ShortcutsEnabled = false;
            this.txtNumeroTelefonico.Size = new System.Drawing.Size(281, 23);
            this.txtNumeroTelefonico.TabIndex = 36;
            this.txtNumeroTelefonico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTelefonico_KeyPress);
            // 
            // txtDireccionReceptor
            // 
            this.txtDireccionReceptor.Location = new System.Drawing.Point(367, 326);
            this.txtDireccionReceptor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccionReceptor.Name = "txtDireccionReceptor";
            this.txtDireccionReceptor.ShortcutsEnabled = false;
            this.txtDireccionReceptor.Size = new System.Drawing.Size(281, 23);
            this.txtDireccionReceptor.TabIndex = 35;
            this.txtDireccionReceptor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccionReceptor_KeyPress);
            // 
            // txt2ApellidoReceptor
            // 
            this.txt2ApellidoReceptor.Location = new System.Drawing.Point(367, 287);
            this.txt2ApellidoReceptor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt2ApellidoReceptor.Name = "txt2ApellidoReceptor";
            this.txt2ApellidoReceptor.ShortcutsEnabled = false;
            this.txt2ApellidoReceptor.Size = new System.Drawing.Size(281, 23);
            this.txt2ApellidoReceptor.TabIndex = 34;
            this.txt2ApellidoReceptor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2ApellidoReceptor_KeyPress);
            // 
            // txt1ApellidoReceptor
            // 
            this.txt1ApellidoReceptor.Location = new System.Drawing.Point(367, 249);
            this.txt1ApellidoReceptor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt1ApellidoReceptor.Name = "txt1ApellidoReceptor";
            this.txt1ApellidoReceptor.ShortcutsEnabled = false;
            this.txt1ApellidoReceptor.Size = new System.Drawing.Size(281, 23);
            this.txt1ApellidoReceptor.TabIndex = 33;
            this.txt1ApellidoReceptor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1ApellidoReceptor_KeyPress);
            // 
            // txtNombreReceptor
            // 
            this.txtNombreReceptor.Location = new System.Drawing.Point(367, 203);
            this.txtNombreReceptor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreReceptor.Name = "txtNombreReceptor";
            this.txtNombreReceptor.ShortcutsEnabled = false;
            this.txtNombreReceptor.Size = new System.Drawing.Size(281, 23);
            this.txtNombreReceptor.TabIndex = 32;
            this.txtNombreReceptor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreReceptor_KeyPress);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(140, 420);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(219, 16);
            this.lblCedula.TabIndex = 31;
            this.lblCedula.Text = "Numero de cedula de identidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Numero telefonico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 335);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Dirección del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Segundo apellido del cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Primer apellido del cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombres del cliente";
            // 
            // FrmEmisoresTitulo
            // 
            this.FrmEmisoresTitulo.AutoSize = true;
            this.FrmEmisoresTitulo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmEmisoresTitulo.Location = new System.Drawing.Point(443, 66);
            this.FrmEmisoresTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FrmEmisoresTitulo.Name = "FrmEmisoresTitulo";
            this.FrmEmisoresTitulo.Size = new System.Drawing.Size(215, 26);
            this.FrmEmisoresTitulo.TabIndex = 25;
            this.FrmEmisoresTitulo.Text = "Clientes Receptores";
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // FrmClienteReceptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cboPais);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCodigoReceptor);
            this.Controls.Add(this.txtCodigoReceptor);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNumeroTelefonico);
            this.Controls.Add(this.txtDireccionReceptor);
            this.Controls.Add(this.txt2ApellidoReceptor);
            this.Controls.Add(this.txt1ApellidoReceptor);
            this.Controls.Add(this.txtNombreReceptor);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FrmEmisoresTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmClienteReceptor";
            this.Text = "FrmClienteReceptor";
            this.Load += new System.EventHandler(this.FrmClienteReceptor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCodigoReceptor;
        private System.Windows.Forms.TextBox txtCodigoReceptor;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNumeroTelefonico;
        private System.Windows.Forms.TextBox txtDireccionReceptor;
        private System.Windows.Forms.TextBox txt2ApellidoReceptor;
        private System.Windows.Forms.TextBox txt1ApellidoReceptor;
        private System.Windows.Forms.TextBox txtNombreReceptor;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FrmEmisoresTitulo;
        private System.Windows.Forms.ErrorProvider Error;
    }
}