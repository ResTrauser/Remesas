
namespace Remesas.Catalogos
{
    partial class FrmPais
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
            this.lblCodigoPais = new System.Windows.Forms.Label();
            this.txtCodigoPais = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombrePais = new System.Windows.Forms.TextBox();
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
            this.btnCancelar.Location = new System.Drawing.Point(570, 85);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 38);
            this.btnCancelar.TabIndex = 67;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCodigoPais
            // 
            this.lblCodigoPais.AutoSize = true;
            this.lblCodigoPais.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPais.Location = new System.Drawing.Point(108, 137);
            this.lblCodigoPais.Name = "lblCodigoPais";
            this.lblCodigoPais.Size = new System.Drawing.Size(86, 16);
            this.lblCodigoPais.TabIndex = 64;
            this.lblCodigoPais.Text = "Codigo Pais";
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.Enabled = false;
            this.txtCodigoPais.Location = new System.Drawing.Point(275, 130);
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.ShortcutsEnabled = false;
            this.txtCodigoPais.Size = new System.Drawing.Size(212, 20);
            this.txtCodigoPais.TabIndex = 63;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(570, 190);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 38);
            this.btnEliminar.TabIndex = 61;
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
            this.btnGuardar.Location = new System.Drawing.Point(570, 137);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 38);
            this.btnGuardar.TabIndex = 60;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombrePais
            // 
            this.txtNombrePais.Location = new System.Drawing.Point(275, 165);
            this.txtNombrePais.Name = "txtNombrePais";
            this.txtNombrePais.ShortcutsEnabled = false;
            this.txtNombrePais.Size = new System.Drawing.Size(212, 20);
            this.txtNombrePais.TabIndex = 54;
            this.txtNombrePais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePais_KeyPress);
            // 
            // lblNombrePais
            // 
            this.lblNombrePais.AutoSize = true;
            this.lblNombrePais.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePais.Location = new System.Drawing.Point(105, 172);
            this.lblNombrePais.Name = "lblNombrePais";
            this.lblNombrePais.Size = new System.Drawing.Size(121, 16);
            this.lblNombrePais.TabIndex = 48;
            this.lblNombrePais.Text = "Nombres del Pais";
            // 
            // FrmEmisoresTitulo
            // 
            this.FrmEmisoresTitulo.AutoSize = true;
            this.FrmEmisoresTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmEmisoresTitulo.Location = new System.Drawing.Point(332, 54);
            this.FrmEmisoresTitulo.Name = "FrmEmisoresTitulo";
            this.FrmEmisoresTitulo.Size = new System.Drawing.Size(95, 32);
            this.FrmEmisoresTitulo.TabIndex = 47;
            this.FrmEmisoresTitulo.Text = "Paises";
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // FrmPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(696, 362);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCodigoPais);
            this.Controls.Add(this.txtCodigoPais);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombrePais);
            this.Controls.Add(this.lblNombrePais);
            this.Controls.Add(this.FrmEmisoresTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPais";
            this.Text = "FrmPais";
            this.Load += new System.EventHandler(this.FrmPais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCodigoPais;
        private System.Windows.Forms.TextBox txtCodigoPais;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombrePais;
        private System.Windows.Forms.Label lblNombrePais;
        private System.Windows.Forms.Label FrmEmisoresTitulo;
        private System.Windows.Forms.ErrorProvider Error;
    }
}