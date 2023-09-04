
namespace Remesas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteEmisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteReceptorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDelDíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosDeRemesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesEmisoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesReceptoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarTransaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCambiosDeMonedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarTransacciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrarTransacciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesReallizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeCambiosDeMonedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPermisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarPermisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.catalogosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteEmisorToolStripMenuItem,
            this.clienteReceptorToolStripMenuItem,
            this.paisToolStripMenuItem,
            this.cambioDelDíaToolStripMenuItem,
            this.monedaToolStripMenuItem,
            this.estadosDeRemesasToolStripMenuItem});
            this.catalogosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // clienteEmisorToolStripMenuItem
            // 
            this.clienteEmisorToolStripMenuItem.Name = "clienteEmisorToolStripMenuItem";
            this.clienteEmisorToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.clienteEmisorToolStripMenuItem.Text = "Cliente Emisor";
            this.clienteEmisorToolStripMenuItem.Click += new System.EventHandler(this.clienteEmisorToolStripMenuItem_Click);
            // 
            // clienteReceptorToolStripMenuItem
            // 
            this.clienteReceptorToolStripMenuItem.Name = "clienteReceptorToolStripMenuItem";
            this.clienteReceptorToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.clienteReceptorToolStripMenuItem.Text = "Cliente Receptor";
            this.clienteReceptorToolStripMenuItem.Click += new System.EventHandler(this.clienteReceptorToolStripMenuItem_Click);
            // 
            // paisToolStripMenuItem
            // 
            this.paisToolStripMenuItem.Name = "paisToolStripMenuItem";
            this.paisToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.paisToolStripMenuItem.Text = "Pais";
            this.paisToolStripMenuItem.Click += new System.EventHandler(this.paisToolStripMenuItem_Click);
            // 
            // cambioDelDíaToolStripMenuItem
            // 
            this.cambioDelDíaToolStripMenuItem.Name = "cambioDelDíaToolStripMenuItem";
            this.cambioDelDíaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cambioDelDíaToolStripMenuItem.Text = "Cambio del Día";
            this.cambioDelDíaToolStripMenuItem.Click += new System.EventHandler(this.cambioDelDíaToolStripMenuItem_Click);
            // 
            // monedaToolStripMenuItem
            // 
            this.monedaToolStripMenuItem.Name = "monedaToolStripMenuItem";
            this.monedaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.monedaToolStripMenuItem.Text = "Moneda";
            this.monedaToolStripMenuItem.Click += new System.EventHandler(this.monedaToolStripMenuItem_Click);
            // 
            // estadosDeRemesasToolStripMenuItem
            // 
            this.estadosDeRemesasToolStripMenuItem.Name = "estadosDeRemesasToolStripMenuItem";
            this.estadosDeRemesasToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.estadosDeRemesasToolStripMenuItem.Text = "Estados de Remesas";
            this.estadosDeRemesasToolStripMenuItem.Click += new System.EventHandler(this.estadosDeRemesasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarClientesToolStripMenuItem,
            this.buscarTransaccionesToolStripMenuItem,
            this.buscarCambiosDeMonedaToolStripMenuItem});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // buscarClientesToolStripMenuItem
            // 
            this.buscarClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesEmisoresToolStripMenuItem,
            this.clientesReceptoresToolStripMenuItem});
            this.buscarClientesToolStripMenuItem.Name = "buscarClientesToolStripMenuItem";
            this.buscarClientesToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.buscarClientesToolStripMenuItem.Text = "Buscar Clientes";
            // 
            // clientesEmisoresToolStripMenuItem
            // 
            this.clientesEmisoresToolStripMenuItem.Name = "clientesEmisoresToolStripMenuItem";
            this.clientesEmisoresToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.clientesEmisoresToolStripMenuItem.Text = "Clientes Emisores";
            this.clientesEmisoresToolStripMenuItem.Click += new System.EventHandler(this.clientesEmisoresToolStripMenuItem_Click);
            // 
            // clientesReceptoresToolStripMenuItem
            // 
            this.clientesReceptoresToolStripMenuItem.Name = "clientesReceptoresToolStripMenuItem";
            this.clientesReceptoresToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.clientesReceptoresToolStripMenuItem.Text = "Clientes Receptores";
            this.clientesReceptoresToolStripMenuItem.Click += new System.EventHandler(this.clientesReceptoresToolStripMenuItem_Click);
            // 
            // buscarTransaccionesToolStripMenuItem
            // 
            this.buscarTransaccionesToolStripMenuItem.Name = "buscarTransaccionesToolStripMenuItem";
            this.buscarTransaccionesToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.buscarTransaccionesToolStripMenuItem.Text = "Buscar Transacciones";
            this.buscarTransaccionesToolStripMenuItem.Click += new System.EventHandler(this.buscarTransaccionesToolStripMenuItem_Click);
            // 
            // buscarCambiosDeMonedaToolStripMenuItem
            // 
            this.buscarCambiosDeMonedaToolStripMenuItem.Name = "buscarCambiosDeMonedaToolStripMenuItem";
            this.buscarCambiosDeMonedaToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.buscarCambiosDeMonedaToolStripMenuItem.Text = "Buscar Cambios de Moneda";
            this.buscarCambiosDeMonedaToolStripMenuItem.Click += new System.EventHandler(this.buscarCambiosDeMonedaToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarTransacciónToolStripMenuItem,
            this.ModificarEstadoToolStripMenuItem,
            this.cobrarTransacciónToolStripMenuItem});
            this.operacionesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacionesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // realizarTransacciónToolStripMenuItem
            // 
            this.realizarTransacciónToolStripMenuItem.Name = "realizarTransacciónToolStripMenuItem";
            this.realizarTransacciónToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.realizarTransacciónToolStripMenuItem.Text = "Realizar Transacción";
            this.realizarTransacciónToolStripMenuItem.Click += new System.EventHandler(this.realizarTransacciónToolStripMenuItem_Click);
            // 
            // ModificarEstadoToolStripMenuItem
            // 
            this.ModificarEstadoToolStripMenuItem.Name = "ModificarEstadoToolStripMenuItem";
            this.ModificarEstadoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ModificarEstadoToolStripMenuItem.Text = "Modificar estado";
            this.ModificarEstadoToolStripMenuItem.Click += new System.EventHandler(this.ModificarEstadoToolStripMenuItem_Click);
            // 
            // cobrarTransacciónToolStripMenuItem
            // 
            this.cobrarTransacciónToolStripMenuItem.Name = "cobrarTransacciónToolStripMenuItem";
            this.cobrarTransacciónToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.cobrarTransacciónToolStripMenuItem.Text = "Cobrar Transacción";
            this.cobrarTransacciónToolStripMenuItem.Click += new System.EventHandler(this.cobrarTransacciónToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaccionesReallizadasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.tiposDeCambiosDeMonedaToolStripMenuItem});
            this.informesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // transaccionesReallizadasToolStripMenuItem
            // 
            this.transaccionesReallizadasToolStripMenuItem.Name = "transaccionesReallizadasToolStripMenuItem";
            this.transaccionesReallizadasToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.transaccionesReallizadasToolStripMenuItem.Text = "Transacciones Reallizadas";
            this.transaccionesReallizadasToolStripMenuItem.Click += new System.EventHandler(this.transaccionesReallizadasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emisorToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // emisorToolStripMenuItem
            // 
            this.emisorToolStripMenuItem.Name = "emisorToolStripMenuItem";
            this.emisorToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.emisorToolStripMenuItem.Text = "Emisor";
            this.emisorToolStripMenuItem.Click += new System.EventHandler(this.emisorToolStripMenuItem_Click);
            // 
            // tiposDeCambiosDeMonedaToolStripMenuItem
            // 
            this.tiposDeCambiosDeMonedaToolStripMenuItem.Name = "tiposDeCambiosDeMonedaToolStripMenuItem";
            this.tiposDeCambiosDeMonedaToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.tiposDeCambiosDeMonedaToolStripMenuItem.Text = "Tipos de Cambios de Moneda";
            this.tiposDeCambiosDeMonedaToolStripMenuItem.Click += new System.EventHandler(this.tiposDeCambiosDeMonedaToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem,
            this.crearPermisoToolStripMenuItem,
            this.asignarPermisoToolStripMenuItem});
            this.seguridadToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seguridadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioToolStripMenuItem_Click);
            // 
            // crearPermisoToolStripMenuItem
            // 
            this.crearPermisoToolStripMenuItem.Name = "crearPermisoToolStripMenuItem";
            this.crearPermisoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.crearPermisoToolStripMenuItem.Text = "Crear Permiso";
            this.crearPermisoToolStripMenuItem.Click += new System.EventHandler(this.crearPermisoToolStripMenuItem_Click);
            // 
            // asignarPermisoToolStripMenuItem
            // 
            this.asignarPermisoToolStripMenuItem.Name = "asignarPermisoToolStripMenuItem";
            this.asignarPermisoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.asignarPermisoToolStripMenuItem.Text = "Asignar Permiso";
            this.asignarPermisoToolStripMenuItem.Click += new System.EventHandler(this.asignarPermisoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminarToolStripMenuItem});
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // terminarToolStripMenuItem
            // 
            this.terminarToolStripMenuItem.Name = "terminarToolStripMenuItem";
            this.terminarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.terminarToolStripMenuItem.Text = "Terminar";
            this.terminarToolStripMenuItem.Click += new System.EventHandler(this.terminarToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 506);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1257, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteEmisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteReceptorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDelDíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarTransaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarCambiosDeMonedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarTransacciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModificarEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesReallizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeCambiosDeMonedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPermisoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarPermisoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesEmisoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesReceptoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrarTransacciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadosDeRemesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emisorToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

