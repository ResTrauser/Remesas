﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RemesasEDM.ModeloApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Model1Container : DbContext
    {
        public Model1Container()
            : base("name=Model1Container")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<EstadoRemesa> EstadoRemesa { get; set; }
        public DbSet<Envio> Envio { get; set; }
        public DbSet<Notificaciones> Notificaciones { get; set; }
        public DbSet<ClienteEmisor> ClienteEmisor { get; set; }
        public DbSet<ClienteReceptor> ClienteReceptor { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<TipoDeCambio> TipoDeCambio { get; set; }
        public DbSet<Moneda> Moneda { get; set; }
    
        public virtual ObjectResult<usp_BuscarCliente_Result> usp_BuscarCliente2(string nom, string apellido)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("Nom", nom) :
                new ObjectParameter("Nom", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_BuscarCliente_Result>("usp_BuscarCliente2", nomParameter, apellidoParameter);
        }
    
        public virtual ObjectResult<usp_BuscarClienteReceptor_Result> usp_BuscarClienteReceptor2(string nom, string apellido)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("Nom", nom) :
                new ObjectParameter("Nom", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_BuscarClienteReceptor_Result>("usp_BuscarClienteReceptor2", nomParameter, apellidoParameter);
        }
    
        public virtual ObjectResult<usp_BuscarMoneda_Result> usp_BuscarMoneda2(string nomMoneda)
        {
            var nomMonedaParameter = nomMoneda != null ?
                new ObjectParameter("NomMoneda", nomMoneda) :
                new ObjectParameter("NomMoneda", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_BuscarMoneda_Result>("usp_BuscarMoneda2", nomMonedaParameter);
        }
    
        public virtual ObjectResult<usp_BuscarTransaccion_Result> usp_BuscarTransaccion2(string codEnvio)
        {
            var codEnvioParameter = codEnvio != null ?
                new ObjectParameter("CodEnvio", codEnvio) :
                new ObjectParameter("CodEnvio", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_BuscarTransaccion_Result>("usp_BuscarTransaccion2", codEnvioParameter);
        }
    
        public virtual ObjectResult<usp_CargarEmisor_Result> usp_CargarEmisor2(string nomEmi)
        {
            var nomEmiParameter = nomEmi != null ?
                new ObjectParameter("NomEmi", nomEmi) :
                new ObjectParameter("NomEmi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_CargarEmisor_Result>("usp_CargarEmisor2", nomEmiParameter);
        }
    
        public virtual ObjectResult<usp_CargarReceptor_Result> usp_CargarReceptor2(string nomRec)
        {
            var nomRecParameter = nomRec != null ?
                new ObjectParameter("NomRec", nomRec) :
                new ObjectParameter("NomRec", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_CargarReceptor_Result>("usp_CargarReceptor2", nomRecParameter);
        }
    }
}
